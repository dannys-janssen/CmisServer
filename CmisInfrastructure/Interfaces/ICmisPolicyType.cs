//
// ICmisPolicyType.cs
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
	/// CMIS policy type.
	/// A policy object represents an administrative policy that can be enforced 
    /// by a repository. CMIS does not specify what kinds of administrative policies 
    /// that are speciﬁcally supported, nor attempts to model administrative policy 
    /// of any particular kind. Only a base object-type is speciﬁed for policy objects. 
    /// Each policy object holds the text of an administrative policy as a 
    /// repository-speciﬁc string, which is opaque to CMIS and which may be used 
    /// to support policies of various kinds. A repository may create subtypes of 
    /// this base type to support diﬀerent kinds of administrative policies more 
    /// speciﬁcally. If a repository does not support policy objects, the policy 
    /// base object-type SHOULD NOT be returned by a getTypeChildren service call. 
    /// This is an extension point for repositories that want to expose other 
    /// capabilities via CMIS that are not supported directly in CMIS.
	/// </summary>
	public interface ICmisPolicyType : ICmisObjectType
    {
    }
}
