//
// CmisRepositoryShortInfoJsonConverter.cs
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
    using Cmis.Infrastructure;
    using Cmis.Model;
    using Newtonsoft.Json;

	/// <summary>
	/// CMIS repository short info json converter. Converts <see cref="ICmisRepositoryShortInfo"/> instances to their JSON representation.
	/// </summary>
	public class CmisRepositoryShortInfoJsonConverter : JsonConverter
    {
		/// <summary>
		/// Determines whether this instance can convert the specified object type.
		/// </summary>
		/// <returns><c>true</c>, if this instance can convert the specified object type; <c>false</c> otherwise.</returns>
		/// <param name="objectType">Type of the object.</param>
		public override bool CanConvert(Type objectType)
		{

			if (objectType == null)
				throw new ArgumentNullException(nameof(objectType));

			try
			{
				if (objectType == typeof(CmisRepositoryShortInfo))
					return true;

				if (objectType == typeof(CmisRepositoryInfo))
					return true;

				if (objectType is ICmisRepositoryShortInfo)
					return true;

				if (objectType is ICmisRepositoryInfo)
					return true;

				return false;
			}
			catch
			{
				return false;
			}
		}

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <returns>The object value.</returns>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">The type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling <see cref="JsonSerializer"/>.</param>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
#pragma warning disable RECS0083 // Shows NotImplementedException throws in the quick task bar
            throw new NotImplementedException();
#pragma warning restore RECS0083 // Shows NotImplementedException throws in the quick task bar
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling <see cref="JsonSerializer"/>.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value != null)
			{
				var instance = (ICmisRepositoryShortInfo)value;
				writer.WriteStartObject(); // BOF 

				writer.WritePropertyName(instance.RepositoryId);
				writer.WriteStartObject(); // BOF repo info

				writer.WritePropertyName(nameof(instance.RepositoryId).ToLowerFirstChar());
				writer.WriteValue(instance.RepositoryId);

				writer.WritePropertyName(nameof(instance.RepositoryName).ToLowerFirstChar());
				writer.WriteValue(instance.RepositoryName);

				
				writer.WritePropertyName(nameof(instance.RepositoryUrl).ToLowerFirstChar());
				writer.WriteValue(instance.RepositoryUrl);

				writer.WritePropertyName(nameof(instance.RootFolderUrl).ToLowerFirstChar());
				writer.WriteValue(instance.RootFolderUrl);

				writer.WriteEndObject(); // EOF repo info


				writer.WriteEndObject(); // EOF
			}
		}

		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

	}
}
