using ContractFx;
using Microsoft.Exchange.WcfWebClient.EWS;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri bindingAddress = new Uri("http://DESKTOP-7SB1GVL:8899/helloworld");

            ServiceHost host = new ServiceHost(typeof(ExchangeServiceImpl), bindingAddress);
            try
            {
                host.AddServiceEndpoint(typeof(ExchangeServicePortType), new BasicHttpBinding(), "Exchange");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.ReadLine();

                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred: {0}", e.Message);
                host.Abort();
            }
        }
    }
}
