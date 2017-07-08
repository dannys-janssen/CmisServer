//
// CmisExceptionFilterAttribute.cs
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

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Cmis.Interface
{
    /// <summary>
    /// CMIS exception filter attribute. Handles all unhandled exceptions and returns CMIS compliant excpetions.
    /// </summary>
    public class CmisExceptionFilterAttribute : ExceptionFilterAttribute
    {
        #region Fields
        readonly IHostingEnvironment _hostingEnvironment;
        readonly IModelMetadataProvider _modelMetadataProvider;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Interface.CmisExceptionFilterAttribute"/> class.
        /// </summary>
        /// <param name="hostingEnvironment">Hosting environment.</param>
        /// <param name="modelMetadataProvider">Model metadata provider.</param>
        public CmisExceptionFilterAttribute(
            IHostingEnvironment hostingEnvironment, 
            IModelMetadataProvider modelMetadataProvider)
        {
            _hostingEnvironment = hostingEnvironment;
            _modelMetadataProvider = modelMetadataProvider;
        }

		/// <summary>
		/// Runs when an unhandled exception occurs during the execution of an action.
		/// </summary>
		/// <param name="context">Exception context.</param>
		public override void OnException(ExceptionContext context)
        {
            if (!_hostingEnvironment.IsDevelopment())
            {
                return;
            }
            context.Result = new BadRequestObjectResult(context.ModelState);
        }
    }
}
