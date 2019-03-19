using ChartJSCore.Models;
using Newtonsoft.Json;
using System;

namespace ChartJSCore.Helpers
{
    public class PaddingConverter : JsonConverter
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
            Padding paddingValue = (Padding)value;

            if (paddingValue.PaddingInt != null)
            {
                writer.WriteValue(paddingValue.PaddingInt);
            }
            else
            {
                serializer.Serialize(writer, paddingValue.PaddingObject);
            }
        }
    }
}
