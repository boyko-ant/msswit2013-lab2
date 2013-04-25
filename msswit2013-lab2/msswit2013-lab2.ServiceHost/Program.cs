using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus;

namespace msswit2013_lab2.ServiceHost
{
	class Program
	{
		static void Main(string[] args)
		{
			var sharedSecretServiceBusCredential = new TransportClientEndpointBehavior();

			var serviceNamespace = "msswit2013relay";
			var issuerName = "owner";
			var issuerSecret = "IqyIwa7gNjBO89HT+3Vd1CcoBbyibvcv6Hd92J+FtPg=";

			sharedSecretServiceBusCredential.TokenProvider =
				TokenProvider.CreateSharedSecretTokenProvider(
					issuerName,
					issuerSecret);

			Uri address =
				ServiceBusEnvironment.CreateServiceUri(
					"sb",
					serviceNamespace,
					"Service");

			ServiceBusEnvironment.SystemConnectivity.Mode =
				ConnectivityMode.AutoDetect;

			var host = new System.ServiceModel.ServiceHost(
				typeof(Service),
				address);

			IEndpointBehavior serviceRegistrySettings =
				new ServiceRegistrySettings(DiscoveryType.Public);

			foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
			{
				endpoint.Behaviors.Add(serviceRegistrySettings);
				endpoint.Behaviors.Add(sharedSecretServiceBusCredential);
			}

			host.Open();

			Console.WriteLine("Service address: " + address);
			Console.WriteLine("Press [Enter] to close");
			Console.ReadLine();

			host.Close();
		}
	}
}
