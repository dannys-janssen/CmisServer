//
// CmisAclCapability.cs
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
	/// CMIS ACL capability.
	/// </summary>
	public class CmisAclCapability : ICmisAclCapability
    {
		/// <summary>
		/// Gets the supported types of permissions.
		/// </summary>
		/// <value>The supported permissions.</value>
		public CmisSupportedPermissions SupportedPermissions { get; set; }

		/// <summary>
		/// Gets the allowed value(s) for applyACL, which control how non-direct ACEs are handled by the repository.
		/// </summary>
		/// <value>The ACL propagation value.</value>
		public CmisAclProgagation Propagation { get; set; }

		/// <summary>
		/// Gets the list of repository-speciﬁc permissions the repository supports for managing ACEs.
		/// </summary>
		/// <value>The permissions.</value>
		public IList<ICmisPermissionDefinition> Permissions { get; set; }

		/// <summary>
		/// Gets the list of mappings for the CMIS basic permissions to allowable actions.
		/// </summary>
		/// <value>The list of permission mappings.</value>
		public IList<ICmisPermissionMapping> PermissionMapping { get; set; }

		/// <summary>
		/// Gets or sets the list of CMIS extensions.
		/// </summary>
		/// <value>The list of CMIS extensions.</value>
		public IList<ICmisExtensionElement> Extensions { get; set; }
    }
}
