using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;
using Tools.Extensions;

namespace Tools
{
    public class Program
    {
        static void Main()
        {
            string json = @"{""cursor"":null,""records"":[{""id"":""2994326266"",""username"":""moscowdaydream"",""instagram"":true},{""id"":""2412462982"",""username"":""jasonjosephofer"",""instagram"":true}]}";
            var j = JObject.Parse(json);
            var l = j.GetListByKey("records", "id", "username");
        }
    }
}
