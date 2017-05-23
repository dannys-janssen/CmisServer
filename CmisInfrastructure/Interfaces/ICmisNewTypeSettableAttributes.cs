//
// INewTypeSttableAttributes.cs
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
    /// <summary>
    /// CMIS settable attributes when creating new types. 
    /// </summary>
    public interface ICmisNewTypeSettableAttributes : ICmisExtensionData
    {
        /// <summary>
        /// Gets a value indicating whether the identifier attribute can be set when creating new CMIS types.
        /// </summary>
        /// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
        bool Id { get; }

		/// <summary>
		/// Gets a value indicating whether the local name attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool LocalName { get; }

		/// <summary>
		/// Gets a value indicating whether the local namespace attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool LocalNamespace { get; }

		/// <summary>
		/// Gets a value indicating whether the display name attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool DisplayName { get; }

		/// <summary>
		/// Gets a value indicating whether the query name attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool QueryName { get; }

		/// <summary>
		/// Gets a value indicating whether the description attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool Description { get; }

		/// <summary>
		/// Gets a value indicating whether the creatable attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool Createable { get; }

		/// <summary>
		/// Gets a value indicating whether the fileable attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool Fileable { get; }

		/// <summary>
		/// Gets a value indicating whether the queryable attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool Queryable { get; }

		/// <summary>
		/// Gets a value indicating whether the fulltext indexed attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool FulltextIndexed { get; }

		/// <summary>
		/// Gets a value indicating whether the included in supertype query attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool IncludedInSupertypeQuery { get; }

		/// <summary>
		/// Gets a value indicating whether the controllable policy attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool ControllablePolicy { get; }

		/// <summary>
		/// Gets a value indicating whether the controllable ACL attribute can be set when creating new CMIS types.
		/// </summary>
		/// <value><c>true</c> if the attribute can be set; otherwise, <c>false</c>.</value>
		bool ControllableACL { get; }
    }
}
