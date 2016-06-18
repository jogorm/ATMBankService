using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            String webAddr = "http://abcmoneygroup.cloudapp.net/Service1.svc/getAllAccounts";
            String get = "GET";

            //HttpReq getReq = new HttpReq(get, webAddr);
            HttpReq getReq = new HttpReq();
            getReq.get(webAddr);


            Console.WriteLine("Hello, World!");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
