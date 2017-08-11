//
// ICmisObjectType.cs
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

using System.Collections.Generic;

namespace Cmis.Infrastructure
{
    /// <summary>
    /// CMIS object type. Base type for all CMIS objects.
    /// </summary>
    public interface ICmisObjectType : ICmisTypeDefinition
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Cmis.Infrastructure.ICmisObjectType"/> is a base type.
        /// </summary>
        /// <value><c>true</c> if is a base type; otherwise, <c>false</c>.</value>
        bool IsBaseType { get; }

        /// <summary>
        /// Gets the base type of this object type.
        /// </summary>
        /// <value>The type of the base.</value>
        ICmisObjectType BaseType { get; }

        /// <summary>
        /// Gets the parent type of this object type.
        /// </summary>
        /// <value>The type of the parent.</value>
        ICmisObjectType ParentType { get; }

        /// <summary>
        /// Returns a list of child object types that are directly derived from this type.
        /// </summary>
        /// <returns>The list of child object types.</returns>
        IEnumerable<ICmisObjectType> GetChildren();

		/// <summary>
		/// Returns a list of child object types that are directly or indirectly derived from this type.
		/// </summary>
		/// <returns>The list of child object types contained in INode objects.</returns>
        /// <param name="depth">The inheritance depth level. Value must be greater than 0 (zero) or -1 which indicates infinite depth.</param>
		IList<INode<ICmisObjectType>> GetDescendants(int depth);
    }
}
