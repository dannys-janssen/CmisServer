//
// CmisContentAlreadyExistsException.cs
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
    /// CMIS content already exists exception.
    /// This exception MAY be returned by a repositiory in response to one or more CMIS service methods calls.
    /// The "Intent" ﬁeld indicates the intent of this exception.
    /// </summary>
    public class CmisContentAlreadyExistsException : CmisExceptionBase
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
                return "The operation attempts to set the content stream for a document that already has a content stream without explicitly specifying the \"overwriteFlag\" parameter.";
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
                return "contentAlreadyExists";
            }
        }

        #endregion

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisContentAlreadyExistsException"/> class.
        /// </summary>
        public CmisContentAlreadyExistsException() { Code = 409L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisContentAlreadyExistsException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public CmisContentAlreadyExistsException(string message) : base(message) { Code = 409L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisContentAlreadyExistsException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        public CmisContentAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { Code = 409L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisContentAlreadyExistsException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        /// <param name="code">Exception code.</param>
        /// <param name="content">Exception content.</param>
        public CmisContentAlreadyExistsException(string message, Exception innerException, long? code, string content) : base(message, innerException, code, content) { Code = code ?? 409L; }

        #endregion
    }
}
