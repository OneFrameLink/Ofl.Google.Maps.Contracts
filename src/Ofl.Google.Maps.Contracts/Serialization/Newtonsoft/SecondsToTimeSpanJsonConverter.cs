using System;
using Newtonsoft.Json;

namespace Ofl.Google.Maps.Serialization.Newtonsoft
{
    internal class SecondsToTimeSpanJsonConverter : JsonConverter
    {
        #region Overrides of JsonConverter

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override bool CanConvert(Type objectType)
        {
            // Not implemented.
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Validate parameters.
            if (reader == null) throw new ArgumentNullException(nameof(reader));

            // Token type must be an integer.
            if (reader.TokenType != JsonToken.Integer)
                throw new InvalidOperationException($"Unexpected token parsing date. Expected Integer, got {reader.TokenType}.");

            // Convert.
            return TimeSpan.FromSeconds((long) reader.Value);
        }


        #endregion
    }
}
