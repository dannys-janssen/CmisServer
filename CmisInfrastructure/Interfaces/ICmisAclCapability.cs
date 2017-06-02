//
// ICmisAclCapabilities.cs
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
    /// CMIS ACL capability.
    /// </summary>
    public interface ICmisAclCapability : ICmisExtensionData
    {
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
    }
}
