using ChartJSCore.Plugins;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChartJSCore.Helpers
{
    class PluginDynamicConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IList<PluginDynamic>);
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            IList<PluginDynamic> dynamicProperties = (IList<PluginDynamic>)value;

            // Create a JObject from the document, respecting existing JSON attribs
            JArray jObject = JArray.FromObject(value);

            // Replace the incorrectly serialized PluginDynamic List with all required objects
            JProperty jProperty = jObject.Children<JProperty>()
                   .Where(p => p.Name == "pluginDynamic")
                   .First();

            foreach (PluginDynamic dynamicProperty in dynamicProperties)
            {
                jProperty.AddAfterSelf(new JProperty(dynamicProperty.PropertyName, dynamicProperty.PropertyValue));
            }

            jProperty.Remove();

            // Write out the JSON
            jObject.WriteTo(writer);
        }
    }
}
