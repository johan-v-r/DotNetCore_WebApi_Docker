using System;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("hosting on port 5000!");

			var host = new WebHostBuilder()
											.UseKestrel()
											.UseUrls("http://*:5000")
											.UseStartup<Startup>()
											.Build();

			host.Run();
		}
	}
}
