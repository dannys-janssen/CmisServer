//
// CmisCapabilityJoin.cs
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
	/// CMIS join capability. Indicates the types of JOIN keywords that the Repository can fulﬁll in queries.
	/// </summary>
	public enum CmisCapabilityJoin
    {
		/// <summary>
		/// The repository cannot fulﬁll any queries that include any JOIN clauses on two primary types. If the Repository supports secondary types, JOINs on secondary types SHOULD be supported, even if the support level is none.
		/// </summary>
        [CmisName(Constants.CmisCapabilityJoinNone)]
		None,

		/// <summary>
		/// The repository can fulﬁll queries that include an INNER JOIN clause, but cannot fulﬁll queries that include other types of JOIN clauses.
		/// </summary>
        [CmisName(Constants.CmisCapabilityJoinInnerOnly)]
		InnerOnly,

		/// <summary>
		/// The repository can fulﬁll queries that include any type of JOIN clause deﬁned by the CMIS query grammar.
		/// </summary>
        [CmisName(Constants.CmisCapabilityJoinInnerAndOuter)]
		InnerAndOuter
    }
}
