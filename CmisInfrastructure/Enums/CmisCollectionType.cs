//
// CmisCollectionType.cs
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
    /// CMIS collection type. Used in Atom service document with the cmisra namespace to identify th type of a collection.
    /// </summary>
    public enum CmisCollectionType
    {
		/// <summary>
		/// Root Folder Children Collection: Root folder of the repository.
		/// </summary>
        [CmisName(Constants.CmisCollectionTypeRoot)]
		Root,
		/// <summary>
		/// Types Children Collection: Collection containing the base types in the repository.
		/// </summary>
        [CmisName(Constants.CmisCollectionTypeTypes)]
		Types,
		/// <summary>
		/// CheckedOut collection: collection containing all checked out documents user can see.
		/// </summary>
        [CmisName(Constants.CmisCollectionTypeCheckedOut)]
		CheckedOut,
		/// <summary>
		/// Query collection: Collection for posting queries to be executed.
		/// </summary>
        [CmisName(Constants.CmisCollectionTypeQuery)]
		Query,
		/// <summary>
		/// Unﬁled collection: Collection for posting documents to be unﬁled; read can be disabled.
		/// </summary>
        [CmisName(Constants.CmisCollectionTypeUnfiled)]
		Unfiled,
		/// <summary>
		/// Bulk update collection: Collection for posting property updates for multiple objects at once.
		/// </summary>
        [CmisName(Constants.CmisCollectionTypeUpdate)]
		Update
    }
}
