using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace msswit2013_lab2.Core
{
	[ServiceContract(Name = "IEchoContract",
		Namespace = "http://samples.microsoft.com/ServiceModel/Relay/")]
	public interface IEchoContract
	{
		[OperationContract]
		string Ping();

		[OperationContract]
		string Echo(string text);

		[OperationContract]
		bool IsLoginSuccess(string login, string pass);
	}

	public interface IEchoChannel : IEchoContract, IClientChannel { }
}
