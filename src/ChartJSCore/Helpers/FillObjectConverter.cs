using Newtonsoft.Json;
using System;

namespace ChartJSCore.Helpers {
    /// <summary>
    /// If input string value is a bool or int or coplex fill object then output without quotes
    /// </summary>
    public class FillObjectConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return objectType == typeof(LineChartFill);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            return reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            var fillObject = new { target = "", above = "", below = "" };
            var fillValue = JsonConvert.DeserializeAnonymousType(value.ToString(), fillObject);
            if (fillValue.above == "" || fillValue.below == null) {

            }
            if (bool.TryParse(value.ToString(), out bool boolValue)) {
                writer.WriteValue(boolValue);
            } else if (int.TryParse(value.ToString(), out int intValue)) {
                if (value.ToString().StartsWith("+") || value.ToString().StartsWith("-")) {
                    writer.WriteValue(value.ToString());
                } else {
                    writer.WriteValue(intValue);
                }
            } else if (fillValue != null) {
                writer.WriteValue(fillValue.ToString());
            } else {
                writer.WriteValue(value.ToString());
            }
        }
    }
}
