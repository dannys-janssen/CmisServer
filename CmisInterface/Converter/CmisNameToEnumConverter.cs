//
// CmisNameToEnumConverter.cs
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

namespace Cmis.Interface
{
	using System;
	using System.Reflection;
	using Cmis.Infrastructure;

    /// <summary>
    /// CMIS name to enum converter. Converts CMIS compliant names to enum values, <see cref="T:CmisNameAttribute"/>.
    /// </summary>
    public static class CmisNameToEnumConverter
    {
        /// <summary>
        /// Converts a enum value to a CMIS name.
        /// </summary>
        /// <returns>The resulting CMIS name.</returns>
        /// <param name="value">The enum value to be converted.</param>
        public static string ToCmisName(this Enum value)
        {
            if (value == null)
                return null;

            var fieldInfo = value.GetType().GetRuntimeField(value.ToString());
            var attribute = fieldInfo.GetCustomAttribute(typeof(CmisNameAttribute), false) as CmisNameAttribute;
            if (attribute == null)
                return null;

            return attribute.Name;
        }

        /// <summary>
        /// Converts a CMIS name string to an enum value.
        /// </summary>
        /// <returns>The resulting enum value.</returns>
        /// <param name="value">The CMIS name stirng to be converted.</param>
        /// <typeparam name="T">The type of the enum to be returned.</typeparam>
        public static T ToEnum<T>(this string value)
        {
            var t = typeof(T);
            var underlyingType = Nullable.GetUnderlyingType(t);
            if (underlyingType != null)
            {
                t = underlyingType;
            }

			foreach (var fieldInfo in t.GetRuntimeFields())
			{
                if (fieldInfo.GetCustomAttribute(typeof(CmisNameAttribute), false) is CmisNameAttribute attribute && attribute.Name == value)
                {
                    return (T)Enum.Parse(t, fieldInfo.Name);
                }
            }

            return default(T);
        }
    }
}
