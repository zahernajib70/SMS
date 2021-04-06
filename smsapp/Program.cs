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
            TwilioClient.Init("", "");

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
