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
using System.Collections.Generic;
using System.Threading.Tasks;
using ahbsd.lib.lexoffice;
using Newtonsoft.Json;
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
        {
            ContactsList = null;
        }

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public Contacts()
            : base()
        {
            ContactsList = null;
        }

        /// <summary>
        /// Gets all Contacts.
        /// </summary>
        /// <param name="page">The Page to begin with.</param>
        /// <returns>All Contacts.</returns>
        public async Task<string> GetAllContacts(int page = 0)
        {
            string result;

            result = await Send(Method.GET, $"contacts/?page={page}");

            ContactsList = GetContacts(result);

#if DEBUG
            foreach (var item in ContactsList)
            {
                Console.WriteLine(item.ToString());
            }

#endif

            return result;
        }

        public List<Contact> ContactsList { get; private set; }

        private static List<Contact> GetContacts(string content)
        {
            List<Contact> result = null;

            try
            {
                ContactList c = JsonConvert.DeserializeObject<ContactList>(content);

                result = c.Content;
            }
            catch (Exception ex)
            {
                PrintException(ex);
            }

            return result;
        }

        /// <summary>
        /// Prints an <see cref="Exception"/> to console.
        /// </summary>
        /// <param name="ex">The <see cref="Exception"/>.</param>
        internal static void PrintException(Exception ex)
        {
            Console.WriteLine("An {0} happened!\n\n;Message: {1}\n\nStackTrace:\n{2}\n------------", ex.GetType(), ex.Message, ex.StackTrace);
        }
    }
}