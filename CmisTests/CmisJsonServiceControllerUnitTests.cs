using Xunit;
using System.Threading.Tasks;
using Cmis.Infrastructure;
using Cmis.Service;
using Microsoft.AspNetCore.Mvc;
using Cmis.Interface;
using System.Collections.Generic;

namespace CmisTests
{
    /// <summary>
    /// CMIS JSON service controller unit tests.
    /// </summary>
    public class CmisJsonServiceControllerUnitTests
    {
        [Fact]
        public async Task GetServiceDocument_ReturnsJsonResultAndICmisRepositoryShortInfo()
        {
            var mockupConnector = new CmisMockupConnector();
            var controller = new CmisJsonServiceController(mockupConnector);
            var result = await controller.GetRepositories();

            Assert.IsType<JsonResult>(result);

            JsonResult test = (JsonResult)result; 
            Assert.NotNull(test);
            Assert.NotNull(test.Value);
            Assert.IsType<List<ICmisRepositoryShortInfo>>(test.Value);
            var values = (List<ICmisRepositoryShortInfo>)test.Value;
            Assert.True(values.Count == 2);
            Assert.True(values[1].RepositoryId == "MM");
        }
    }
}
