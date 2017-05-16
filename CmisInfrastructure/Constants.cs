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

using System;
namespace Cmis.Infrastructure
{
    /// <summary>
    /// Global constants.
    /// </summary>
    public static class Constants
    {
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
    }
}
