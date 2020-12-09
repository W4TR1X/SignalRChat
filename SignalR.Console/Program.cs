using System;

namespace SignalR.Console
{
    class Program
    {

        

        static void Main(string[] args)
        {
            string url = "http://localhost:8080";
            using (WebApp.Start(url))
            {                
                Console.WriteLine("Server runing on {0}", url);
                Console.ReadLine();
            }
        }
    }
}
