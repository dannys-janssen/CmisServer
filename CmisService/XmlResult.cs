//
// XmlResult.cs
//
// Author:
//       Dannys Janssen
//
// Copyright (c) 2017 Dannys Janssen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace Cmis.Service
{
    using System;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="ActionResult"/> implementation that will return results formatted as XML.
    /// </summary>
    public class XmlResult : ActionResult
    {
		/// <summary>
		/// Gets or sets the <see cref="System.Net.Http.Headers.MediaTypeHeaderValue"/> representing the Content-Type header of the response.
		/// </summary>
		/// <value>The type of the content.</value>
		public string ContentType { get; set; }

		/// <summary>
		/// Gets or sets the HTTP status code.
		/// </summary>
		/// <value>The HTTP status code.</value>
		public int? StatusCode { get; set; }

		/// <summary>
		/// Gets or sets the value to be formatted.
		/// </summary>
		/// <value>The value to be formatted.</value>
		public XDocument Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Service.XmlResult"/> class.
        /// </summary>
        /// <param name="value">The value to be converted.</param>
        /// <param name="contentType">The content type (MIME type) to be used in the reponse.</param>
        public XmlResult(XDocument value, string contentType = null)
        {
            Value = value;
            ContentType = contentType;
        }

		/// <inheritdoc />
		public override Task ExecuteResultAsync(ActionContext context)
        {
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}

            var response = context.HttpContext.Response;

            if (!string.IsNullOrWhiteSpace(ContentType))
            {
                response.ContentType = ContentType;
            }
            else
            {
                response.ContentType = "text/xml";
            }

            if (StatusCode.HasValue)
                response.StatusCode = StatusCode.Value;

            if (Value != null)
            {
                Value.Save(context.HttpContext.Response.Body, SaveOptions.None);
                return Task.FromResult(0);

            }
            return base.ExecuteResultAsync(context);
        }
    }
}
