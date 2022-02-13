using Newtonsoft.Json;
using System;

namespace ChartJSCore.Helpers
{
    /// <summary>
    /// If input string value is a bool then output without quotes
    /// </summary>
    public class BoolStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (bool.TryParse(value.ToString(), out bool boolValue))
            {
                writer.WriteValue(boolValue);
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }
    }
}
