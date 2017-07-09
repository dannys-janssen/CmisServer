//
// CmisInvalidArgumentException.cs
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
    /// CMIS invalid argument exception. 
    /// This exception MAY be returned by a repository in response to ANY CMIS service method call.
    /// The "Cause" ﬁeld indicates the circumstances under which a repository SHOULD return this exception.
    /// </summary>
    public class CmisInvalidArgumentException : CmisExceptionBase
    {
        #region Properties

        /// <summary>
        /// Gets the exception cause.
        /// </summary>
        /// <value>The exception cause.</value>
        public override string Cause
        {
            get
            {
                return "One or more of the input parameters to the service method is missing or invalid.";
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
                return "invalidArgument";
            }
        }

        #endregion

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisInvalidArgumentException"/> class.
        /// </summary>
        public CmisInvalidArgumentException() { Code = 400L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisInvalidArgumentException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        public CmisInvalidArgumentException(string message) : base(message) { Code = 400L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisInvalidArgumentException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        public CmisInvalidArgumentException(string message, Exception innerException) : base(message, innerException) { Code = 400L; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisInvalidArgumentException"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        /// <param name="code">Exception code.</param>
        /// <param name="content">Exception content.</param>
        public CmisInvalidArgumentException(string message, Exception innerException, long? code, string content) : base(message, innerException, code, content) { Code = code ?? 400L; }

        #endregion
    }
}