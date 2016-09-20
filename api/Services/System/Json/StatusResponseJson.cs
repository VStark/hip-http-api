using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace HIPHttpApi
{
    internal struct StatusResponseJson
    {
        public bool Success { get; set; }
        public HIPHttpApi.StatusResponseJson.Result Result { get; set; }
    }

    namespace HIPHttpApi.StatusResponseJson
    {
        internal struct Result
        {
            [JsonConverter(typeof(UnixTimeConverter))]
            public DateTime SystemTime { get; set; }
            public int UpTime { get; set; }
        }
    }

    internal class UnixTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            long t;

            if (reader.Value.GetType() != typeof (long))
                t = long.Parse((string) reader.Value);
            else
                t = (long)reader.Value;
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(t);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
