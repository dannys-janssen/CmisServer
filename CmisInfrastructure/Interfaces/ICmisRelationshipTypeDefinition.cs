//
// ICmisRelationshipTypeDefinition.cs
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
	/// CMIS relationship type definition.
	/// A relationship object instantiates an explicit, binary, directional, 
	/// non-invasive, and typed relationship between a source object and a target 
	/// object. The source object and the target object MUST both be independent 
	/// objects, such as a document object, a folder object, a policy object, or 
	/// an item object. Whether a policy object is allowed to be the source or 
	/// target object of a relationship object is repository-speciﬁc.
	/// </summary>
	public interface ICmisRelationshipTypeDefinition : ICmisTypeDefinition
    {
		/// <summary>
		/// A list of object-type ids, indicating that the source object of a 
		/// relationship object of this type MUST only be one of the types listed. 
		/// If this attribute is "not set", then the source object MAY be of any type.
		/// </summary>
		/// <value>The list of allowed source types.</value>
		IList<ICmisObjectType> AllowedSourceTypes { get; }

		/// <summary>
		/// A list of object-type ids, indicating that the target object of a 
		/// relationship object of this type MUST only be one of the types listed. 
		/// If this attribute is "not set", then the target object MAY be of any type.
		/// </summary>
		/// <value>The list of allowed target types.</value>
		IList<ICmisObjectType> AllowedTargetTypes { get; }
    }
}
