using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventProducer.LoggingService;

namespace EventProducer
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var client = new LoggingServiceClient())
            {
                client.Foo();
            }

            Console.ReadLine();
        }
    }
}
