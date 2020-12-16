
using ClientFx.ServiceReference;
using System;

namespace ClientFx
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();

            var result =  client.Add(100.0, 200.0);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
