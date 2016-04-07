using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Tools.Extensions
{
    /// <summary>
    /// Extensions methods for JObject class.
    /// </summary>
    public static class JObjectExtension
    {
        /// <summary>
        /// Fill list of KeyValuePair for array called "arrayName"
        /// Key is a value from "arrayName" found by "keyName"
        /// Value is a value from "arrayName" found by "valueName"
        /// </summary>
        /// <param name="json">JObject with parsed string</param>
        /// <param name="arrayName"></param>
        /// <param name="keyName">string</param>
        /// <param name="valueName">string</param>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetListByKey(this JObject json, string arrayName, string keyName, string valueName)
        {
            var values = new List<KeyValuePair<string, string>>();
            if ( !String.IsNullOrEmpty((string)json[arrayName][0][keyName]) )
            {
                var tokens = json[arrayName].Children();
                var pairs = tokens.Select (c =>
                        new { key = c[keyName].Value<string>(), value = c[valueName].Value<string>() });
                pairs.ToList().ForEach(p => { values.Add(new KeyValuePair<string, string>(p.key, p.value)); });
            }
            return values;
        }
    }
}
