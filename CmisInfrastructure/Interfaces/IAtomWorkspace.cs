//
// IAtomWorkspace.cs
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
	/// Atom workspace. Represents an Atom workspace. See https://tools.ietf.org/html/rfc5023
	/// </summary>
	public interface IAtomWorkspace
    {
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		string Title { get; set; }

		/// <summary>
		/// Gets or sets the list of collections attached to this workspace.
		/// </summary>
		/// <value>The list of collections.</value>
		IList<IAtomCollection> Collections { get; set; }

		/// <summary>
		/// Gets or sets the repository info.
		/// </summary>
		/// <value>The repository info.</value>
		ICmisRepositoryInfo RepositoryInfo { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		/// <value>The links.</value>
		IList<IAtomLink> Links { get; set; }

		/// <summary>
		/// Gets or sets the URI templates.
		/// </summary>
		/// <value>The URI templates.</value>
		IList<IAtomUriTemplate> UriTemplates { get; set; }
	}
}
