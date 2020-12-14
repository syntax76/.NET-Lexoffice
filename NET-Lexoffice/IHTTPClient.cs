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
using RestSharp;

namespace ahbsd.Lexoffice.Rest
{
    /// <summary>
    /// Interface for HTTP-Client.
    /// </summary>
    public interface IHTTPClient
    {
        /// <summary>
        /// Returns the response content.
        /// </summary>
        /// <param name="method">HTTP-Method to use.</param>
        /// <param name="path">The specific path to use.</param>
        /// <param name="parameters">Parameters.</param>
        /// <returns>The response content</returns>
        [Obsolete]
        Task<string> Send(Method method, string path, params Parameter[] parameters);
        /// <summary>
        /// Returns the response content.
        /// </summary>
        /// <param name="method">HTTP-Method to use.</param>
        /// <param name="path">The specific path to use.</param>
        /// <returns>The response content</returns>
        Task<string> Send(Method method, string path);
        /// <summary>
        /// Returns the last response of a <see cref="Send(Method, string)"/>.
        /// </summary>
        /// <value>The last response.</value>
        object Response { get; }
    }
}