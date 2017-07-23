﻿//
// IRepositoryService.cs
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
    using System.Threading.Tasks;

    /// <summary>
    /// CMIS Repository service.
    /// </summary>
    public interface ICmisRepositoryService
    {
		/// <summary>
		/// Gets or sets the service root URI. 
		/// </summary>
		/// <value>The service root.</value>
		string ServiceRoot { get; set; }

		/// <summary>
		/// Returns a list of CMIS repositories available from this CMIS service endpoint.
		/// </summary>
		/// <returns>The list of repository identifiers and names.</returns>
		Task<IList<ICmisRepositoryShortInfo>> GetRepositoriesAsync();

		/// <summary>
		/// Returns information about the CMIS repository, the optional capabilities it supports and its access control information if applicable.
		/// </summary>
		/// <returns>The repository info.</returns>
		/// <param name="repositoryId">Repository identifier.</param>
		Task<ICmisRepositoryInfo> GetRepositoryInfoAsync(string repositoryId);

		/// <summary>
		/// Gets the AtomPub Service Document that contains the set of repositories that are available. See http://docs.oasis-open.org/cmis/CMIS/v1.1/os/CMIS-v1.1-os.html#x1-4280007
		/// </summary>
		/// <returns>The Atom service document.</returns>
		/// <param name="repositoryId">Repository identifier. When not set, informations about all repositories are returned. Defaults to null.</param>
        Task<IAtomService> GetServiceDocumentAsync(string repositoryId = null);
    }
}
