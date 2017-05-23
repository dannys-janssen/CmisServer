//
// CmisCapabilityQuery.cs
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

namespace Cmis.Infrastructure
{
	/// <summary>
	/// CMIS query capability. Indicates the types of queries that the Repository has the ability to fulﬁll.
	/// </summary>
	public enum CmisCapabilityQuery
    {
		/// <summary>
		/// No queries of any kind can be fulﬁlled.
		/// </summary>
        [CmisName(Constants.CmisCapabilityQueryNone)]
		None,

		/// <summary>
		/// Only queries that ﬁlter based on object properties can be fulﬁlled. Speciﬁcally, the CONTAINS() predicate function is not supported.
		/// </summary>
        [CmisName(Constants.CmisCapabilityQueryMetadataOnly)]
		MetadataOnly,

		/// <summary>
		/// Only queries that ﬁlter based on the full-text content of documents can be fulﬁlled. Speciﬁcally, only the CONTAINS() predicate function can be included in the WHERE clause.
		/// </summary>
        [CmisName(Constants.CmisCapabilityQueryFulltextOnly)]
		FulltextOnly,

		/// <summary>
		/// The repository can fulﬁll queries that ﬁlter EITHER on the full-text content of documents OR on their properties, but NOT if both types of ﬁlters are included in the same query.
		/// </summary>
        [CmisName(Constants.CmisCapabilityQueryBothSeparate)]
		BothSeparate,

		/// <summary>
		/// The repository can fulﬁll queries that ﬁlter on both the full-text content of documents and their properties in the same query.
		/// </summary>
        [CmisName(Constants.CmisCapabilityQueryBothCombined)]
		BothCombined
    }
}
