//
// CmisMockupConfigurationStore.cs
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
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Cmis.Infrastructure;
    using Cmis.Model;

    /// <summary>
    /// CMIS mockup connector. Mockup implementation of <see cref="ICmisConnector"/> for tests.
    /// </summary>
    public class CmisMockupConnector : ICmisConnector
    {
        /// <summary>
        /// Gets or sets the service root URI. 
        /// </summary>
        /// <value>The service root.</value>
        public string ServiceRoot { get; set; }

		/// <summary>
		/// Gets or sets the list of CMIS extensions.
		/// </summary>
		/// <value>The list of CMIS extensions.</value>
		public IList<ICmisExtensionElement> Extensions { get; set; }

		/// <summary>
		/// Gets the list of repositories.
		/// </summary>
		/// <returns>The repositories list.</returns>
		public Task<IList<ICmisRepositoryShortInfo>> GetRepositoriesAsync()
        {
            
            IList<ICmisRepositoryShortInfo> result = new List<ICmisRepositoryShortInfo>();
			result.Add(new CmisRepositoryShortInfo
			{
				RepositoryId = "FI",
				RepositoryName = "FI repo",
				RepositoryUrl = $"{ServiceRoot}/api/FI/cmis/{Constants.CmisVersion}/browser",
				RootFolderUrl = $"{ServiceRoot}/api/FI/cmis/{Constants.CmisVersion}/browser/root"
			});

			result.Add(new CmisRepositoryShortInfo
			{
				RepositoryId = "MM",
				RepositoryName = "MM repo",
				RepositoryUrl = $"{ServiceRoot}/api/MM/cmis/{Constants.CmisVersion}/browser",
				RootFolderUrl = $"{ServiceRoot}/api/MM/cmis/{Constants.CmisVersion}/browser/root"
			});

            return Task.FromResult(result);
        }

		/// <summary>
		/// Gets the repository info for a specific CMIS repository.
		/// </summary>
		/// <returns>The repository info.</returns>
		/// <param name="repositoryId">Repository identifier.</param>
		public Task<ICmisRepositoryInfo> GetRepositoryInfoAsync(string repositoryId)
        {
			ICmisRepositoryInfo result = new CmisRepositoryInfo
			{
                RepositoryId = repositoryId,
                RepositoryName = $"{repositoryId} repo",
				RepositoryUrl = $"{ServiceRoot}/api/{repositoryId}/cmis/{Constants.CmisVersion}/browser",
				RootFolderUrl = $"{ServiceRoot}/api/{repositoryId}/cmis/{Constants.CmisVersion}/browser/root",
				RootFolderId = "root",
				RepositoryDescription = $"{repositoryId} repo description",
				ProductName = "CMIS Server",
				ProductVersion = "0.1",
				PrincipalIdAnyone = "EVERYONE",
				PrincipalIdAnonymous = "NOBODY",
				VendorName = "Dannys Janssen",
				CmisVersionSupported = Constants.CmisVersion,
				ChangesIncomplete = true,
				ChangesOnType = new List<CmisBaseTypeId?>
				{
					CmisBaseTypeId.CmisDocument,
					CmisBaseTypeId.CmisFolder
				},
				Capabilities = new CmisRepositoryCapabilities
                {
                    CapabilityContentStreamUpdatability = CmisCapabilityContentStreamUpdatability.Anytime,
                    CapabilityChanges = CmisCapabilityChanges.None,
                    CapabilityRenditions = CmisCapabilityRenditions.Read,
                    CapabilityGetDescendants = true,
                    CapabilityGetFolderTree = true,
                    CapabilityMultiﬁling = true,
                    CapabilityUnﬁling = true,
                    CapabilityVersionSpeciﬁcFiling = true,
                    CapabilityPWCSearchable = false,
                    CapabilityPWCUpdatable = false,
                    CapabilityAllVersionsSearchable = false,
                    CapabilityQuery = CmisCapabilityQuery.BothSeparate,
					CapabilityJoin = CmisCapabilityJoin.None,
					CapabilityACL = CmisCapabilityACL.None
				},
				AclCapability = new CmisAclCapability
				{
                    SupportedPermissions = CmisSupportedPermissions.Basic,
					Propagation = CmisAclProgagation.RepositoryDetermined,
					Permissions = new List<ICmisPermissionDefinition>
					{
						new CmisPermissionDefinition
						{
							Permission = Constants.CmisBasicPermissionRead,
							Description = "CMIS Read"
						},
						new CmisPermissionDefinition
						{
							Permission = Constants.CmisBasicPermissionWrite,
							Description = "CMIS Write"
						},
						new CmisPermissionDefinition
						{
							Permission = Constants.CmisBasicPermissionAll,
							Description = "CMIS All"
						}
					},
					PermissionMapping = new List<ICmisPermissionMapping>
                    {
                        new CmisPermissionMapping
                        {
                            Key = CmisPermissionMappingKeys.CanUpdatePropertiesObject,
                            Permission = new List<string>
                            {
                                Constants.CmisBasicPermissionWrite
                            }
                        }
                    }
				},
                ExtendedFeatures = new List<ICmisRepositoryFeature>
				{
					new CmisRepositoryFeature
					{
						Id = "http://docs.oasis-open.org/ns/cmis/extension/datetimeformat",
						Url = "https://www.oasis-open.org/committees/tc_home.php?wg_abbrev=cmis",
						CommonName = "Browser Binding DateTime Format",
						VersionLabel = "1.0",
						Description = "Adds an additional DateTime format for the Browser Binding."
					}
				}

			};

            return Task.FromResult(result);
        }

		/// <summary>
		/// Gets the AtomPub Service Document that contains the set of repositories that are available. See http://docs.oasis-open.org/cmis/CMIS/v1.1/os/CMIS-v1.1-os.html#x1-4280007
		/// </summary>
		public async Task<IAtomService> GetServiceDocument()
        {
            var repositoryInfo = await GetRepositoryInfoAsync("FI");
            IAtomService result = new AtomService
            {
                Workspaces = new List<IAtomWorkspace>
                {
                    new AtomWorkspace
                    {
                        Title = repositoryInfo.RepositoryId,
                        Collections = new List<IAtomCollection>
                        {
                            new AtomCollection
                            {
                                Uri = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/{Constants.CmisVersion}/atom/children?id=root",
                                CollectionType = CmisCollectionType.Root,
                                Title = "Root Collection",
                                Accept = new List<CmisMediaType>
                                {
                                    CmisMediaType.Entry,
                                    CmisMediaType.CmisAtom
                                }
                            },
                            new AtomCollection
                            {
                                Uri = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/types",
                                CollectionType = CmisCollectionType.Types,
                                Title = "Types Collection",
                                Accept = new List<CmisMediaType>
                                {
                                    
                                }
                            },
                            new AtomCollection
                            {
                                Uri = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/query",
                                CollectionType = CmisCollectionType.Query,
                                Title = "Query Collection",
                                Accept = new List<CmisMediaType>
                                {
                                    CmisMediaType.Query
                                }
                            },
                            new AtomCollection
                            {
                                Uri = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/checkedout",
                                CollectionType = CmisCollectionType.CheckedOut,
                                Title = "Checked Out Collection",
								Accept = new List<CmisMediaType>
								{
                                    CmisMediaType.CmisAtom
								}
                            },
                            new AtomCollection
                            {
                                Uri = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/unfiled",
                                CollectionType = CmisCollectionType.Unfiled,
                                Title = "Unfiled Collection",
								Accept = new List<CmisMediaType>
								{
									CmisMediaType.CmisAtom
								}
                            },
                            new AtomCollection
                            {
                                Uri = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/update",
                                CollectionType = CmisCollectionType.Update,
                                Title = "Bulk Update Collection",
								Accept = new List<CmisMediaType>
								{
									CmisMediaType.CmisAtom
								}
                            }
                        },
                        RepositoryInfo = repositoryInfo,
                        Links = new List<IAtomLink>
                        {
                            new AtomLink
                            {
                                Relation = "http://docs.oasis-open.org/ns/cmis/link/200908/typedescendants",
                                Reference = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/typedesc",
                                MediaType = CmisMediaType.Feed
                            },
                            new AtomLink
                            {
                                Relation = "http://docs.oasis-open.org/ns/cmis/link/200908/foldertree",
                                Reference = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/foldertree?id=root",
                                MediaType = CmisMediaType.Descendants
                            },
							new AtomLink
							{
								Relation = "http://docs.oasis-open.org/ns/cmis/link/200908/rootdescendants",
								Reference = $"{ServiceRoot}/api/{repositoryInfo.RepositoryId}/cmis/versions/{Constants.CmisVersion}/atom/descendants?id=root",
								MediaType = CmisMediaType.Descendants,
                                Id = "root"
							}
                        },
                        UriTemplates = new List<IAtomUriTemplate>
                        {
                            new AtomUriTemplate
                            {
                                Template = ServiceRoot + "/api/" + repositoryInfo.RepositoryId + "/cmis/versions/" + Constants.CmisVersion + "/atom/id?id={id}&amp;filter={filter}&amp;includeAllowableActions={includeAllowableActions}&amp;includeACL={includeACL}&amp;includePolicyIds={includePolicyIds}&amp;includeRelationships={includeRelationships}&amp;renditionFilter={renditionFilter}",
                                MediaType = CmisMediaType.Entry,
                                UriTemplateType = CmisUriTemplateType.ObjectById
                            },
							new AtomUriTemplate
							{
								Template = ServiceRoot + "/api/" + repositoryInfo.RepositoryId + "/cmis/versions/" + Constants.CmisVersion + "/atom/path?path={path}&amp;filter={filter}&amp;includeAllowableActions={includeAllowableActions}&amp;includeACL={includeACL}&amp;includePolicyIds={includePolicyIds}&amp;includeRelationships={includeRelationships}&amp;renditionFilter={renditionFilter}",
								MediaType = CmisMediaType.Entry,
                                UriTemplateType = CmisUriTemplateType.ObjectByPath
							},
							new AtomUriTemplate
							{
								Template = ServiceRoot + "/api/" + repositoryInfo.RepositoryId + "/cmis/versions/" + Constants.CmisVersion + "/atom/type?id={id}",
                                MediaType = CmisMediaType.Entry,
                                UriTemplateType = CmisUriTemplateType.TypeById
							},
							new AtomUriTemplate
                            {
                                Template = ServiceRoot + "/api/" + repositoryInfo.RepositoryId + "/cmis/versions" + Constants.CmisVersion + "/atom/query?q={q}&amp;searchAllVersions={searchAllVersions}&amp;includeAllowableActions={includeAllowableActions}&amp;includeRelationships={includeRelationships}&amp;maxItems={maxItems}&amp;skipCount={skipCount}",
                                MediaType = CmisMediaType.Feed,
                                UriTemplateType = CmisUriTemplateType.Query
							}
                        }
                    }
                }
            };

            return result;
        }
    }
}
