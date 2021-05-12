using System;
using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json.Linq;

namespace DDK.Helper
{
    public class DynamicHelper
    {
        public DynamicHelper()
        {
        }

        public static bool HasProperty(dynamic value, string name)
        {
            if (value is JObject)
            {
                return value.ContainsKey(name);
            }

            if (value is ExpandoObject)
            {
                return ((IDictionary<string, object>)value).ContainsKey(name);
            }

            return value.GetType().GetProperty(name) != null;
        }
    }
}
