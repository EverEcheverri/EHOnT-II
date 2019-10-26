using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Repository.Extensions
{
    internal static class StringExtensions
    {
        private static readonly JsonSerializerSettings LazyJsonSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            DateTimeZoneHandling = DateTimeZoneHandling.Utc
        };
        public static string ToJson<T>(this T input)
        {
            return JsonConvert.SerializeObject(input, LazyJsonSettings);
        }

        public static T FromJson<T>(this string input)
        {
            return JsonConvert.DeserializeObject<T>(input, LazyJsonSettings);
        }
    }
}
