//
// ICmisRepositoryInfo.cs
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
    using System.Collections.Generic;

    /// <summary>
    /// CMIS repository info. Holds informations about a specific CMIS repository.
    /// </summary>
    public interface ICmisRepositoryInfo : ICmisRepositoryShortInfo, ICmisExtensionData
    {
        /// <summary>
        /// Gets the CMIS repository description.
        /// </summary>
        /// <value>The description.</value>
        string RepositoryDescription { get; }

        /// <summary>
        /// Gets the display name of the vendor for the repository's underlying application.
        /// </summary>
        /// <value>The name of the vendor.</value>
        string VendorName { get; }

		/// <summary>
		/// Gets the display name of the product for the repository's underlying application.
		/// </summary>
		/// <value>The ame of the product.</value>
		string ProductName { get; }

		/// <summary>
		/// Gets the product version for the repository's underlying application.
		/// </summary>
		/// <value>The product version.</value>
		string ProductVersion { get; }

        /// <summary>
        /// Gets the root folder identifier for the CMIS repository.
        /// </summary>
        /// <value>The root folder identifier.</value>
        string RootFolderId { get; }

        /// <summary>
        /// Gets the optional repository capabilities.
        /// </summary>
        /// <value>The optional repository capabilities.</value>
        ICmisRepositoryCapabilities Capabilities { get; }

		/// <summary>
		/// Gets the change log token corresponding to the most recent change event for any object in the repository.
		/// </summary>
		/// <value>The latest change log token.</value>
		string LatestChangeLogToken { get; }

		/// <summary>
		/// Gets a Decimal as String that indicates what version of the CMIS speciﬁcation this repository supports. Allowed versions are: "1.1".
		/// </summary>
		/// <value>The supported CMIS version.</value>
		string CmisVersionSupported { get; }

		/// <summary>
		/// Gets an optional repository-speciﬁc URI pointing to the repository’s web interface. MAY be not set.
		/// </summary>
		/// <value>The thin client URI.</value>
		string ThinClientURI { get; }

		/// <summary>
		/// Gets a value indicating whether or not the repository’s change log can return all changes ever made to any object in the repository or only changes made after a particular point in time. Applicable when the repository’s optional capability capabilityChanges is not none..
		/// </summary>
		/// <value>When <c>true</c> then the change log includes all changes made since a particular point in time, but not all changes ever made. When <c>false</c> then the change log can return all changes ever made to every object.</value>
		bool ChangesIncomplete { get; }

		/// <summary>
		/// Gets a list of base type identifiers indicating whether changes are available for base types in the repository. Valid values are from enumBaseObjectTypeIds..
		/// </summary>
		/// <value>The list of base type identifiers.</value>
		/// <remarks>The base type cmis:secondary MUST NOT be used here. Only primary base types can be in this list.</remarks>
		IList<CmisBaseTypeId?> ChangesOnType { get; }

        /// <summary>
        /// Gets the supported types of permissions.
        /// </summary>
        /// <value>The supported permissions.</value>
        CmisSupportedPermissions SupportedPermissions { get; }

		/// <summary>
		/// Gets the allowed value(s) for applyACL, which control how non-direct ACEs are handled by the repository.
		/// </summary>
		/// <value>The ACL propagation value.</value>
		CmisAclProgagation Propagation { get; }

		/// <summary>
		/// Gets the list of repository-speciﬁc permissions the repository supports for managing ACEs.
		/// </summary>
		/// <value>The permissions.</value>
		IList<CmisBasicPermission?> Permissions { get; }

		/// <summary>
		/// Gets the list of mappings for the CMIS basic permissions to allowable actions.
		/// </summary>
		/// <value>The list of permission mappings.</value>
		IList<ICmisPermissionMapping> Mappings { get; }

		/// <summary>
		/// If set, this ﬁeld holds the principal who is used for anonymous access. This principal can then be passed to the ACL services to specify what permissions anonymous users should have.
		/// </summary>
		/// <value>The anonymous access principal.</value>
		string PrincipalAnonymous { get; }

		/// <summary>
		/// If set, this ﬁeld holds the principal who is used to indicate any authenticated user. This principal can then be passed to the ACL services to specify what permissions any authenticated user should have.
		/// </summary>
		/// <value>The principal representing any authenticated user.</value>
		string PrincipalAnyone { get; }

		/// <summary>
		/// Gets the optional list of additional repository features.
		/// </summary>
		/// <value>The additional features of the repository.</value>
		IList<ICmisRepositoryFeature> ExtendedFeatures { get; }
    }
}
