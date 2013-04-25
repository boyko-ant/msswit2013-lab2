using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using msswit2013_lab2.Core;

namespace msswit2013_lab2.SubscriptionHost
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter some subscription name: ");
			string name = Console.ReadLine();

			var serviceNamespace = "msswit2013relay";
			var issuerName = "owner";
			var issuerSecret = "IqyIwa7gNjBO89HT+3Vd1CcoBbyibvcv6Hd92J+FtPg=";

			Uri uri = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, string.Empty);

			TokenProvider tokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerSecret);
			NamespaceManager namespaceManager = new NamespaceManager(uri, tokenProvider);

			if (!namespaceManager.TopicExists("MyTopic"))
			{
				namespaceManager.CreateTopic(new TopicDescription("MyTopic"));
			}

			Console.WriteLine("topic ready");

			if (!namespaceManager.SubscriptionExists("MyTopic", "subscription-" + name))
			{
				namespaceManager.CreateSubscription("MyTopic", "subscription-" + name);
			}

			Console.WriteLine("subscription ready");

			MessagingFactory factory = MessagingFactory.Create(uri, tokenProvider);
			MessageReceiver receiver = factory.CreateMessageReceiver("MyTopic/subscriptions/subscription-" + name);
			while (true)
			{
				BrokeredMessage receivedMessage = receiver.Receive();
				if (receivedMessage != null)
				{
					try
					{
						Console.WriteLine("label: {0}", receivedMessage.Label);
						Console.WriteLine("login: {0}", receivedMessage.Properties["login"]);
						Console.WriteLine("pass: {0}", receivedMessage.GetBody<ServiceBusTestMessage>().Password);
						receivedMessage.Complete();
					}
					catch (Exception e)
					{
						receivedMessage.Abandon();
						Console.WriteLine(e.Message);
					}
				}
				else
				{
					Thread.Sleep(new TimeSpan(0, 0, 10));
				}
			}
		}
	}
}
