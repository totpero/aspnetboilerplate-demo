﻿using Abp.Timing;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;

namespace AspnetBoilerplate.Demo.ModelBinders
{
    public class OldDateTimeJsonConverter : IsoDateTimeConverter
    {
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(DateTime) || objectType == typeof(DateTime?))
            {
                return true;
            }

            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (base.ReadJson(reader, objectType, existingValue, serializer) is DateTime date)
            {
                return Clock.Normalize(date);
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var date = value as DateTime?;
            base.WriteJson(writer, date.HasValue ? Clock.Normalize(date.Value) : value, serializer);
        }
    }
}