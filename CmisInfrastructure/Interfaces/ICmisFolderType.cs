//
// ICmisFolderType.cs
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
	/// CMIS folder object-type.
	/// A folder object serves as the anchor for a collection of ﬁle-able objects. 
    /// The folder object has an implicit hierarchical relationship with each object 
    /// in its collection, with the anchor folder object being the parent object and 
    /// each object in the collection being a child object. This implicit relationship 
    /// has speciﬁc containment semantics which MUST be maintained by the repository 
    /// with implicit referential integrity. (That is, there will never be a dangling 
    /// parent-relationship or a dangling child-relationship. Furthermore, object A 
    /// is a parent of object B if and only if object B is a child of object A.) 
    /// This system-maintained implicit relationship is distinct from an explicit 
    /// relationship which is instantiated by an application-maintained relationship object. 
    /// (See section 2.1.6 Relationship Object.) A folder object does not have a 
    /// content-stream and is not version-able.A folder object MAY be associated with 
    /// zero or more renditions(see section 2.1.4.2 Renditions).
    /// </summary>
    public interface ICmisFolderType : ICmisObjectType
    {
        
    }
}
