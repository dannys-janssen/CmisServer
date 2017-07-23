//
// ICmisDecimalPropertyDefinition.cs
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
    /// CMIS decimal property definition.
    /// </summary>
    public interface ICmisDecimalPropertyDefinition : ICmisPropertyDefinition
    {
		/// <summary>
		/// Gets the default value.
		/// </summary>
		/// <value>The default value.</value>
		IList<decimal?> DefaultValue { get; }

		/// <summary>
		/// Indicates an explicit ordered set of single values allowed for this property.
		/// </summary>
		/// <value>The choices.</value>
		IList<ICmisChoice<decimal?>> Choices { get; }

		/// <summary>
		/// The minimum value allowed for this property.
		/// If an application tries to set the value of this property to a value lower than minValue, the repository MUST throw a constraint exception.
		/// </summary>
		/// <value>The minimum allowed value.</value>
		decimal? MinValue { get; }

		/// <summary>
		/// The maximum value allowed for this property.
		/// If an application tries to set the value of this property to a value higher than maxValue, the repository MUST throw a constraint exception.
		/// </summary>
		/// <value>The maximum allowed value value.</value>
		decimal? MaxValue { get; }

		/// <summary>
		/// This is the decimal precision in bits supported for values of this property.
		/// </summary>
		/// <value>The decimal precision.</value>
		CmisDecimalPrecision? Precision { get; }
    }
}
