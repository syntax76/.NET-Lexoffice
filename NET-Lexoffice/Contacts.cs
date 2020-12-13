// MIT License
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
using System.Threading.Tasks;
using ahbsd.lib;
using RestSharp;

namespace ahbsd.Lexoffice.Rest
{
    /// <summary>
    /// Class for reading Contacts.
    /// </summary>
    public class Contacts : HTTPClient, IHTTPClient
    {
        /// <summary>
        /// Constructor with API-Key.
        /// </summary>
        /// <param name="apiKey">The API-Key.</param>
        public Contacts(string apiKey)
            : base(apiKey)
        { }

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public Contacts()
            : base()
        { }

        /// <summary>
        /// Gets all Contacts.
        /// </summary>
        /// <param name="page">The Page to begin with.</param>
        /// <returns>All Contacts.</returns>
        public async Task<string> GetAllContacts(int page = 0)
        {
            return await Send(Method.GET, $"contacts/?page={page}");
        }
    }
}