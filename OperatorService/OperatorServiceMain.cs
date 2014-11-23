using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using OperatorService.Interfaces;
using OperatorService.Services;

namespace OperatorService
{
    class OperatorServiceMain
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(OperatorServiceClass), new Uri[] { new Uri("http://localhost:9910") });

            host.AddServiceEndpoint(typeof(IOperatorServiceClass), new BasicHttpBinding(), "WcfBasicService");

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
