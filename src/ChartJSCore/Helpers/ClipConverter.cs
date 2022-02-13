using ChartJSCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Helpers
{
    public class ClipConverter : JsonConverter
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
            Clip clipValue = (Clip)value;

            if (clipValue.ClipInt != null)
            {
                writer.WriteValue(clipValue.ClipInt);
            }
            else
            {
                serializer.Serialize(writer, clipValue.ClipObject);
            }
        }
    }
}
