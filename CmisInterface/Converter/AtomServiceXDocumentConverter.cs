//
// CmisRepositoryShortInfoXDocumentConverter.cs
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

namespace Cmis.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Cmis.Infrastructure;
    using Cmis.Model;

    /// <summary>
    /// Atom service to XDocument converter. Converts an <see cref="IAtomService"/> instance to an <see cref="XDocument"/> instance.
    /// </summary>
    public class AtomServiceXDocumentConverter
    {
        #region Fields

        public XNamespace AtomPubNamespace = Constants.XmlNamespaceAtomPub;
        public XNamespace CmisNamespace = Constants.XmlNamespaceCmis;
        public XNamespace CmisRestAtomPubNamespace = Constants.XmlNamespaceCmisRestAtom;
        public XNamespace ApplicationNamespace = Constants.XmlNamespaceApp;

        #endregion

        #region Public Methods

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <returns><c>true</c>, if this instance can convert the specified object type; <c>false</c> otherwise.</returns>
        /// <param name="objectType">Type of the object.</param>
        public bool CanConvert(Type objectType)
        {

            if (objectType == null)
                throw new ArgumentNullException(nameof(objectType));

            try
            {
                if (objectType == typeof(AtomService))
                    return true;

                if (objectType is IAtomService)
                    return true;

                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Converts an <see cref="IAtomService"/> instance to an <see cref="XDocument"/> instance.
        /// </summary>
        /// <returns>The converted <see cref="XDocument"/> instance.</returns>
        /// <param name="value">The <see cref="IAtomService"/> instance to be converted.</param>
        public XDocument Convert(object value)
        {
            XDocument result = null;
            if (value != null)
            {
                var instance = (IAtomService)value;

                result = new XDocument();
                result.Declaration = new XDeclaration("1.0", "utf-8", "yes");

                XNamespace atomNs = Constants.XmlNamespaceAtomPub;
                XNamespace cmisNs = Constants.XmlNamespaceCmis;
                XNamespace cmisRaNs = Constants.XmlNamespaceCmisRestAtom;
                XNamespace appNs = Constants.XmlNamespaceApp;


                XElement element = new XElement(appNs + "service",
                   new XAttribute(XNamespace.Xmlns + "atom", atomNs),
                   new XAttribute(XNamespace.Xmlns + "cmis", cmisNs),
                   new XAttribute(XNamespace.Xmlns + "cmisra", cmisRaNs),
                   new XAttribute(XNamespace.Xmlns + "app", appNs),
                   ConvertWorkspace(instance.Workspaces[0]));

                result.Add(element);

                return result;

            }

            return null;
        }

        #endregion

        #region Private Methods

        XElement ConvertWorkspace(IAtomWorkspace workspace)
        {
            if (workspace == null)
                return null;

            var result = new XElement(ApplicationNamespace + "workspace",
                new XElement(AtomPubNamespace + "title", workspace.Title));

            foreach (var collection in workspace.Collections)
            {
                result.Add(ConvertCollection(collection));
            }

            result.Add(ConvertRepositoryInfo(workspace.RepositoryInfo));

            foreach (var link in workspace.Links)
            {
                result.Add(ConvertAtomLink(link));
            }

            foreach (var template in workspace.UriTemplates)
            {
                result.Add(ConvertUriTemplate(template));
            }

            return result;
        }

        XElement ConvertCollection(IAtomCollection collection)
        {
            if (collection == null)
                return null;

            var result = new XElement(ApplicationNamespace + "collection",
                new XAttribute("href", collection.Uri),
                    new XElement(CmisRestAtomPubNamespace + "collectionType", collection.CollectionType.ToCmisName()),
                    new XElement(AtomPubNamespace + "title", new XAttribute("type", "text"), collection.Title));

            foreach (var accept in collection.Accept)
            {
                var element = new XElement(ApplicationNamespace + "accept", accept.ToCmisName());
                result.Add(element);
            }

            return result;
        }

        XElement ConvertRepositoryInfo(ICmisRepositoryInfo info)
        {
            if (info == null)
                return null;

            var result = new XElement(CmisRestAtomPubNamespace + "repositoryInfo",
                new XElement(CmisNamespace + nameof(info.RepositoryId).ToLowerFirstChar(), info.RepositoryId),
                new XElement(CmisNamespace + nameof(info.RepositoryName).ToLowerFirstChar(), info.RepositoryName),
                new XElement(CmisNamespace + nameof(info.RepositoryDescription).ToLowerFirstChar(), info.RepositoryDescription),
                new XElement(CmisNamespace + nameof(info.VendorName).ToLowerFirstChar(), info.VendorName),
                new XElement(CmisNamespace + nameof(info.ProductName).ToLowerFirstChar(), info.ProductName),
                new XElement(CmisNamespace + nameof(info.ProductVersion).ToLowerFirstChar(), info.ProductVersion),
                new XElement(CmisNamespace + nameof(info.RootFolderId).ToLowerFirstChar(), info.RootFolderId),
                ConvertRepositoryCapabilities(info.Capabilities),
                ConvertAclCapability(info.AclCapability),
                new XElement(CmisNamespace + nameof(info.CmisVersionSupported).ToLowerFirstChar(), info.CmisVersionSupported),
                new XElement(CmisNamespace + nameof(info.ChangesIncomplete).ToLowerFirstChar(), info.ChangesIncomplete),
                ConvertCmisChangesOnTypeList(info.ChangesOnType),
                new XElement(CmisNamespace + nameof(info.PrincipalIdAnonymous).ToLowerFirstChar(), info.PrincipalIdAnonymous),
                new XElement(CmisNamespace + nameof(info.PrincipalIdAnyone).ToLowerFirstChar(), info.PrincipalIdAnyone));


            return result;
        }

        XElement ConvertRepositoryCapabilities(ICmisRepositoryCapabilities capabilities)
        {
            if (capabilities == null)
            {
                return null;
            }

            var result = new XElement(CmisNamespace + "capabilities", new XElement(CmisNamespace + nameof(capabilities.CapabilityACL).ToLowerFirstChar(), capabilities.CapabilityACL.ToCmisName()), new XElement(CmisNamespace + nameof(capabilities.CapabilityAllVersionsSearchable).ToLowerFirstChar(), capabilities.CapabilityAllVersionsSearchable),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityChanges).ToLowerFirstChar(), capabilities.CapabilityChanges.ToCmisName()),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityContentStreamUpdatability).ToLowerFirstChar(), capabilities.CapabilityContentStreamUpdatability.ToCmisName()),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityGetDescendants).ToLowerFirstChar(), capabilities.CapabilityGetDescendants),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityGetFolderTree).ToLowerFirstChar(), capabilities.CapabilityGetFolderTree),
                new XElement(CmisNamespace + "capabilityMultifiling", capabilities.CapabilityMultiﬁling),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityPWCSearchable).ToLowerFirstChar(), capabilities.CapabilityPWCSearchable),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityPWCUpdatable).ToLowerFirstChar(), capabilities.CapabilityPWCUpdatable),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityQuery).ToLowerFirstChar(), capabilities.CapabilityQuery.ToCmisName()),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityRenditions).ToLowerFirstChar(), capabilities.CapabilityRenditions.ToCmisName()),
                new XElement(CmisNamespace + "capabilityUnfiling", capabilities.CapabilityUnﬁling),
                //new XElement(CmisNamespace + "capabilityVersionSpeciﬁcFling", ""),
                new XElement(CmisNamespace + nameof(capabilities.CapabilityJoin).ToLowerFirstChar(), capabilities.CapabilityJoin.ToCmisName()),
                new XElement(CmisNamespace + "capabilityVersionSpecificFiling", capabilities.CapabilityVersionSpeciﬁcFiling));

            return result;

        }

        XElement ConvertAclCapability(ICmisAclCapability capability)
        {
            if (capability == null)
            {
                return null;
            }

            var result = new XElement(CmisNamespace + "aclCapability",
                new XElement(CmisNamespace + nameof(capability.SupportedPermissions).ToLowerFirstChar(), capability.SupportedPermissions.ToCmisName()),
                new XElement(CmisNamespace + nameof(capability.Propagation).ToLowerFirstChar(), capability.Propagation.ToCmisName()));

            if (capability.Permissions != null)
            {
                foreach (var permission in capability.Permissions)
                {
                    result.Add(ConvertCmisPermissionDefinition(permission));
                }
            }

            if (capability.PermissionMapping != null)
            {
                foreach (var mapping in capability.PermissionMapping)
                {
                    result.Add(ConvertCmisPermissionMapping(mapping));
                }
            }

            return result;
        }

        XElement ConvertCmisPermissionDefinition(ICmisPermissionDefinition permission)
        {
            if (permission == null)
            {
                return null;
            }

            var result = new XElement(CmisNamespace + "permissions",
                new XElement(CmisNamespace + nameof(permission.Permission).ToLowerFirstChar(), permission.Permission),
                new XElement(CmisNamespace + nameof(permission.Description).ToLowerFirstChar(), permission.Description));

            return result;
        }

        XElement ConvertCmisPermissionMapping(ICmisPermissionMapping mapping)
        {
            if (mapping == null)
            {
                return null;
            }

            var result = new XElement(CmisNamespace + "mapping", new XElement(CmisNamespace + nameof(mapping.Key).ToLowerFirstChar(), mapping.Key));

            if (mapping.Permission != null)
            {
                foreach (var permission in mapping.Permission)
                {
                    result.Add(new XElement(CmisNamespace + "permission", permission));
                }
            }

            return result;
        }

        XElement[] ConvertCmisChangesOnTypeList(IList<CmisBaseTypeId?> changesOnTypeList)
        {
            if (changesOnTypeList == null || !changesOnTypeList.Any())
                return null;

            var result = new List<XElement>();

            foreach (var item in changesOnTypeList)
            {
                if (item.HasValue)
                {
                    var element = new XElement(CmisNamespace + "changesOnType", item.ToCmisName());
                    result.Add(element);
                }
            }

            return result.ToArray();
        }

        XElement ConvertAtomLink(IAtomLink atomLink)
        {
            var result = new XElement(AtomPubNamespace + "link");

            if (!string.IsNullOrWhiteSpace(atomLink.Relation))
                result.SetAttributeValue("rel", atomLink.Relation);

            if (!string.IsNullOrWhiteSpace(atomLink.Relation))
                result.SetAttributeValue("href", atomLink.Reference);

            if (!string.IsNullOrWhiteSpace(atomLink.Relation))
                result.SetAttributeValue("type", atomLink.MediaType.ToCmisName());

            if (!string.IsNullOrWhiteSpace(atomLink.Relation))
                result.SetAttributeValue("id", atomLink.Id);

            if (!string.IsNullOrWhiteSpace(atomLink.Relation))
                result.SetAttributeValue("title", atomLink.Title);

            return result;
        }

        XElement ConvertUriTemplate(IAtomUriTemplate template)
        {
            if (template == null)
                return null;

            return new XElement(CmisRestAtomPubNamespace + "uritemplate",
                new XElement(CmisRestAtomPubNamespace + nameof(template.Template).ToLowerFirstChar(), template.Template),
                new XElement(CmisRestAtomPubNamespace + "type", template.UriTemplateType.ToCmisName()),
                new XElement(CmisRestAtomPubNamespace + nameof(template.MediaType).ToLowerFirstChar(), template.MediaType.ToCmisName()));
        }

        #endregion
    }
}
