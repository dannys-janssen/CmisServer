//
// CmisJsonServiceController.cs
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
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Cmis.Interface;
    using Cmis.Infrastructure;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;

    /// <summary>
    /// CMIS JSON service controller.
    /// </summary>
    public class CmisJsonServiceController : Controller
    {
		#region Fields

		/// <summary>
		/// The CMIS repository service instance.
		/// </summary>
		readonly ICmisRepositoryService _repositoryService;

        /// <summary>
        /// The serializer settings.
        /// </summary>
        readonly JsonSerializerSettings _serializerSettings;

		/// <summary>
		/// The logger.
		/// </summary>
		readonly ILogger<CmisJsonServiceController> _logger;

        #endregion

        #region ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Service.CmisJsonServiceController"/> class.
        /// </summary>
        /// <param name="repositoryService">CMIS repository service instance.</param>
        public CmisJsonServiceController(ICmisRepositoryService repositoryService, ILogger<CmisJsonServiceController> logger)
        {
            _repositoryService = repositoryService;
            _logger = logger;
			_serializerSettings = new JsonSerializerSettings
            {
				Converters = new List<JsonConverter>()
			};

			_serializerSettings.Converters.Add(new CmisRepositoryInfoJsonConverter());
			_serializerSettings.Converters.Add(new CmisRepositoryShortInfoJsonConverter());
			_serializerSettings.Formatting = Formatting.Indented;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the list of repositories.
        /// </summary>
        /// <returns>The repositories list.</returns>
        [ValidateModelFilter]
        [HttpGet("api/cmis/1.1/browser")]
        public async Task<IActionResult> GetRepositories()
        {
            SetServiceRoot();
            var result = await _repositoryService.GetRepositoriesAsync();
            return new JsonResult(result, _serializerSettings);
        }

		/// <summary>
		/// Gets the repository info for a specific CMIS repository.
		/// </summary>
		/// <returns>The repository info.</returns>
		/// <param name="repositoryId">Repository identifier.</param>
        [HttpGet("api/{repositoryId}/cmis/1.1/browser")]
		public async Task<IActionResult> GetRepositoryInfo(string repositoryId)
		{
            SetServiceRoot();
            var result = await _repositoryService.GetRepositoryInfoAsync(repositoryId);
			return new JsonResult(result, _serializerSettings);
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
