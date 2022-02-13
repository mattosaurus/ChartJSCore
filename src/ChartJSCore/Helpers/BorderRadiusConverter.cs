using ChartJSCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Helpers
{
    public class BorderRadiusConverter : JsonConverter
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
            BorderRadius borderRadiusValue = (BorderRadius)value;

            if (borderRadiusValue.BorderRadiusIntInt != null)
            {
                writer.WriteValue(borderRadiusValue.BorderRadiusIntInt);
            }
            else
            {
                serializer.Serialize(writer, borderRadiusValue.BorderRadiusObject);
            }
        }
    }
}
