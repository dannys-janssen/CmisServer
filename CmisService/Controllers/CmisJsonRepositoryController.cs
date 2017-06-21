//
// CmisJsonRepositoryController.cs
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

    [Route("api/{repositoryId}/cmis/1.1/browser")]
    public class CmisJsonRepositoryController : Controller
    {
        /// <summary>
        /// The configuration store.
        /// </summary>
        readonly ICmisConnector _configurationstore;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Service.CmisJsonRepositoryController"/> class.
        /// </summary>
        /// <param name="configurationStore">Configuration store.</param>
        public CmisJsonRepositoryController(ICmisConnector configurationStore)
        {
            _configurationstore = configurationStore;
        }

		/// <summary>
		/// Gets the repository info for a specific CMIS repository.
		/// </summary>
		/// <returns>The repository info.</returns>
		/// <param name="repositoryId">Repository identifier.</param>
		public async Task<IActionResult> GetRepositoryInfo(string repositoryId)
        {
            var serviceRoot = $"{Request.Scheme}://{Request.Host}";
            _configurationstore.ServiceRoot = serviceRoot;

            var result = await _configurationstore.GetRepositoryInfoAsync(repositoryId);
            var serializerSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Converters = new List<Newtonsoft.Json.JsonConverter>()
            };
            serializerSettings.Converters.Add(new CmisRepositoryInfoJsonConverter());
            serializerSettings.Converters.Add(new CmisRepositoryShortInfoJsonConverter());
            serializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            return new JsonResult(result, serializerSettings);
        }
    }
}
