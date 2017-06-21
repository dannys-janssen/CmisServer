//
// CmisRepositoryInfo.cs
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

namespace Cmis.Model
{
    using System.Collections.Generic;
    using Cmis.Infrastructure;

	/// <summary>
	/// CMIS repository info. Holds informations about a specific CMIS repository.
	/// </summary>
	public class CmisRepositoryInfo : ICmisRepositoryInfo
    {
		/// <summary>
		/// Gets or sets the CMIS repository description.
		/// </summary>
		/// <value>The description.</value>
		public string RepositoryDescription { get; set; }

		/// <summary>
		/// Gets or sets the display name of the vendor for the repository's underlying application.
		/// </summary>
		/// <value>The name of the vendor.</value>
		public string VendorName { get; set; }

		/// <summary>
		/// Gets or sets the display name of the product for the repository's underlying application.
		/// </summary>
		/// <value>The ame of the product.</value>
		public string ProductName { get; set; }

		/// <summary>
		/// Gets or sets the product version for the repository's underlying application.
		/// </summary>
		/// <value>The product version.</value>
		public string ProductVersion { get; set; }

		/// <summary>
		/// Gets or sets the root folder identifier for the CMIS repository.
		/// </summary>
		/// <value>The root folder identifier.</value>
		public string RootFolderId { get; set; }

		/// <summary>
		/// Gets or sets the optional repository capabilities.
		/// </summary>
		/// <value>The optional repository capabilities.</value>
		public ICmisRepositoryCapabilities Capabilities { get; set; }

		/// <summary>
		/// Gets or sets the optional acl capabilities.
		/// </summary>
		/// <value>The acl capabilities.</value>
		public ICmisAclCapability AclCapability { get; set; }

		/// <summary>
		/// Gets or sets the change log token corresponding to the most recent change event for any object in the repository.
		/// </summary>
		/// <value>The latest change log token.</value>
		public string LatestChangeLogToken { get; set; }

		/// <summary>
		/// Gets or sets a Decimal as String that indicates what version of the CMIS speciﬁcation this repository supports. Allowed versions are: "1.1".
		/// </summary>
		/// <value>The supported CMIS version.</value>
		public string CmisVersionSupported { get; set; }

		/// <summary>
		/// Gets or sets an optional repository-speciﬁc URI pointing to the repository’s web interface. MAY be not set.
		/// </summary>
		/// <value>The thin client URI.</value>
		public string ThinClientURI { get; set; }

		/// <summary>
		/// Gets a value indicating whether or not the repository’s change log can return all changes ever made to any object in the repository or only changes made after a particular point in time. Applicable when the repository’s optional capability capabilityChanges is not none..
		/// </summary>
		/// <value>When <c>true</c> then the change log includes all changes made since a particular point in time, but not all changes ever made. When <c>false</c> then the change log can return all changes ever made to every object.</value>
        public bool ChangesIncomplete { get; set; }

		/// <summary>
		/// Gets a list of base type identifiers indicating whether changes are available for base types in the repository. Valid values are from enumBaseObjectTypeIds..
		/// </summary>
		/// <value>The list of base type identifiers.</value>
		/// <remarks>The base type cmis:secondary MUST NOT be used here. Only primary base types can be in this list.</remarks>
		public IList<CmisBaseTypeId?> ChangesOnType { get; set; }

		/// <summary>
		/// If set, this ﬁeld holds the principal who is used for anonymous access. This principal can then be passed to the ACL services to specify what permissions anonymous users should have.
		/// </summary>
		/// <value>The anonymous access principal.</value>
		public string PrincipalIdAnonymous { get; set; }

		/// <summary>
		/// If set, this ﬁeld holds the principal who is used to indicate any authenticated user. This principal can then be passed to the ACL services to specify what permissions any authenticated user should have.
		/// </summary>
		/// <value>The principal representing any authenticated user.</value>
		public string PrincipalIdAnyone { get; set; }

		/// <summary>
		/// Gets the optional list of additional repository features.
		/// </summary>
		/// <value>The additional features of the repository.</value>
		public IList<ICmisRepositoryFeature> ExtendedFeatures { get; set; }

        /// <summary>
        /// Gets or sets the repository identifier.
        /// </summary>
        /// <value>The repository identifier.</value>
        public string RepositoryId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the repository.
        /// </summary>
        /// <value>The display name of the repository.</value>
        public string RepositoryName { get; set; }

        /// <summary>
        /// Gets or sets the repository URL.
        /// </summary>
        /// <value>The repository URL.</value>
        public string RepositoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the root folder URL.
        /// </summary>
        /// <value>The root folder URL.</value>
        public string RootFolderUrl { get; set; }

		/// <summary>
		/// Gets or sets the list of CMIS extensions.
		/// </summary>
		/// <value>The list of CMIS extensions.</value>
		public IList<ICmisExtensionElement> Extensions { get; set; }
    }
}
