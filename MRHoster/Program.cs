using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;


namespace WCFService.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress1 = new Uri("http://localhost:8082/WCFService/LogIn/");
            Uri baseAddress2 = new Uri("http://localhost:8079/WCFService/Service/");
            //Create Service Host
            ServiceHost host = new ServiceHost(serviceType: typeof(LogIn), baseAddresses: baseAddress1);
            ServiceHost host2 = new ServiceHost(serviceType: typeof(Service), baseAddresses: baseAddress2);

            // Open the ServiceHost to start listening for messages. 
            host.Open();
            host2.Open();
            Console.WriteLine("The LogIn service is ready at {0}", baseAddress1);
            Console.WriteLine("The Main service is ready at {0}", baseAddress2);
            Console.ReadLine();
        }
    }
}
