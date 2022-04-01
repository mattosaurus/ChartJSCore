using Newtonsoft.Json;
using System;

namespace ChartJSCore.Helpers
{
    /// <summary>
    /// If input string value is a int then output without quotes
    /// </summary>
    public class IntStringConverter : JsonConverter
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
            int intValue;

            if (int.TryParse(value.ToString(), out intValue))
            {
                writer.WriteValue(intValue);
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }
    }
}
