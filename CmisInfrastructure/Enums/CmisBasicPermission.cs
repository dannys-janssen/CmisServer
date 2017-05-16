//
// CmisBasicPermission.cs
//
// Author:
//       Dannys Janssen <Janssen@wmd.de>
//
// Copyright (c) 2017 (c) 2017 WMD Group GmbH
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
    /// CMIS basic permission.
    /// </summary>
    public enum CmisBasicPermission
    {
		/// <summary>
		/// Expresses the "permission to read" properties AND content of an object.
		/// </summary>
		[CmisName(Constants.CmisBasicPermissionRead)]
        Read,
		/// <summary>
		/// Expresses the "permission to write" properties AND content of an object. It MAY include the cmis:read permission.
		/// </summary>
		[CmisName(Constants.CmisBasicPermissionWrite)]
        Write,
		/// <summary>
		/// SHOULD express all the permissions of a repository. It SHOULD include all other basic CMIS permissions.
		/// </summary>
		[CmisName(Constants.CmisBasicPermissionAll)]
        All
    }
}
