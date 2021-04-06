using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace smsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            TwilioClient.Init("AC071e44d9f62b4f7c33ed011cf9f741d3", "f16a646bba4cdb1c46de67e5fb9c3f5a");

            //var call = CallResource.Create(
            //    new PhoneNumber("+96170395280"), 
            //    from: new PhoneNumber("+16174207868"),
            //    url: new Uri("https://my.twiml.here")
            //);
            //Console.WriteLine(call.Sid);

            var message = MessageResource.Create(
                new PhoneNumber("+2727822929"), 
                from: new PhoneNumber("+16174207868"),
                body: "we are senting to you this message from twilio"
            );
            Console.WriteLine(message.Sid);


        }
    }
}
