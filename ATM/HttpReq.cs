using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;



namespace ATM
{
    class HttpReq
    {
        //public HttpReq(String type, String url)
        //{
        //    if(type == "GET")
        //    {
        //        get(url);
        //    }
        //}

        public ArrayList get(String url)
        {
            ArrayList al = new ArrayList();
            var httpWebRequest = WebRequest.Create(url);
            string text;
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }

            JToken root = JObject.Parse(text);
            JToken all = root["GetAllAccountsResult"];
            Account deser = JsonConvert.DeserializeObject<Account>(ToString());

            System.Diagnostics.Debug.WriteLine(deser.ToString());

            Account a = new Account();
            JsonConvert.DeserializeObject<Account.GetAccountResult>(text);
            return null;
        }
    }
}
