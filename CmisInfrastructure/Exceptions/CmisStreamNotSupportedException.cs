//
// CmisStreamNotSupportedException.cs
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

using System;
namespace Cmis.Infrastructure
{
    /// <summary>
    /// CMIS stream not supported exception.
    /// This exception MAY be returned by a repositiory in response to one or more CMIS service methods calls.
    /// The "Intent" ﬁeld indicates the intent of this exception.
    /// </summary>
    public class CmisStreamNotSupportedException : CmisExceptionBase
    {
        #region Properties

        /// <summary>
        /// Gets the exception intent.
        /// </summary>
        /// <value>The exception intent.</value>
        public override string Intent
        {
            get
            {
                return "The operation is attempting to get or set a content stream for a document whose object-type speciﬁes that a content stream is not allowed for document’s of that type.";
            }
        }

        /// <summary>
        /// Gets the CMIS exception name.
        /// </summary>
        /// <value>The CMIS exception name.</value>
        public override string Name
        {
            get
            {
                return "streamNotSupported";
            }
        }

        #endregion

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisStreamNotSupportedException"/> class.
        /// </summary>
        public CmisStreamNotSupportedException() { Code = 403L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisStreamNotSupportedException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public CmisStreamNotSupportedException(string message) : base(message) { Code = 403L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisStreamNotSupportedException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        public CmisStreamNotSupportedException(string message, Exception innerException) : base(message, innerException) { Code = 403L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisStreamNotSupportedException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        /// <param name="code">Exception code.</param>
        /// <param name="content">Exception content.</param>
        public CmisStreamNotSupportedException(string message, Exception innerException, long? code, string content) : base(message, innerException, code, content) { Code = code ?? 403L; }

        #endregion
    }
}