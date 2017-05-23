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
	public interface ICmisRepositoryCapabilities : ICmisExtensionData
    {
		/// <summary>
		/// Gets a value indicating whether the repository has the ability to enumerate the descendants of a folder via the getDescendants service.
		/// </summary>
		/// <value><c>true</c> if get descendants is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityGetDescendants { get; }

		/// <summary>
		/// Gets a value indicating whether this repository has the ability to retrieve the folder tree via the getFolderTree service..
		/// </summary>
		/// <value><c>true</c> if capability get folder tree is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityGetFolderTree { get; }

		/// <summary>
		/// Gets a value indicating the ordering capabilities of the repository.
		/// </summary>
		/// <value>The order by capability.</value>
		CmisCapabilityOrderBy? CapabilityOrderBy { get; }

		/// <summary>
		/// Gets a value indicating the support a repository has for updating a documents content stream.
		/// </summary>
		/// <value>The content stream update capoability.</value>
		CmisCapabilityContentStreamUpdatability? CapabilityContentStreamUpdatability { get; }

		/// <summary>
		/// Gets a value indicating what level of changes (if any) the repository exposes via the getContentChanges service.
		/// </summary>
		/// <value>The changes capability.</value>
		CmisCapabilityChanges? CapabilityChanges { get; }

		/// <summary>
		/// Gets a value indicating whether or not the repository exposes renditions of document or folder objects.
		/// </summary>
		/// <value>The renditions capability.</value>
		CmisCapabilityRenditions? CapabilityRenditions { get; }

		/// <summary>
		/// Gets a value indicating the ability for an application to ﬁle a document or other ﬁle-able object in more than one folder.
		/// </summary>
		/// <value><c>true</c> if multifiling is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityMultiﬁling { get; }

		/// <summary>
		/// Gets a value indicating the ability for an application to leave a document or other ﬁle-able object not ﬁled in any folder.
		/// </summary>
		/// <value><c>true</c> if unfiling is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityUnﬁling { get; }

		/// <summary>
		/// Gets the capability version speciﬁc filing.
		/// </summary>
		/// <value><c>true</c> if version specific filing is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityVersionSpeciﬁcFiling { get; }

		/// <summary>
		/// Gets a value indicating the ability for an application to update the "Private Working Copy" of a checked-out document.
		/// </summary>
		/// <value><c>true</c> if private working copy update is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityPWCUpdatable { get; }

		/// <summary>
		/// Gets a value indicating the ability of the Repository to include the "Private Working Copy" of checked-out documents in query search scope; otherwise PWC’s are not searchable.
		/// </summary>
		/// <value><c>true</c> if private working copy search is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityPWCSearchable { get; }

		/// <summary>
		/// Gets a value indicating the ability of the Repository to include all versions of a document. If False, typically either the latest or the latest major version will be searchable.
		/// </summary>
		/// <value><c>true</c> if all document versions search is supported; otherwise, <c>false</c>.</value>
		bool? CapabilityAllVersionsSearchable { get; }

		/// <summary>
		/// Gets a value indicating the types of queries that the Repository has the ability to fulﬁll.
		/// </summary>
		/// <value>The query capability.</value>
		CmisCapabilityQuery? CapabilityQuery { get; }

		/// <summary>
		/// Gets a value indicating the types of JOIN keywords that the Repository can fulﬁll in queries.
		/// </summary>
		/// <value>The join capability.</value>
		CmisCapabilityJoin? CapabilityJoin { get; }

		/// <summary>
		/// Gets the list of all property data types that can be used by a client to create or update an object-type deﬁnition.
		/// </summary>
		/// <value>The capability creatable property types.</value>
		ICmisCreateablePropertyTypes CapabilityCreatablePropertyTypes { get; }

		/// <summary>
		/// Gets which object-type attributes can be set by a client when a new object-type is created.
		/// </summary>
		/// <value>The new type settable attributes capability.</value>
		ICmisNewTypeSettableAttributes CapabilityNewTypeSettableAttributes { get; }

		/// <summary>
		/// Gets a value indicating the level of support for ACLs by the repository.
		/// </summary>
		/// <value>The capability acl.</value>
		CmisCapabilityACL? CapabilityACL { get; }
	}
}
