//
// CmisRepositoryInfoJsonConverter.cs
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
    using Cmis.Infrastructure;
    using Cmis.Model;
    using Newtonsoft.Json;


    /// <summary>
    /// CMIS repository info json converter. Converts <see cref="ICmisRepositoryInfo"/> instances to their JSON representation.
    /// </summary>
    public class CmisRepositoryInfoJsonConverter : JsonConverter
    {
		/// <summary>
		/// Determines whether this instance can convert the specified object type.
		/// </summary>
		/// <returns><c>true</c>, if this instance can convert the specified object type; <c>false</c> otherwise.</returns>
		/// <param name="objectType">Type of the object.</param>
		public override bool CanConvert(Type objectType)
        {

            if (objectType == null)
                throw new ArgumentNullException(nameof(objectType));

            try
            {
                if (objectType == typeof(CmisRepositoryInfo))
                    return true;

                if (objectType is ICmisRepositoryInfo)
                    return true;

                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <returns>The object value.</returns>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">The type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling <see cref="JsonSerializer"/>.</param>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
#pragma warning disable RECS0083 // Shows NotImplementedException throws in the quick task bar
            throw new NotImplementedException();
#pragma warning restore RECS0083 // Shows NotImplementedException throws in the quick task bar
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling <see cref="JsonSerializer"/>.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                var instance = (ICmisRepositoryInfo)value;
                writer.WriteStartObject(); // BOF 

                writer.WritePropertyName(instance.RepositoryId);
                writer.WriteStartObject(); // BOF repo info

                writer.WritePropertyName(nameof(instance.RepositoryId).ToLowerFirstChar());
                writer.WriteValue(instance.RepositoryId);

                writer.WritePropertyName(nameof(instance.RepositoryName).ToLowerFirstChar());
                writer.WriteValue(instance.RepositoryName);

                writer.WritePropertyName(nameof(instance.RepositoryDescription).ToLowerFirstChar());
                writer.WriteValue(instance.RepositoryDescription);

                writer.WritePropertyName(nameof(instance.VendorName).ToLowerFirstChar());
                writer.WriteValue(instance.VendorName);

                writer.WritePropertyName(nameof(instance.ProductName).ToLowerFirstChar());
                writer.WriteValue(instance.ProductName);

                writer.WritePropertyName(nameof(instance.ProductVersion).ToLowerFirstChar());
                writer.WriteValue(instance.ProductVersion);

                writer.WritePropertyName(nameof(instance.RootFolderId).ToLowerFirstChar());
                writer.WriteValue(instance.RootFolderId);

                writer.WritePropertyName(nameof(instance.Capabilities).ToLowerFirstChar());
                writer.WriteStartObject(); // BOF repo capabilities

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityContentStreamUpdatability).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityContentStreamUpdatability.ToCmisName());

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityChanges).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityChanges.ToCmisName());

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityRenditions).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityRenditions.ToCmisName());

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityGetDescendants).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityGetDescendants);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityGetFolderTree).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityGetFolderTree);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityMultiﬁling).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityMultiﬁling);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityUnﬁling).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityUnﬁling);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityVersionSpeciﬁcFiling).ToLowerFirstChar());
				writer.WriteValue(instance.Capabilities.CapabilityVersionSpeciﬁcFiling);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityPWCSearchable).ToLowerFirstChar());
				writer.WriteValue(instance.Capabilities.CapabilityPWCSearchable);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityPWCUpdatable).ToLowerFirstChar());
				writer.WriteValue(instance.Capabilities.CapabilityPWCUpdatable);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityAllVersionsSearchable).ToLowerFirstChar());
				writer.WriteValue(instance.Capabilities.CapabilityAllVersionsSearchable);

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityOrderBy).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityOrderBy.ToCmisName());

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityQuery).ToLowerFirstChar());
				writer.WriteValue(instance.Capabilities.CapabilityQuery.ToCmisName());

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityJoin).ToLowerFirstChar());
				writer.WriteValue(instance.Capabilities.CapabilityJoin.ToCmisName());

                writer.WritePropertyName(nameof(instance.Capabilities.CapabilityACL).ToLowerFirstChar());
                writer.WriteValue(instance.Capabilities.CapabilityACL.ToCmisName());


                writer.WriteEndObject(); // EOF repo capabilities

                //writer.WritePropertyName(nameof(instance.AclCapability).ToLowerFirstChar());
                writer.WritePropertyName("aclCapabilities");
				writer.WriteStartObject(); // BOF repo acl capability

                writer.WritePropertyName(nameof(instance.AclCapability.SupportedPermissions).ToLowerFirstChar());
                writer.WriteValue(instance.AclCapability.SupportedPermissions.ToCmisName());

                writer.WritePropertyName(nameof(instance.AclCapability.Propagation).ToLowerFirstChar());
                writer.WriteValue(instance.AclCapability.Propagation.ToCmisName());

                writer.WritePropertyName(nameof(instance.AclCapability.Permissions).ToLowerFirstChar());
                writer.WriteStartArray();

                if (instance.AclCapability.Permissions != null)
                {
                    foreach(var permission in instance.AclCapability.Permissions)
                    {
                        if (permission != null)
                        {
							writer.WriteStartObject();

                            writer.WritePropertyName(nameof(permission.Permission).ToLowerFirstChar());
                            writer.WriteValue(permission.Permission);

                            writer.WritePropertyName(nameof(permission.Description).ToLowerFirstChar());
                            writer.WriteValue(permission.Description);

							writer.WriteEndObject();    
                        }

                    }
                }

                writer.WriteEndArray();

                writer.WritePropertyName(nameof(instance.AclCapability.PermissionMapping).ToLowerFirstChar());
				writer.WriteStartArray();

                if (instance.AclCapability.PermissionMapping != null)
				{
                    foreach (var mapping in instance.AclCapability.PermissionMapping)
					{
						if (mapping != null)
						{
							writer.WriteStartObject();

                            writer.WritePropertyName(nameof(mapping.Key).ToLowerFirstChar());
                            writer.WriteValue(mapping.Key);

                            writer.WritePropertyName(nameof(mapping.Permission).ToLowerFirstChar());
                            writer.WriteStartArray();

                            if (mapping.Permission != null)
                            {
                                foreach(var mappingPermission in mapping.Permission)
                                {
                                    writer.WriteValue(mappingPermission);
                                }
                            }

                            writer.WriteEndArray();

							writer.WriteEndObject();
						}

					}
				}

                writer.WriteEndArray();


                writer.WriteEndObject(); // EOF repo acl capability


                writer.WritePropertyName(nameof(instance.LatestChangeLogToken).ToLowerFirstChar());
                writer.WriteValue(instance.LatestChangeLogToken);

                writer.WritePropertyName(nameof(instance.CmisVersionSupported).ToLowerFirstChar());
                writer.WriteValue(instance.CmisVersionSupported);

                writer.WritePropertyName(nameof(instance.ChangesIncomplete).ToLowerFirstChar());
                writer.WriteValue(instance.ChangesIncomplete);

                writer.WritePropertyName(nameof(instance.ChangesOnType).ToLowerFirstChar());
                writer.WriteStartArray();

                if (instance.ChangesOnType != null)
                {
                    foreach(var changeOnType in instance.ChangesOnType)
                    {
                        writer.WriteValue(changeOnType.ToCmisName());
                    }
                }

                writer.WriteEndArray();

                writer.WritePropertyName(nameof(instance.PrincipalIdAnonymous).ToLowerFirstChar());
				writer.WriteValue(instance.PrincipalIdAnonymous);

                writer.WritePropertyName(nameof(instance.PrincipalIdAnyone).ToLowerFirstChar());
                writer.WriteValue(instance.PrincipalIdAnyone);

                writer.WritePropertyName(nameof(instance.ExtendedFeatures).ToLowerFirstChar());
                writer.WriteStartArray();

                if (instance.ExtendedFeatures != null)
                {
                    foreach (var feature in instance.ExtendedFeatures)
                    {
                        writer.WriteStartObject();

                        writer.WritePropertyName(nameof(feature.Id).ToLowerFirstChar());
                        writer.WriteValue(feature.Id);

                        writer.WritePropertyName(nameof(feature.Url).ToLowerFirstChar());
                        writer.WriteValue(feature.Url);

                        writer.WritePropertyName(nameof(feature.CommonName).ToLowerFirstChar());
						writer.WriteValue(feature.CommonName);

                        writer.WritePropertyName(nameof(feature.Description).ToLowerFirstChar());
                        writer.WriteValue(feature.VersionLabel);

                        writer.WritePropertyName(nameof(feature.Description).ToLowerFirstChar());
						writer.WriteValue(feature.CommonName);

                        if (feature.Data != null)
                        {
                            writer.WritePropertyName(nameof(feature.Data).ToLowerFirstChar());
                            writer.WriteStartArray();

                            foreach (var item in feature.Data)
                            {
                                writer.WriteStartObject();

                                writer.WritePropertyName("key");
                                writer.WriteValue(item.Key);

								writer.WritePropertyName("value");
                                writer.WriteValue(item.Value);

                                writer.WriteEndObject();
                            }

                            writer.WriteEndArray();
                        }

                        writer.WriteEndObject();
                    }
                }

                writer.WriteEndArray();

                writer.WritePropertyName(nameof(instance.RepositoryUrl).ToLowerFirstChar());
                writer.WriteValue(instance.RepositoryUrl);

                writer.WritePropertyName(nameof(instance.RootFolderUrl).ToLowerFirstChar());
                writer.WriteValue(instance.RootFolderUrl);

				writer.WriteEndObject(); // EOF repo info


                writer.WriteEndObject(); // EOF
            }
        }

        public override bool CanRead
        {
            get
            {
                return false;
            }
        }
    }
}
