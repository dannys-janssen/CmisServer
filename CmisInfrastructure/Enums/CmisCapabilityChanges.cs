//
// CmisCapabilityChanges.cs
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
	/// CMIS changes capability. ndicates what level of changes (if any) the repository exposes via the getContentChanges service.
	/// </summary>
	public enum CmisCapabilityChanges
    {
		/// <summary>
		/// The repository does not support the change log feature.
		/// </summary>
        [CmisName(Constants.CmisCapabilityChangesNone)]
		None,

		/// <summary>
		/// The change log can return only the object ids for changed objects in the repository and an indication of the type of change, not details of the actual change.
		/// </summary>
        [CmisName(Constants.CmisCapabilityChangesObjectIdsOnly)]
		ObjectIdsOnly,

		/// <summary>
		/// The change log can return properties and the object id for the changed objects.
		/// </summary>
        [CmisName(Constants.CmisCapabilityChangesProperties)]
		Properties,

		/// <summary>
		/// The change log can return the object ids for changed objects in the repository and more information about the actual change.
		/// </summary>
        [CmisName(Constants.CmisCapabilityChangesAll)]
		All
    }
}
