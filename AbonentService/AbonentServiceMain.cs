using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using AbonentService.Interfaces;
using AbonentService.Services;

namespace AbonentService
{
    class AbonentServiceMain
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(AbonentServiceClass), new Uri[] { new Uri("http://localhost:9920") });

            host.AddServiceEndpoint(typeof(IAbonentServiceClass), new BasicHttpBinding(), "WcfBasicService");

            var b = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (b == null) b = new ServiceMetadataBehavior();
            host.Description.Behaviors.Add(b);

            host.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            host.Open();

            Console.WriteLine("Running.");

            Console.ReadLine();

            host.Close();
        }
    }
}
