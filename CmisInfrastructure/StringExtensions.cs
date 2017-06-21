//
// StringExtensions.cs
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
    using System;
    using System.Text;

    /// <summary>
    /// String extensions.
    /// </summary>
    public static class StringExtensions
    {
		/// <summary>
		/// Converts a string either to a pascal or camel case string. http://www.biggle.de/blog/string-nach-pascal-und-camelcase-c-quicky
		/// </summary>
		/// <returns>The resulting string.</returns>
		/// <param name="value">The string to be converted.</param>
		/// <param name="stringCase">String case.</param>
		public static string ToCaseString(this string value, StringCase stringCase)
        {
			string[] splittedPhrase = value.Split(' ', '-', '.');
			var sb = new StringBuilder();

			if (stringCase == StringCase.CamelCase)
			{
				sb.Append(splittedPhrase[0].ToLower());
				splittedPhrase[0] = string.Empty;
			}
            else if (stringCase == StringCase.PascalCase)
				sb = new StringBuilder();

			foreach (String s in splittedPhrase)
			{
				char[] splittedPhraseChars = s.ToCharArray();
				if (splittedPhraseChars.Length > 0)
				{
					splittedPhraseChars[0] = ((new String(splittedPhraseChars[0], 1)).ToUpper().ToCharArray())[0];
				}
				sb.Append(new String(splittedPhraseChars));
			}
			return sb.ToString();
        }

        /// <summary>
        /// Converts the first character of each word to lower.
        /// </summary>
        /// <returns>The resukting string.</returns>
        /// <param name="value">The string to be converted.</param>
        public static string ToLowerFirstChar(this string value)
        {
			string[] splittedPhrase = value.Split(' ', '-', '.');
			var sb = new StringBuilder();

			foreach (String s in splittedPhrase)
			{
				sb.Append(Char.ToLowerInvariant(s[0]) + s.Substring(1));
			}

            return sb.ToString();
        }
    }
}
