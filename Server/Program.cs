using Microsoft.Owin.Hosting;
using System;

namespace Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string url = ServerSettings.Default.Url;
            using (WebApp.Start(url))
            {
                Console.WriteLine($"Server running at: {url}");
                Console.ReadKey();
            }
        }
    }
}
