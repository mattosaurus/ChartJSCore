using Newtonsoft.Json;
using System;

namespace ChartJSCore.Helpers
{
    /// <summary>
    /// If input string value is a bool or int then output without quotes
    /// </summary>
    public class BoolIntStringConverter : JsonConverter
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
            bool boolValue;

            if (bool.TryParse(value.ToString(), out boolValue))
            {
                writer.WriteValue(boolValue);
            }
            else if (int.TryParse(value.ToString(), out intValue))
            {
                if (value.ToString().StartsWith("+") || value.ToString().StartsWith("-"))
                {
                    writer.WriteValue(value.ToString());
                }
                else
                {
                    writer.WriteValue(intValue);
                }
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }
    }
}
