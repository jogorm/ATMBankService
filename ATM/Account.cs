using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    [JsonObject(MemberSerialization.OptIn)]
    class Account
    {


        public class GetAccountResult
        {
            public int AccountID { get; set; }
            public string Address { get; set; }
            public int balance { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string pin { get; set; }
            public string postCode { get; set; }
            public int runningTotals { get; set; }
            public string telePhone { get; set; }
        }

        public class RootObject
        {
            public List<GetAccountResult> GetAccountResult { get; set; }
        }

    }
}
