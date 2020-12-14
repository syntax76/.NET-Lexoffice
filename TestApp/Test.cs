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
using ahbsd.Lexoffice.Rest;

namespace TestApp
{
    /// <summary>
    /// A test class.
    /// </summary>
    internal class Test
    {
        /// <summary>
        /// Main function to run.
        /// </summary>
        /// <param name="args">Optional parameters.</param>
        private static void Main(string[] args)
        {
            Lexoffice lo = null;
            string apiKey, result;
            object response = null;

            result = string.Empty;

            if (args.Length > 0)
            {
                try
                {
                    apiKey = args[0].Trim();
                    lo = new Lexoffice(apiKey);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("A {0} happened.\nMessage: {1}\n\nStackTrace:\n{2}\n----------------------------", ex.GetType(), ex.Message, ex.StackTrace));
                }
            }
            else
            {
                lo = new Lexoffice("abcd");
            }

            if (lo != null)
            {
                try
                {
                    result = lo.Contacts.GetAllContacts().Result;
                    response = lo.Contacts.Response;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("A {0} happened.\nMessage: {1}\n\nStackTrace:\n{2}\n----------------------------", ex.GetType(), ex.Message, ex.StackTrace));
                    result = ex.Message;
                }
            }
            
            Console.WriteLine(result);
        }
    }
}