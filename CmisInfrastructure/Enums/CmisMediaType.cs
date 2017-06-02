//
// CmisMediaType.cs
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
    /// CMIS allowed media types.
    /// </summary>
    public enum CmisMediaType
    {
        /// <summary>
        /// Unknown media type. Equals to application/octet-stream.
        /// </summary>
        [CmisName(Constants.CmisMediaTypeUnknown)]
        Unknown,
		/// <summary>
		/// Atom service media type. application/atomsvc+xml
		/// </summary>
        [CmisName(Constants.CmisMediaTypeService)]
		Service,
		/// <summary>
		/// Atom Feed media type. application/atom+xml;type=feed
		/// </summary>
        [CmisName(Constants.CmisMediaTypeFeed)]
		Feed,
		/// <summary>
		/// Atom entry media type. application/atom+xml;type=entry
		/// </summary>
        [CmisName(Constants.CmisMediaTypeEntry)]
		Entry,
		/// <summary>
		/// Atom Children media type. application/atom+xml;type=feed
		/// </summary>
        [CmisName(Constants.CmisMediaTypeChildren)]
		Children,
		/// <summary>
		/// CMIS Tree media type. application/cmistree+xml
		/// </summary>
        [CmisName(Constants.CmisMediaTypeDescendants)]
		Descendants,
		/// <summary>
		/// Atom Query media type. application/cmisquery+xml
		/// </summary>
        [CmisName(Constants.CmisMediaTypeQuery)]
		Query,
		/// <summary>
		/// CMIS allowable action media type. application/cmisallowableactions+xml
		/// </summary>
        [CmisName(Constants.CmisMediaTypeAllowableAction)]
		AllowableAction,
		/// <summary>
		/// CMIS ACL media type. application/cmisacl+xml
		/// </summary>
        [CmisName(Constants.CmisMediaTypeAcl)]
		Acl
    }
}
