using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ConnectionString
    {
        internal static string GetConnection()
        {
            using(StreamReader r = new StreamReader("config.json"))
{
                string json = r.ReadToEnd();
                var obj = JObject.Parse(json);
                string connection = (string)obj["default"].First;

                return connection??"null was returned";
            }
            return "Fail to connect";
        }
    }
}
