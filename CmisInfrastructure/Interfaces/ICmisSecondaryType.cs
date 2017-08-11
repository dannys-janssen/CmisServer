//
// ICmisSecondaryType.cs
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
	/// CMIS secondary type.
	/// A secondary type deﬁnes a set of properties that can be dynamically added to and removed from objects. That is, an object can get and lose additional properties that are not deﬁned by its primary type during its lifetime. Multiple secondary types can be applied to the same object at the same time. Secondary types can be simple markers without properties.Alternatively, they can contain technical information about an object. For example, a repository might analyze the content of a document, detects a photo and adds a secondary type that adds EXIF data to the document.Applications might want to attach temporary data to an object such the state of the object in a workﬂow. Secondary types may also change the behaviour of the repository.
	/// </summary>
	public interface ICmisSecondaryType : ICmisObjectType
    {
    }
}
