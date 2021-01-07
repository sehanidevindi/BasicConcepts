using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.com._02basicconcepts
{
    interface IEmail
    {
        void SendEmail();
    }

    class OutlookEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("send outlook email");
        
        }
    }

    class WebserviceEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("send webservice email");

        }
    }
}
