using System;
using System.ServiceModel;

namespace Chat_Host
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(WCF_Chat.Service1)))
            {
                serviceHost.Open();
                Console.WriteLine("Хост подключён.");
                Console.ReadLine();
            }
        }
    }
}
