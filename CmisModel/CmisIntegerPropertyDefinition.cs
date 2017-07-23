//
// CmisIntegerPropertyDefinition.cs
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
using Cmis.Infrastructure;

namespace Cmis.Model
{
    /// <summary>
    /// CMIS integer property definition.
    /// </summary>
    public class CmisIntegerPropertyDefinition : CmisPropertyDefinition, ICmisIntegerPropertyDefinition
    {
		/// <summary>
		/// Gets or sets the default value.
		/// </summary>
		/// <value>The default value.</value>
		public IList<int?> DefaultValue { get; set; }

		/// <summary>
		/// Indicates an explicit ordered set of single values allowed for this property.
		/// </summary>
		/// <value>The choices.</value>
		public IList<ICmisChoice<int?>> Choices { get; set; }

		/// <summary>
		/// The minimum value allowed for this property.
		/// If an application tries to set the value of this property to a value lower than minValue, the repository MUST throw a constraint exception.
		/// </summary>
		/// <value>The minimum allowed value.</value>
		public int? MinValue { get; set; }

		/// <summary>
		/// The maximum value allowed for this property.
		/// If an application tries to set the value of this property to a value higher than maxValue, the repository MUST throw a constraint exception.
		/// </summary>
		/// <value>The maximum allowed value value.</value>
        public int? MaxValue { get; set; }
    }
}
