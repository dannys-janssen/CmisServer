//
// ICmisPermissionMapping.cs
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
	/// CMIS permission mapping.
	/// Since several allowable actions require permissions on more than one 
	/// object, the mapping table is deﬁned in terms of permission "keys". 
	/// (For example, moving a document from one folder to another may 
	/// require permissions on the document and each of the folders.) 
	/// Each key combines the name of the allowable action and the object 
	/// for which the principal needs the required permission. For example, 
	/// the canMoveObject.Source key indicates the permissions that the 
	/// principal must have on the "source folder" to move an object from 
	/// that folder into another folder.
	/// </summary>
	public interface ICmisPermissionMapping : ICmisExtensionData
    {
		/// <summary>
		/// Gets the permission key name.
        /// </summary>
        /// <value>The permission key.</value>
        string Key { get; }

		/// <summary>
		/// The name of one or more permissions that the principal MUST have. If more than one permission is speciﬁed, then the principal MUST be allowed to perform the operation if they have ANY of the listed permissions.
		/// </summary>
		/// <value>The list of permission names.</value>
		IList<string> Permissions { get; }
    }
}
