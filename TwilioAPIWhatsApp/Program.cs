using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

class Program
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        // DANGER! This is insecure. See http://twil.io/secure
        const string accountSid = "AC6a2a8a255366902772b2dbf438bba5d7";
        const string authToken = "b1ef326d8273c186a1308ac568bdcedf";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "ai sim meu patrao!",
            from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
            to: new Twilio.Types.PhoneNumber("whatsapp:+5511991164957")
        );

        Console.WriteLine(message.DateCreated);
        Console.ReadKey();
    }
}