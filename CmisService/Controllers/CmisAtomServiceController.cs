//
// CmisAtomServiceController.cs
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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cmis.Service
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Cmis.Interface;
    using Cmis.Infrastructure;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// CMIS AtomPub service controller.
    /// </summary>
    public class CmisAtomServiceController : Controller
    {
        #region Fields

        /// <summary>
        /// The CMIS repository service instance.
        /// </summary>
        readonly ICmisRepositoryService _repositoryService;

        /// <summary>
        /// The AtomPub service converter.
        /// </summary>
        readonly AtomServiceXDocumentConverter _serviceConverter;

        /// <summary>
        /// The logger.
        /// </summary>
        readonly ILogger<CmisAtomServiceController> _logger;

        #endregion

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Service.CmisAtomServiceController"/> class.
        /// </summary>
        /// <param name="repositoryService">CMIS repository service instance.</param>
        public CmisAtomServiceController(ICmisRepositoryService repositoryService, ILogger<CmisAtomServiceController> logger)
        {
            _repositoryService = repositoryService;
            _serviceConverter = new AtomServiceXDocumentConverter();
            _logger = logger;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the list of repositories.
        /// </summary>
        /// <returns>The repositories list.</returns>
        [HttpGet("api/cmis/1.1/atom")]
        public async Task<IActionResult> GetRepositories()
        {
            SetServiceRoot();

            var result = await _repositoryService.GetServiceDocumentAsync();
            return new XmlResult(_serviceConverter.Convert(result), Constants.CmisMediaTypeService);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Sets the service root URI.
        /// </summary>
        void SetServiceRoot()
        {
            var serviceRoot = $"{Request.Scheme}://{Request.Host}";
            _repositoryService.ServiceRoot = serviceRoot;
        }

        #endregion
    }
}
