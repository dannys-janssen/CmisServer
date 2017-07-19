//
// CmisAtomServiceControllerUnitTests.cs
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
using System.Threading.Tasks;
using Cmis.Interface;
using Cmis.Model;
using Xunit;

namespace Cmis.Tests
{
    /// <summary>
    /// CMIS Atom Pub service controller unit tests.
    /// </summary>
    public class CmisAtomServiceControllerUnitTests
    {
        [Fact]
        public async Task Converter_Returns_Correct_XDocument()
        {
			var mockupConnector = new CmisMockupConnector();
			var converter = new AtomServiceXDocumentConverter();
            var serviceDocument = await mockupConnector.GetServiceDocument();
            Assert.NotNull(serviceDocument);
            Assert.IsType<AtomService>(serviceDocument);
            var result = converter.Convert(serviceDocument);
        }
    }
}
