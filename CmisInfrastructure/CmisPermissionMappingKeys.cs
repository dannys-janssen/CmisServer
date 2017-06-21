//
// CmisPermissionKeys.cs
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
    /// CMIS permission mapping keys.
    /// </summary>
    public static class CmisPermissionMappingKeys
    {
        #region Navigation Services

        /// <summary>
        /// Can get the descendants of the folder (getDescendants and getFolderTree).
        /// </summary>
        public const string CanGetDescendantsFolder = "canGetDescendants.Folder";

        /// <summary>
        /// Can get the children of the folder (getChildren).
        /// </summary>
        public const string CanGetChildrenFolder = "canGetChildren.Folder";

        /// <summary>
        /// Can get the parent folder of the folder (getFolderParent).
        /// </summary>
        public const string CanGetFolderParentObject = "canGetFolderParent.Object";

        /// <summary>
        /// Can get the parent folders of the object (getObjectParents).
        /// </summary>
        public const string canGetParentsFolder = "CanGetParentsFolder";

        #endregion

        #region Object Services

        /// <summary>
        /// Can create a cmis:document object in the speciﬁed folder (createDocument).
        /// </summary>
        public const string CanCreateDocumentFolder = "canCreateDocument.Folder";

        /// <summary>
        /// Can create a cmis:folder object as a child of the speciﬁed folder (createFolder).
        /// </summary>
        public const string CanCreateFolderFolder = "canCreateFolder.Folder";

        /// <summary>
        /// Can create a cmis:policy object as a child of the speciﬁed folder (createPolicy).
        /// </summary>
        public const string CanCreatePolicyFolder = "canCreatePolicy.Folder";

        /// <summary>
        /// Can create a relationship object with the object as its source (createRelationship).
        /// </summary>
        public const string CanCreateRelationshipSource = "canCreateRelationship.Source";

        /// <summary>
        /// Can create a relationship object with the object as its target (createRelationship).
        /// </summary>
        public const string CanCreateRelationshipTarget = "canCreateRelationship.Target";

        /// <summary>
        /// Can read the properties of the speciﬁed object (getProperties, getObject and getObjectByPath).
        /// </summary>
        public const string CanGetPropertiesObject = "canGetProperties.Object";

        /// <summary>
        /// Can update the properties of the speciﬁed object (updateProperties).
        /// </summary>
        public const string CanUpdatePropertiesObject = "canUpdateProperties.Object";

        /// <summary>
        /// Can move the speciﬁed object (moveObject).
        /// </summary>
        public const string CanMoveObject = "canMove.Object";

        /// <summary>
        /// Can move an object into this folder (moveObject).
        /// </summary>
        public const string CanMoveTarget = "canMove.Target";

        /// <summary>
        /// Can move an object from this folder (moveObject).
        /// </summary>
        public const string CanMoveSource = "canMove.Source";

        /// <summary>
        /// Can delete the speciﬁed object (deleteObject).
        /// </summary>
        public const string CanDeleteObject = "canDelete.Object";

        /// <summary>
        /// Can get the content stream for the document object (getContentStream).
        /// </summary>
        public const string CanViewContentObject = "canViewContent.Object";

        /// <summary>
        /// Can set the content stream for the document object (setContentStream).
        /// </summary>
        public const string CanSetContentDocument = "canSetContent.Document";

        /// <summary>
        /// Can delete the content stream for the Document object (deleteContentStream).
        /// </summary>
        public const string CanDeleteContentDocument = "canDeleteContent.Document";

        /// <summary>
        /// Can delete the speciﬁed folder and all contained objects (deleteTree).
        /// </summary>
        public const string CanDeleteTreeFolder = "canDeleteTree.Folder";

        #endregion

        #region Filing Services

        /// <summary>
        /// Can ﬁle the object in a folder (addObjectToFolder).
        /// </summary>
        public const string CanAddToFolderObject = "canAddToFolder.Object";

        /// <summary>
        /// Can ﬁle an object in the speciﬁed folder (addObjectToFolder).
        /// </summary>
        public const string CanAddToFolderFolder = "canAddToFolder.Folder";

        /// <summary>
        /// Can unﬁle the speciﬁed document from a folder (removeObjectFromFolder).
        /// </summary>
        public const string CanRemoveFromFolderObject = "canRemoveFromFolder.Object";

        /// <summary>
        /// Can unﬁle an object from the speciﬁed folder (removeObjectFromFolder).
        /// </summary>
        public const string CanRemoveFromFolderFolder = "canRemoveFromFolder.Folder";

        #endregion

        #region Versioning Services

        /// <summary>
        /// Can check out the speciﬁed document (checkOut).
        /// </summary>
        public const string CanCheckoutDocument = "canCheckout.Document";

        /// <summary>
        /// Can cancel the check out the speciﬁed PWC (cancelCheckOut).
        /// </summary>
        public const string CanCancelCheckoutDocument = "canCancelCheckout.Document";

        /// <summary>
        /// Can check in the speciﬁed PWC (checkIn).
        /// </summary>
        public const string CanCheckinDocument = "canCheckin.Document";

        /// <summary>
        /// Can get the version series of the speciﬁed document (getAllVersions).
        /// </summary>
        public const string CanGetAllVersionsVersionSeries = "canGetAllVersions.VersionSeries";

        #endregion

        #region Relationship Services

        /// <summary>
        /// Can get the relationship in which this object is a source or a target (getObjectRelationships).
        /// </summary>
        public const string CanGetObjectRelationshipsObject = "canGetObjectRelationships.Object";

        #endregion

        #region Policy Services

        /// <summary>
        /// Can apply a policy to the speciﬁed object (applyPolicy).
        /// </summary>
        public const string CanAddPolicyObject = "canAddPolicy.Object";

        /// <summary>
        /// Can apply the speciﬁed policy to an object (applyPolicy).
        /// </summary>
        public const string CanAddPolicyPolicy = "canAddPolicy.Policy";

        /// <summary>
        /// Can remove a policy from the speciﬁed object (removePolicy).
        /// </summary>
        public const string CanRemovePolicyObject = "canRemovePolicy.Object";

        /// <summary>
        /// Can remove the speciﬁed policy from an object (removePolicy).
        /// </summary>
        public const string CanRemovePolicyPolicy = "canRemovePolicy.Policy";

        /// <summary>
        /// Can get the list of policies applied to the speciﬁed object (getAppliedPolicies).
        /// </summary>
        public const string CanGetAppliedPoliciesObject = "canGetAppliedPolicies.Object";

		#endregion

		#region ACL Services

		/// <summary>
		/// Can get ACL of the speciﬁed object (getACL).
		/// </summary>
		public const string CanGetACLObject = "canGetACL.Object";

		/// <summary>
		/// Can apply ACL to this object (applyACL).
		/// </summary>
		public const string CanApplyACLObject = "canApplyACL.Object";

        #endregion
    }
}
