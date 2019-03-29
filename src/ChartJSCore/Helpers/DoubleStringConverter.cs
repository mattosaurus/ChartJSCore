using Newtonsoft.Json;
using System;

namespace ChartJSCore.Helpers
{
    /// <summary>
    /// If input string value is a bool or int then output without quotes
    /// </summary>
    public class DoubleStringConverter : JsonConverter
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
            double doubleValue;

            if (double.TryParse(value.ToString(), out doubleValue))
            {
                writer.WriteValue(doubleValue);
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }
    }
}
