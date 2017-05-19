//
// ICmisRepsositoryCapability.cs
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
	/// CMIS repository capability.
	/// Commercial ECM repositories vary in their designs. Moreover, some 
    /// repositories are designed for a speciﬁc application domain and may not 
    /// provide certain capabilities that are not needed for their targeted 
    /// domain. Thus, a repository implementation may not necessarily be able to 
    /// support all CMIS capabilities. A few CMIS capabilities are therefore 
    /// "optional" for a repository to be compliant. A repository’s support for 
    /// each of these optional capabilities is discoverable using the 
    /// getRepositoryInfo service. 
	/// </summary>
	public interface ICmisRepositoryCapability : ICmisExtensionData
    {
		/// <summary>
		/// Gets a value indicating whether the repository has the ability to enumerate the descendants of a folder via the getDescendants service.
		/// </summary>
		/// <value><c>true</c> if get descendants is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityGetDescendants { get; }

		/// <summary>
		/// Gets a value indicating whether this repository has the ability to retrieve the folder tree via the getFolderTree service..
		/// </summary>
		/// <value><c>true</c> if capability get folder tree; otherwise, <c>false</c>.</value>
		bool? CapabilityGetFolderTree { get; }

		/// <summary>
		/// Gets a value indicating the ordering capabilities of the repository.
		/// </summary>
		/// <value>The capability order by.</value>
		CmisCapabilityOrderBy? CapabilityOrderBy { get; }

        //TODO: Add missing capabilities.
	}
}
