//
// ICmisTypeMutability.cs
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
    /// CMIS type mutability. Controls how child types of a parent type mey be created updated or deleted.
    /// </summary>
    public interface ICmisTypeMutability : ICmisExtensionData
    {
		/// <summary>
		/// Indicates whether new child types may be created with this type as the parent.
		/// </summary>
		/// <value><c>true</c> if new child types of the parent type may be created; otherwise, <c>false</c>.</value>
		bool? Create { get; }

		/// <summary>
		/// Indicates whether clients may make changes to this type per the constraints deﬁned in this speciﬁcation.
		/// </summary>
		/// <value><c>true</c> if new child types of the parent type may be updated; otherwise, <c>false</c>.</value>
		bool? Update { get; }

		/// <summary>
		/// Indicates whether clients may delete this type if there are no instances of it in the repository.
		/// </summary>
		/// <value><c>true</c> if new child types of the parent type may be deleted; otherwise, <c>false</c>.</value>
		bool? Delete { get; }
    }
}
