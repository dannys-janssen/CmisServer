//
// CmisCardinality.cs
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
	/// CMIS property cardinality. Indicates whether a property can have "zero or one" or "zero or more" values.
	/// </summary>
	public enum CmisCardinality
    {
		/// <summary>
		/// Property can have zero or one values (if property is not required), or exactly one value (if property is required).
		/// </summary>
        [CmisName(Constants.CmisCardinalitySingle)]
		Single,

		/// <summary>
		/// Property can have zero or more values (if property is not required), or one or more values (if property is required).
		/// </summary>
		/// <remarks>Repositories SHOULD preserve the ordering of values in a multi-valued property. That is, the order in which the values of a multi-valued property are returned in "get" services operations SHOULD be the same as the order in which they were supplied during previous create/update operation.</remarks>
        [CmisName(Constants.CmisCardinalityMulti)]
        Multi
    }
}
