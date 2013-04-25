using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msswit2013_lab2.Core;

namespace msswit2013_lab2.ServiceHost
{
	public class Service : IEchoContract
	{
		public string Ping()
		{
			Console.WriteLine("Ping() called");
			return "Ping!";
		}

		public string Echo(string text)
		{
			Console.WriteLine("Echo({0}) called", text);
			return text;
		}

		public bool IsLoginSuccess(string login, string pass)
		{
			Console.WriteLine("IsLoginSuccess({0}, {1}) called", login, pass);
			return login == "admin" && pass == "pass";
		}
	}
}
