using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using msswit2013_lab2.Core;

namespace msswit2013_lab2.Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			lbStatus.Items.Clear();
			Application.DoEvents();

			ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.AutoDetect;

			var serviceNamespace = "msswit2013relay";
			var issuerName = "owner";
			var issuerSecret = "IqyIwa7gNjBO89HT+3Vd1CcoBbyibvcv6Hd92J+FtPg=";

			Uri serviceUri = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, "Service");

			TransportClientEndpointBehavior sharedSecretServiceBusCredential = new TransportClientEndpointBehavior();
			sharedSecretServiceBusCredential.TokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerSecret);

			ChannelFactory<IEchoChannel> channelFactory = new ChannelFactory<IEchoChannel>("RelayEndpoint", new EndpointAddress(serviceUri));

			channelFactory.Endpoint.Behaviors.Add(sharedSecretServiceBusCredential);

			IEchoChannel channel = channelFactory.CreateChannel();
			channel.Open();

			lbStatus.Items.Add("---");
			lbStatus.Items.Add("test: Ping");
			Application.DoEvents();

			lbStatus.Items.Add("result: " + channel.Ping());
			Application.DoEvents();

			lbStatus.Items.Add("---");
			lbStatus.Items.Add("test: Echo");
			Application.DoEvents();

			lbStatus.Items.Add("echo login: " + channel.Echo(tbLogin.Text));
			Application.DoEvents();

			lbStatus.Items.Add("echo pass: " + channel.Echo(tbPass.Text));
			Application.DoEvents();

			lbStatus.Items.Add("---");
			lbStatus.Items.Add("test: IsLoginSuccess");
			lbStatus.Items.Add("login: " + tbLogin.Text);
			lbStatus.Items.Add("pass: " + tbPass.Text);
			Application.DoEvents();

			lbStatus.Items.Add("result: " + channel.IsLoginSuccess(tbLogin.Text, tbPass.Text));
			lbStatus.Items.Add("---");
			Application.DoEvents();

			channel.Close();
			channelFactory.Close();
		}

		private void btnQueue_Click(object sender, EventArgs e)
		{
			var serviceNamespace = "msswit2013relay";
			var issuerName = "owner";
			var issuerSecret = "IqyIwa7gNjBO89HT+3Vd1CcoBbyibvcv6Hd92J+FtPg=";

			Uri uri = ServiceBusEnvironment.CreateServiceUri("sb", serviceNamespace, string.Empty);

			TokenProvider tokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName, issuerSecret);

			MessagingFactory factory = MessagingFactory.Create(uri, tokenProvider);

			var msg = new ServiceBusTestMessage
			{
				Password = tbPass.Text
			};

			BrokeredMessage sbMessage = new BrokeredMessage(msg);
			sbMessage.Label = "test message";
			sbMessage.Properties["login"] = tbLogin.Text;

			MessageSender messageSender = factory.CreateMessageSender("MyTopic");
			messageSender.Send(sbMessage);
		}
	}
}
