using ContractFx;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri bindingAddress = new Uri("http://localhost:8899/helloworld");

            ServiceHost host = new ServiceHost(typeof(CalculatorService), bindingAddress);
            try
            {
                host.AddServiceEndpoint(typeof(ICalculator), new BasicHttpBinding(), "CalculatorService");

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
