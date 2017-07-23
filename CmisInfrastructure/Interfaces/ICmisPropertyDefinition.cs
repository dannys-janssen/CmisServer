//
// ICmisPropertyDefinition.cs
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
	/// CMIS property definition. All object-type property deﬁnitions MUST contain the following attributes. Optional attributes MUST be deﬁned but MAY have "not set" values.
    /// Choices and DefaultValue attributes as specified in the CMIS specs must be defined in inheriting interfaces ore classes.
	/// </summary>
	public interface ICmisPropertyDefinition : ICmisExtensionData
    {
		/// <summary>
		/// This opaque attribute uniquely identiﬁes the property in the repository. If two object-types each contain property deﬁnitions with the same id, the basic property deﬁnitions (property type, query name, cardinality) MUST be the same. Other attributes MAY be diﬀerent for each type.
		/// </summary>
		/// <value>The identifier.</value>
		string Id { get; }

		/// <summary>
		/// This attribute represents the underlying repository’s name for the property. This ﬁeld is opaque and has no uniqueness constraint imposed by this speciﬁcation.
		/// </summary>
		/// <value>The name of the local.</value>
		string LocalName { get; }

		/// <summary>
		/// This attribute allows repositories to represent the internal namespace of the underlying repository’s name for the property.
		/// </summary>
		/// <value>The local namespace.</value>
		string LocalNamespace { get; }

		/// <summary>
		/// Used for query operations on properties. This is an opaque string with limitations. See CMIS specs section 2.1.2.1.3 Query Names for details.
		/// </summary>
		/// <value>The name of the query.</value>
		string QueryName { get; }

		/// <summary>
		/// Used for presentation by application.
		/// </summary>
		/// <value>The display name.</value>
		string DisplayName { get; }

		/// <summary>
		/// This is an optional attribute containing a description of the property.
		/// </summary>
		/// <value>The description.</value>
		string Description { get; }

		/// <summary>
		/// This attribute indicates the type of this property. It MUST be one of the allowed property types. (See CMIS specs section 2.1.2.1 Property.)
		/// </summary>
		/// <value>The type of the property.</value>
		CmisPropertyType PropertyType { get; }

		/// <summary>
		/// Indicates whether the property can have "zero or one" or "zero or more" values.
		/// </summary>
		/// <value>The cardinality.</value>
		CmisCardinality? Cardinality { get; }

		/// <summary>
		/// Indicates under what circumstances the value of this property MAY be updated.
		/// </summary>
		/// <value>The updatability.</value>
		CmisUpdatability? Updatability { get; }

		/// <summary>
		/// Indicates whether the property deﬁnition is inherited from the parent type when TRUE or it is explicitly deﬁned for this object-type when FALSE.
		/// </summary>
		/// <value>The inherited.</value>
		bool? Inherited { get; }

		/// <summary>
		/// This attribute is only applicable to non-system properties, i.e. properties whose value is provided by the application.
		/// If TRUE, then the value of this property MUST never be set to the "not set" state when an object of this type is created/updated.If not provided during a create or update operation, the repository MUST provide a value for this property.If a value is not provided, then the default value deﬁned for the property MUST be set.If no default value is provided and no default value is deﬁned, the repository MUST throw a constraint exception.
		/// This attribute is not applicable when the "updatability" attribute is "readonly". In that case, "required" SHOULD be set to FALSE.
		/// </summary>
		/// <value>The required.</value>
		/// <remarks>For CMIS-deﬁned object-types, the value of a system property (such as cmis:objectId, cmis:createdBy) MUST be set by the repository. However, the property’s "required" attribute SHOULD be FALSE because it is read-only to applications.</remarks>
		bool? Required { get; }

		/// <summary>
		/// Indicates whether or not the property MAY appear in the WHERE clause of a CMIS query statement.
		/// This attribute MUST have a value of FALSE if the object-type’s attribute for "queryable" is set to FALSE.
		/// </summary>
		/// <value>The queryable.</value>
		bool? Queryable { get; }

		/// <summary>
		/// Indicates whether the property can appear in the ORDER BY clause of a CMIS query statement or an orderBy 
        /// parameter of getChildren or getCheckedOutDocs.
		/// This property MUST be FALSE for any property whose cardinality is "multi".
		/// </summary>
		/// <value>The orderable.</value>
		bool? Orderable { get; }

		/// <summary>
		/// This attribute is only applicable to properties that provide a value for the "Choices" attribute.
		/// If FALSE, then the data value for the property MUST only be one of the values speciﬁed in the "Choices" attribute. 
        /// If TRUE, then values other than those included in the "Choices" attribute may be set for the property.
        /// </summary>
        /// <value>The open choice.</value>
        bool? OpenChoice { get; }
    }
}
