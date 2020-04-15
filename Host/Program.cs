using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFServices;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(PhotoService)))
            {
                host.Open();
                Console.WriteLine("Photo Host Started. Press any key to stop it");
                Console.ReadKey();
                Console.WriteLine("Host has been shut down!");
            }
        }
    }
}
