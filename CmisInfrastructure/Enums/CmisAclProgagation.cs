//
// CmisAclProgagation.cs
//
// Author:
//       Dannys Janssen
//
// Copyright (c) 2017 (c) 2017 Dannys Janssen
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
	/// CMIS ACL progagation. Speciﬁes how non-direct ACEs can be handled by the repository.
	/// </summary>
	public enum CmisAclProgagation
    {
		/// <summary>
		/// Indicates that the repository is able to apply ACEs to an object without changing the ACLs of other objects..
		/// </summary>
		[CmisName(Constants.CmisAclPropagationObjectOnly)]
        ObjectOnly,
		/// <summary>
		/// Indicates that the ACEs might be inherited by other objects. propagate includes the support for objectonly.
		/// </summary>
		[CmisName(Constants.CmisAclPropagationPropagate)]
        Propagate,
		/// <summary>
		/// Indicates that the repository has its own mechanism of computing how changing an ACL for an object inﬂuences the non-direct ACEs of other objects.
		/// </summary>
		[CmisName(Constants.CmisAclRepositoryDetermined)]
        RepositoryDetermined
    }
}
