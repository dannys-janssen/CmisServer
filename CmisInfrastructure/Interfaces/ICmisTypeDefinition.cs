//
// ICmisTypeDefinition.cs
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
    /// CMIS type definition.
    /// </summary>
    public interface ICmisTypeDefinition : ICmisExtensionData
    {
		/// <summary>
		/// Identiﬁes this type in the repository.
		/// </summary>
		/// <value>The identifier.</value>
		string Id { get; }

		/// <summary>
		/// Represents the underlying repository’s name for the type.
		/// </summary>
		/// <value>The local name of the type.</value>
		string LocalName { get; }

		/// <summary>
		/// Allows repositories to represent the internal namespace of the underlying repository’s name for the type.
		/// </summary>
		/// <value>The local namespace.</value>
		string LocalNamespace { get; }

		/// <summary>
		/// Used for query and ﬁlter operations on object-types. This is an opaque string with limitations. See 2.1.2.1.3 Query Names for details.
		/// </summary>
		/// <value>The name of the type in a query.</value>
		string QueryName { get; }

		/// <summary>
		/// Used for presentation by application.
		/// </summary>
		/// <value>The display name.</value>
		string DisplayName { get; }

		/// <summary>
		/// A value that indicates whether the base type for this type is the document, folder, relationship, policy, item, or secondary base type.
		/// </summary>
		/// <value>The base type identifier.</value>
		CmisBaseTypeId BaseId { get; }

		/// <summary>
		/// The id of the object-type’s immediate parent type. It MUST be "not set" for a base type. Depending on the binding this means it might not exist on the base type object-type deﬁnition.
		/// </summary>
		/// <value>The parent type identifier.</value>
		string ParentTypeId { get; }

		/// <summary>
		/// Description of this object-type, such as the nature of content, or its intended use. Used for presentation by application.
		/// </summary>
		/// <value>The description.</value>
		string Description { get; }

		/// <summary>
		/// Indicates whether new objects of this type MAY be created. If the value of this attribute is FALSE, the repository MAY contain objects of this type already, but MUST NOT allow new objects of this type to be created.
		/// </summary>
		/// <value><c>true</c> if creatable; otherwise, <c>false</c>.</value>
		bool? Creatable { get; }

		/// <summary>
		/// Indicates whether or not objects of this type are ﬁle-able.
        /// </summary>
		/// <value><c>true</c> if fileable; otherwise, <c>false</c>.</value>
		bool? Fileable { get; }

		/// <summary>
		/// Indicates whether or not this object-type can appear in the FROM clause of a query statement. A non-queryable object-type is not visible through the relational view that is used for query, and CAN NOT appear in the FROM clause of a query statement.
		/// </summary>
		/// <value><c>true</c> if queryable; otherwise, <c>false</c>.</value>
		bool? Queryable { get; }

		/// <summary>
		/// Indicates whether or not objects of this type are controllable via policies. Policy objects can only be applied to controllablePolicy objects.
		/// </summary>
		/// <value><c>true</c> if controllable; otherwise, <c>false</c>.</value>
		bool? ControllablePolicy { get; }

		/// <summary>
		/// This attribute indicates whether or not objects of this type are controllable by ACL’s. Only objects that are controllableACL can have an ACL.
		/// </summary>
		/// <value><c>true</c> if controllable; otherwise, <c>false</c>.</value>
		bool? ControllableACL { get; }

		/// <summary>
		/// Indicates whether objects of this type are indexed for full-text search for querying via the CONTAINS() query predicate. If the value of this attribute is TRUE, the full-text index MUST cover the content and MAY cover the metadata.
		/// </summary>
		/// <value><c>true</c> if fulltext indexed; otherwise, <c>false</c>.</value>
		bool? FulltextIndexed { get; }

		/// <summary>
		/// Indicates whether this type and its subtypes appear in a query of this type’s ancestor types. For example: if Invoice is a sub-type of cmis:document, if this is TRUE on Invoice then for a query on cmis:document, instances of Invoice will be returned if they match. If this attribute is FALSE, no instances of Invoice will be returned even if they match the query.
		/// </summary>
		/// <value><c>true</c> if included in super type query; otherwise, <c>false</c>.</value>
		bool? IncludedInSuperTypeQuery { get; }

        /// <summary>
        /// Gets the type mutability of this type.
        /// </summary>
        /// <value>The type mutability.</value>
        ICmisTypeMutability TypeMutability { get; }

        /// <summary>
        /// Gets the <see cref="T:Cmis.Infrastructure.ICmisTypeDefinition"/> with the specified propertyId.
        /// </summary>
        /// <param name="propertyId">Property identifier.</param>
        ICmisPropertyDefinition this[string propertyId] { get; }

        /// <summary>
        /// Gets a list of all property definitions of this type.
        /// </summary>
        /// <value>The list of property definitions.</value>
        IList<ICmisPropertyDefinition> PropertyDefinitions { get; }
    }
}
