//
// CmisExceptionBase.cs
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
    /// CMIS exception base class. Abstract base class for all CMIS exceptions.
    /// </summary>
    public abstract class CmisExceptionBase : Exception
    {
        #region Properties

        /// <summary>
        /// Gets or sets the exception cause.
        /// </summary>
        /// <value>The exception cause.</value>
        public virtual string Cause { get; protected set; }

        /// <summary>
        /// Gets or sets the CMIS exception code.
        /// </summary>
        /// <value>The code.</value>
        public long? Code { get; protected set; }

        /// <summary>
        /// Gets or sets the content of the exception.
        /// </summary>
        /// <value>The content of the exception.</value>
        public string Content { get; protected set; }

        /// <summary>
        /// Gets or sets the excpetion intent.
        /// </summary>
        /// <value>The exception intent.</value>
        public virtual string Intent { get; protected set; }

        /// <summary>
        /// Gets or sets the CMIS exception name.
        /// </summary>
        /// <value>The CMIS exception name.</value>
        public virtual string Name { get; protected set; }

        #endregion

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisExceptionBase"/> class.
        /// </summary>
        protected CmisExceptionBase() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisExceptionBase"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        protected CmisExceptionBase(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisExceptionBase"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        protected CmisExceptionBase(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Infrastructure.CmisExceptionBase"/> class.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="innerException">Inner exception.</param>
        /// <param name="code">CMIS exception code.</param>
        /// <param name="content">Exception content.</param>
        protected CmisExceptionBase(string message, Exception innerException, long? code, string content) : this(message, innerException)
        {
            Content = content;
            Code = code;
        }

        #endregion
    }
}