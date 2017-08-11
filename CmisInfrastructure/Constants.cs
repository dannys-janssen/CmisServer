//
// Constants.cs
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
    /// Global constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// CMIS version. Currently only 1.1 is supported.
        /// </summary>
        public const string CmisVersion = "1.1";

        /// <summary>         /// CMIS prefix for naming objects, types etc.         /// </summary>         public const string CmisPrefix = "cmis";

        /// <summary>
        /// CMIS ACL propagation object only.
        /// </summary>
        public const string CmisAclPropagationObjectOnly = "objectonly";

        /// <summary>
        /// CMIS ACL propagation propagate.
        /// </summary>
        public const string CmisAclPropagationPropagate = "propagate";

        /// <summary>
        /// CMIS ACL repository determined.
        /// </summary>
        public const string CmisAclRepositoryDetermined = "repositorydetermined";

        /// <summary>
        /// CMIS base type identifier.
        /// </summary>         public const string CmisBaseTypeId = CmisPrefix + ":baseTypeId";

		/// <summary>
		/// CMIS 'all' basic permission.
		/// </summary>
		public const string CmisBasicPermissionAll = CmisPrefix + ":all";

        /// <summary>
        /// CMIS 'read' basic permission.
        /// </summary>
        public const string CmisBasicPermissionRead = CmisPrefix + ":read";

		/// <summary>
		/// CMIS 'write' basic permission.
		/// </summary>
		public const string CmisBasicPermissionWrite = CmisPrefix + ":write";

		/// <summary>
		/// Repository capabilities: Ordering is not supported.
		/// </summary>
		public const string CmisCapabilityOrderByNone = "none";

		/// <summary>
		/// Repository capabilities: Only common CMIS properties are supported.
		/// </summary>
		public const string CmisCapabilityOrderByCommon = "common";

		/// <summary>
		/// Repository capabilities: Common CMIS properties and custom object-type properties are supported.
		/// </summary>
		public const string CmisCapabilityOrderByCustom = "custom";

		/// <summary>
		/// CMIS content stream update capability: The content stream may never be updated.
		/// </summary>
		public const string CmisCapabilityContentStreamUpdatabilityNone = "none";

		/// <summary>
		/// CMIS content stream update capability: The content stream may be updated any time.
		/// </summary>
		public const string CmisCapabilityContentStreamUpdatabilityAnyTime = "anytime";

		/// <summary>
		/// CMIS content stream update capability: The content stream may be updated only when checked out. Private Working Copy (PWC) is described in section 2.1.13 Versioning.
		/// </summary>
		public const string CmisCapabilityContentStreamUpdatabilityPwcOnly = "pwconly";

		/// <summary>
		/// CMIS Change capability: The repository does not support the change log feature.
		/// </summary>
		public const string CmisCapabilityChangesNone = "none";

		/// <summary>
		/// CMIS Change capability: The change log can return only the object ids for changed objects in the repository and an indication of the type of change, not details of the actual change.
		/// </summary>
		public const string CmisCapabilityChangesObjectIdsOnly = "objectidsonly";

		/// <summary>
		/// CMIS Change capability: The change log can return properties and the object id for the changed objects.
		/// </summary>
		public const string CmisCapabilityChangesProperties = "properties";

		/// <summary>
		/// CMIS Change capability: The change log can return the object ids for changed objects in the repository and more information about the actual change.
		/// </summary>
		public const string CmisCapabilityChangesAll = "all";

		/// <summary>
		/// CMIS renditions capability: The repository does not expose renditions at all.
		/// </summary>
		public const string CmisCapabilityRenditionsNone = "none";

		/// <summary>
		/// CMIS renditions capability: Renditions are provided by the repository and readable by the client.
		/// </summary>
		public const string CmisCapabilityRenditionsRead = "read";

		/// <summary>
		/// No queries of any kind can be fulﬁlled.
		/// </summary>
		public const string CmisCapabilityQueryNone = "none";

		/// <summary>
		/// Only queries that ﬁlter based on object properties can be fulﬁlled. Speciﬁcally, the CONTAINS() predicate function is not supported.
		/// </summary>
		public const string CmisCapabilityQueryMetadataOnly = "metadataonly";

		/// <summary>
		/// Only queries that ﬁlter based on the full-text content of documents can be fulﬁlled. Speciﬁcally, only the CONTAINS() predicate function can be included in the WHERE clause.
		/// </summary>
		public const string CmisCapabilityQueryFulltextOnly = "fulltextonly";

		/// <summary>
		/// The repository can fulﬁll queries that ﬁlter EITHER on the full-text content of documents OR on their properties, but NOT if both types of ﬁlters are included in the same query.
		/// </summary>
		public const string CmisCapabilityQueryBothSeparate = "bothseparate";

		/// <summary>
		/// The repository can fulﬁll queries that ﬁlter on both the full-text content of documents and their properties in the same query.
		/// </summary>
		public const string CmisCapabilityQueryBothCombined = "bothcombined";

		/// <summary>
		/// The repository cannot fulﬁll any queries that include any JOIN clauses on two primary types. If the Repository supports secondary types, JOINs on secondary types SHOULD be supported, even if the support level is none.
		/// </summary>
		public const string CmisCapabilityJoinNone = "none";

		/// <summary>
		/// The repository can fulﬁll queries that include an INNER JOIN clause, but cannot fulﬁll queries that include other types of JOIN clauses.
		/// </summary>
		public const string CmisCapabilityJoinInnerOnly = "inneronly";

		/// <summary>
		/// The repository can fulﬁll queries that include any type of JOIN clause deﬁned by the CMIS query grammar.
		/// </summary>
		public const string CmisCapabilityJoinInnerAndOuter = "innerandouter";

		/// <summary>
		/// The repository does not support ACL services.
		/// </summary>
		public const string CmisCapabilityACLNone = "none";

		/// <summary>
		/// The repository supports discovery of ACLs (getACL and other services).
		/// </summary>
		public const string CmisCapabilityACLDiscover = "discover";

		/// <summary>
		/// The repository supports discovery of ACLs AND applying ACLs (getACL and applyACL services).
		/// </summary>
		public const string CmisCapabilityACLManage = "manage";

		/// <summary>
		/// Root Folder Children Collection: Root folder of the repository.
		/// </summary>
		public const string CmisCollectionTypeRoot = "root";

		/// <summary>
		/// Types Children Collection: Collection containing the base types in the repository.
		/// </summary>
		public const string CmisCollectionTypeTypes = "types";

		/// <summary>
		/// heckedOut collection: collection containing all checked out documents user can see.
		/// </summary>
		public const string CmisCollectionTypeCheckedOut = "checkedout";

		/// <summary>
		/// Query collection: Collection for posting queries to be executed.
		/// </summary>
		public const string CmisCollectionTypeQuery = "query";

		/// <summary>
		/// Unﬁled collection: Collection for posting documents to be unﬁled; read can be disabled.
		/// </summary>
		public const string CmisCollectionTypeUnfiled = "unfiled";

		/// <summary>
		/// Bulk update collection: Collection for posting property updates for multiple objects at once.
		/// </summary>
		public const string CmisCollectionTypeUpdate = "update";

		/// <summary>
		/// Unknown media type. Equals to application/octet-stream.
		/// </summary>
		public const string CmisMediaTypeUnknown = "appliaction/octet-stream";

		/// <summary>
		/// Atom service media type. application/atomsvc+xml
		/// </summary>
		public const string CmisMediaTypeService = "application/atomsvc+xml";

		/// <summary>
		/// Atom Feed media type. application/atom+xml;type=feed
		/// </summary>
		public const string CmisMediaTypeFeed = "application/atom+xml;type=feed";

		/// <summary>
		/// Atom entry media type. application/atom+xml;type=entry
		/// </summary>
		public const string CmisMediaTypeEntry = "application/atom+xml;type=entry";

		/// <summary>
		/// Atom Children media type. application/atom+xml;type=feed
		/// </summary>
		public const string CmisMediaTypeChildren = "application/atom+xml;type=feed";

		/// <summary>
		/// CMIS Tree media type. application/cmistree+xml
		/// </summary>
		public const string CmisMediaTypeDescendants = "application/cmistree+xml";

		/// <summary>
		/// Atom Query media type. application/cmisquery+xml
		/// </summary>
		public const string CmisMediaTypeQuery = "application/cmisquery+xml";

		/// <summary>
		/// CMIS allowable action media type. application/cmisallowableactions+xml
		/// </summary>
		public const string CmisMediaTypeAllowableAction = "application/cmisallowableactions+xml";

		/// <summary>
		/// CMIS ACL media type. application/cmisacl+xml
		/// </summary>
		public const string CmisMediaTypeAcl = "application/cmisacl+xml";

        /// <summary>
        /// CMIS media type atom.
        /// </summary>
        public const string CmisMediaTypeAtom = "application/cmisatom+xml";

        /// <summary>
        /// The CMIS URI template type for object by identifier query.
        /// </summary>
        public const string CmisUriTemplateTypeObjectById = "objectbyid";

        /// <summary>
        /// The CMIS URI template type for object by path query.
        /// </summary>
        public const string CmisUriTemplateTypeObjectByPath = "objectbypath";

        /// <summary>
        /// The CMIS URI template type for queries.
        /// </summary>
        public const string CmisUriTemplateTypeQuery = "query";

        /// <summary>
        /// The CMIS URI template type for type by identifier query.
        /// </summary>
        public const string CmisUriTemplateTypeTypeById = "typebyid";

        /// <summary>
        /// CMIS created by.
        /// </summary>         public const string CmisCreatedBy = CmisPrefix + ":createdBy"; 
        /// <summary>
        /// CMIS creation date.
        /// </summary>         public const string CmisCreationDate = CmisPrefix + ":creationDate";

        /// <summary>
        /// CMIS change token.
        /// </summary>         public const string CmisChangeToken = CmisPrefix + ":changeToken";

        /// <summary>
        /// CMIS description.
        /// </summary>
        public const string CmisDescription = CmisPrefix + ":description";

        /// <summary>
        /// CMIS document.
        /// </summary>
        public const string CmisDocument = CmisPrefix + ":document";

        /// <summary>
        /// CMIS folder.
        /// </summary>
        public const string CmisFolder = CmisPrefix + ":folder";          /// <summary>         /// CMIS item.         /// </summary>         public const string CmisItem = CmisPrefix + ":item";          /// <summary>         /// CMIS last modified by.         /// </summary>         public const string CmisLastModifiedBy = CmisPrefix + ":lastModifiedBy";

        /// <summary>
        /// CMIS last modification date.
        /// </summary>         public const string CmisLastModificationDate = CmisPrefix + ":lastModificationDate";

        /// <summary>
        /// CMIS name.
        /// </summary>
        public const string CmisName = CmisPrefix + ":name";

        /// <summary>
        /// CMIS object identifier.
        /// </summary>
        public const string CmisObjectId = CmisPrefix + ":objectId";

        /// <summary>
        /// CMIS object type identifier.
        /// </summary>
        public const string CmisObjectTypeId = CmisPrefix + ":objectTypeId";

        /// <summary>
        /// CMIS basic permissions type.
        /// </summary>
        public const string CmisPermissionTypeBasic = "basic";

        /// <summary>
        /// CMIS repository permissions type.
        /// </summary>
        public const string CmisPermissionTypeRepository = "repository";

        /// <summary>
        /// CMIS basic and repostiory permissions type.
        /// </summary>
        public const string CmisPermissionTypeBoth = "both";

        /// <summary>
        /// CMIS policy.
        /// </summary>
        public const string CmisPolicy = CmisPrefix + ":policy";

        /// <summary>
        /// CMIS policy text.
        /// </summary>
        public const string CmisPolicyText = CmisPrefix + ":policyText";

        /// <summary>
        /// CMIS property type string.
        /// </summary>
        public const string CmisPropertyTypeString = "string";

		/// <summary>
		/// CMIS property type boolean.
		/// </summary>
		public const string CmisPropertyTypeBoolean = "boolean";

		/// <summary>
		/// CMIS property type decimal.
		/// </summary>
		public const string CmisPropertyTypeDecimal = "decimal";

		/// <summary>
		/// CMIS property type integer.
		/// </summary>
		public const string CmisPropertyTypeInteger = "integer";

		/// <summary>
		/// CMIS property type date time.
		/// </summary>
		public const string CmisPropertyTypeDateTime = "datetime";

		/// <summary>
		/// CMIS property type URI.
		/// </summary>
		public const string CmisPropertyTypeUri = "uri";

		/// <summary>
		/// CMIS property type identifier.
		/// </summary>
		public const string CmisPropertyTypeId = "id";

		/// <summary>
		/// CMIS property type HTML fragment.
		/// </summary>
		public const string CmisPropertyTypeHtml = "html";

        /// <summary>
        /// CMIS single cardinality.
        /// </summary>
        public const string CmisCardinalitySingle = "single";

		/// <summary>
		/// CMIS multi cardinality.
		/// </summary>
		public const string CmisCardinalityMulti = "multi";

        /// <summary>
        /// CMIS content stream not allowed.
        /// </summary>
        public const string CmisContentStreamNotAllowed = "notallowed";

        /// <summary>
        /// CMIS content stream allowed.
        /// </summary>
        public const string CmisContentStreamAllowed = "allowed";

        /// <summary>
        /// CMIS content stream required.
        /// </summary>
        public const string CmisContentStreamRequired = "required";

        /// <summary>
        /// CMIS date time resolution: year.
        /// </summary>
        public const string CmisDateTimeResolutionYear = "year";

        /// <summary>
        /// CMIS date time resolution: date.
        /// </summary>
        public const string CmisDateTimeResolutionDate = "date";

        /// <summary>
        /// CMIS date time resolution: time.
        /// </summary>
        public const string CmisDateTimeResolutionTime = "time";

        /// <summary>
        /// CMIS decimal 32 bit precision.
        /// </summary>
        public const string CmisDecimalPrecisionBits32 = "32";

		/// <summary>
		/// CMIS decimal 64 bit precision.
		/// </summary>
		public const string CmisDecimalPrecisionBits64 = "64";

        /// <summary>
        /// CMIS updatability read only.
        /// </summary>
        public const string CmisUpdatabilityReadOnly = "readonly";

        /// <summary>
        /// CMIS updatability read write.
        /// </summary>
        public const string CmisUpdatabilityReadWrite = "readwrite";

        /// <summary>
        /// CMIS updatability when checked out.
        /// </summary>
        public const string CmisUpdatabilityWhenCheckedOut = "whencheckedout";

        /// <summary>
        /// CMIS updatability on create.
        /// </summary>
        public const string CmisUpdatabilityOnCreate = "oncreate";

        /// <summary>
        /// CMIS relationship.
        /// </summary>
        public const string CmisRelationship = CmisPrefix + ":relationship";

        /// <summary>
        /// CMIS secondary.
        /// </summary>
        public const string CmisSecondary = CmisPrefix + ":secondary";

        /// <summary>
        /// CMIS secondary object type identifiers.
        /// </summary>
        public const string CmisSecondaryObjectTypeIds = CmisPrefix + ":secondaryObjectTypeIds";

        /// <summary>
        /// CMIS source identifier.
        /// </summary>
        public const string CmisSourceId = CmisPrefix + ":sourceId";

        /// <summary>
        /// CMIS target identifier.
        /// </summary>
        public const string CmisTargetId = CmisPrefix + ":targetId";

        /// <summary>
        /// Connector class configuration setting name.
        /// </summary>
        public const string ConnectorClassSetting = "ConnectorClass";

        /// <summary>
        /// Mockup connector class that provides dummy results. Can be used for testing.
        /// </summary>
        public const string MockupConnectorClass = "Cmis.Interface.CmisMockupConnector, CmisInterface";

        /// <summary>
        /// Repository service setting.
        /// </summary>
        public const string RepositoryServiceSetting = "RepositoryService";

        /// <summary>
        /// Default repository service class.
        /// </summary>
        public const string DefaultRepositoryServiceClass = "Cmis.Interface.CmisRepositoryService, CmisInterface";

        /// <summary>
        /// The xml namespace for Atom pub (prefix: atom).
        /// </summary>
        public const string XmlNamespaceAtomPub = "http://www.w3.org/2005/Atom";
        /// <summary>
        /// The xml namespace for CMIS (prefix: cmis).
        /// </summary>
        public const string XmlNamespaceCmis = "http://docs.oasis-open.org/ns/cmis/core/200908/";
        /// <summary>
        /// The xml namespace for CMIS REST Atom (prefix: cmisra).
        /// </summary>
        public const string XmlNamespaceCmisRestAtom = "http://docs.oasis-open.org/ns/cmis/restatom/200908/";
        /// <summary>
        /// The xml namespace for applications (prefix: app).
        /// </summary>
        public const string XmlNamespaceApp = "http://www.w3.org/2007/app";
    }
}
