//
// CmisExtendedFeature.cs
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
	/// CMIS repository feature. Repositories MAY provide information about additional features that are supported by the repository but that are outside the CMIS speciﬁcation. This information is returned by the getRepositoryInfo service.
	/// </summary>
	public class CmisRepositoryFeature : ICmisRepositoryFeature
    {
		/// <summary>
		/// Gets or sets the unique identifier of the feature. It SHOULD take the form of a URI (see [RFC3986]).
		/// </summary>
		/// <value>The feature identifier.</value>
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the URL of the feature.
		/// </summary>
		/// <value>The CMIS feature URL.</value>
		public string Url { get; set; }

		/// <summary>
		/// Gets or sets the feature version label.
		/// </summary>
		/// <value>The version label.</value>
		public string VersionLabel { get; set; }

		/// <summary>
		/// Gets or sets the human readable feature name.
		/// </summary>
		/// <value>The feature name.</value>
		public string CommonName { get; set; }

		/// <summary>
		/// Gets or sets the feature description.
		/// </summary>
		/// <value>The description.</value>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the feature data as a dictionary of key-value pairs. The semantics and rules for these key-value pairs are not deﬁned by CMIS but MAY be constrained by other speciﬁcations.
		/// </summary>
		/// <value>The data.</value>
		public IDictionary<string, string> Data { get; set; }

		/// <summary>
		/// Gets or sets the list of CMIS extensions.
		/// </summary>
		/// <value>The list of CMIS extensions.</value>
		public IList<ICmisExtensionElement> Extensions { get; set; }
    }
}
