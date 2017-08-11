//
// CmisContentStreamAllowed.cs
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
	/// Indicates whether a content stream MAY, MUST, or MUST NOT be included in objects of this type.
	/// </summary>
	public enum CmisContentStreamAllowed
    {
		/// <summary>
		/// A content stream MUST NOT be included.
		/// </summary>
        [CmisName(Constants.CmisContentStreamNotAllowed)]
		NotAllowed,
		/// <summary>
		/// A content stream MAY be included.
		/// </summary>
        [CmisName(Constants.CmisContentStreamAllowed)]
		Allowed,
		/// <summary>
		/// A content stream MUST be included (i.e. MUST be included when the object is created, and MUST NOT be deleted).
		/// </summary>
        [CmisName(Constants.CmisContentStreamRequired)]
		Required
    }
}
