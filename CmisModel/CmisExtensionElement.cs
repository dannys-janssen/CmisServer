//
// CmisExtensionElement.cs
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

namespace Cmis.Model
{
    using System.Collections.Generic;
    using Cmis.Infrastructure;

	/// <summary>
	/// CMIS extension element. See http://docs.oasis-open.org/cmis/CMIS/v1.1/os/CMIS-v1.1-os.html
	/// </summary>
	public class CmisExtensionElement : ICmisExtensionElement
    {
		/// <summary>
		/// Gets or sets the CMIS extension name.
		/// </summary>
		/// <value>The CMIS extension name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the CMIS extension namespace.
		/// </summary>
		/// <value>The CMIS extension namespace.</value>
		public string Namespace { get; set; }

		/// <summary>
		/// Gets or sets the CMIS extension value.
		/// </summary>
		/// <value>The CMIS extension value.</value>
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the CMIS extension attributes.
		/// </summary>
		/// <value>The CMIS extension attributes.</value>
		public IDictionary<string, string> Attributes { get; set; }

		/// <summary>
		/// Gets or sets optional child CMIS extension elements.
		/// </summary>
		/// <value>The CMIS extension children.</value>
		public IList<ICmisExtensionElement> Children { get; set; }
    }
}
