﻿// MIT License
// 
// Copyright (c) 2020 Nils Kleinert
// Forked by Heinrich Alexandra Hermann
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System;
using System.Security.Authentication;
using System.Threading.Tasks;
using ahbsd.lib.lexoffice;
using Newtonsoft.Json;
using RestSharp;

namespace ahbsd.Lexoffice.Rest
{
    /// <summary>
    /// HTTP-Client for Lexoffice REST-Api
    /// </summary>
    public class HTTPClient : LexofficeApiKey, IHTTPClient
    {
        /// <summary>
        /// The basic URI for LexOffice REST-API
        /// </summary>
        public const string BasicUriLexoffice = "https://api.lexoffice.io/";

        /// <summary>
        /// The last response.
        /// </summary>
        private object _response;

        /// <summary>
        /// The current REST-Version.
        /// </summary>
        private static string _restVersion;
        /// <summary>
        /// Gets or sets the current LexOffice REST-API version.
        /// </summary>
        /// <value>The current LexOffice REST-API version.</value>
        /// <remarks>Usually <c>v</c>X where X is the current number. The set also updates the current <see cref="BasicUri"/>.</remarks>
        public static string LexofficeRestVersion
        {
            get => _restVersion;
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Trim().Equals(string.Empty))
                {
                    _restVersion = value;
                    BasicUri = new Uri(BasicUriLexoffice + LexofficeRestVersion);
                }
            }
        }

        /// <summary>
        /// Gets the current basic URI. 
        /// </summary>
        /// <value>The current basic URI.</value>
        public static Uri BasicUri { get; private set; }

        /// <summary>
        /// Static constructor.
        /// </summary>
        static HTTPClient()
        {
            LexofficeRestVersion = "v1/";
        }

        /// <summary>
        /// Constructor with a given API-Key.
        /// </summary>
        /// <param name="apiKey">The API-Key.</param>
        public HTTPClient(string apiKey)
            : base(apiKey)
        {

        }

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public HTTPClient()
            : base()
        {

        }

        #region implementation of IHTTPClient

        /// <summary>
        /// Returns the response content.
        /// </summary>
        /// <param name="method">HTTP-Method to use.</param>
        /// <param name="path">The specific path to use.</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>The response</returns>
        [Obsolete]
        public async Task<string> Send(Method method, string path, params Parameter[] parameters)
        {
            string result;
            string tmp;

            AuthenticationException ae;

            string clientPath = string.Format("{0}{1}", BasicUri, path);

            RestClient client = new RestClient(clientPath);
            client.Timeout = -1;

            RestRequest request = new RestRequest(method);

            request.AddHeader("Authorization", $"Bearer {ApiKey}");
            request.AddHeader("Accept", "application/json");

            if (parameters != null)
                foreach (Parameter parameter in parameters)
                    request.AddParameter(parameter);

            IRestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                result = response.Content;
                SetResponse(response.Content);
            }
            else
            {
                if (!string.IsNullOrEmpty(ApiKey) && !ApiKey.Trim().Equals(string.Empty))
                {
                    tmp = "Invalid API-Key";
                }
                else
                {
                    tmp = "No API-Key set";
                }
                ae = new AuthenticationException(tmp);

                throw ae;
            }
            return result;
        }


        /// <summary>
        /// Returns the response content.
        /// </summary>
        /// <param name="method">HTTP-Method to use.</param>
        /// <param name="path">The specific path to use.</param>
        /// <returns>The response content</returns>
        /// <exception cref="AuthenticationException">If the API-Key is invalid.</exception>
        public async Task<string> Send(Method method, string path)
        {
            string result, tmp;
            AuthenticationException ae;

            string clientPath = string.Format("{0}{1}", BasicUri, path);

            RestClient client = new RestClient(clientPath);
            client.Timeout = -1;

            RestRequest request = new RestRequest(method);

            request.AddHeader("Authorization", $"Bearer {ApiKey}");
            request.AddHeader("Accept", "application/json");

            IRestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                result = response.Content;
                SetResponse(result);
            }
            else
            {
                if (!string.IsNullOrEmpty(ApiKey) && !ApiKey.Trim().Equals(string.Empty))
                {
                    tmp = string.Format("Invalid API-Key: \nContent: {0}\nErrormessage: {1}", response.Content, response.ErrorMessage);
                    SetResponse(response.Content);
                }
                else
                {
                    tmp = string.Format("No API-Key set \nContent: {0}\nErrormessage: {1}", response.Content, response.ErrorMessage);
                }
                ae = new AuthenticationException(tmp);

                throw ae;
            }
            return result;
        }


        /// <summary>
        /// Returns the last response of a <see cref="Send(Method, string)"/>.
        /// </summary>
        /// <value>The last response.</value>
        public object Response => _response;
        #endregion

        /// <summary>
        /// Sets the <see cref="Response"/> from a string from the last Send.
        /// </summary>
        /// <param name="response">The string from the last Send.</param>
        private void SetResponse(string response)
        {
            _response = JsonConvert.DeserializeObject(response);
        }
    }
}