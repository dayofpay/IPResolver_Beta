using System;
using System.Text;
using System.Net;
using System.IO;

namespace IPResolver_Beta
{
    class Program
    {
        static void Main(string[] args)
        {
            string endmessage = "БЛАГОДАРЯ ВИ, ЧЕ ИЗПОЛЗВАХТЕ IP-RESOLVER 1.0, ПРИ ПРОБЛЕМИ ПИШЕТЕ В ДИСКОРД ГРУПАТА";
            Console.Title = "IP Resolver | 1.0 BETA | by dayofpay";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[>] ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please Select Option: ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[1] RESOLVE IP");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[2] VPN / PROXY CHECKER");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" ");
            Console.Write("[>] ");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Console.Write("[>] IP: ");
                var ip = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request1 = WebRequest.Create("https://ipapi.co/" + ip + "/org");
                WebResponse response = request1.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine("[>] ISP: " + responseFromServer);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request2 = WebRequest.Create("https://ipapi.co/" + ip + "/city");
                WebResponse response2 = request2.GetResponse();
                Stream dataStream2 = response2.GetResponseStream();
                StreamReader reader2 = new StreamReader(dataStream2);
                string responseFromServer2 = reader2.ReadToEnd();
                Console.WriteLine("[>] City: " + responseFromServer2);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request3 = WebRequest.Create("https://ipapi.co/" + ip + "/country_name");
                WebResponse response3 = request3.GetResponse();
                Stream dataStream3 = response3.GetResponseStream();
                StreamReader reader3 = new StreamReader(dataStream3);
                string responseFromServer3 = reader3.ReadToEnd();
                Console.WriteLine("[>] Country: " + responseFromServer3);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request4 = WebRequest.Create("https://ipapi.co/" + ip + "/country_capital");
                WebResponse response4 = request4.GetResponse();
                Stream dataStream4 = response4.GetResponseStream();
                StreamReader reader4 = new StreamReader(dataStream4);
                string responseFromServer4 = reader4.ReadToEnd();
                Console.WriteLine("[>] Capital: " + responseFromServer4);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request5 = WebRequest.Create("https://ipapi.co/" + ip + "/country_tld");
                WebResponse response5 = request5.GetResponse();
                Stream dataStream5 = response5.GetResponseStream();
                StreamReader reader5 = new StreamReader(dataStream5);
                string responseFromServer5 = reader5.ReadToEnd();
                Console.WriteLine("[>] Country Domain: " + responseFromServer5);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request6 = WebRequest.Create("https://ipapi.co/" + ip + "/country_population");
                WebResponse response6 = request6.GetResponse();
                Stream dataStream6 = response6.GetResponseStream();
                StreamReader reader6 = new StreamReader(dataStream6);
                string responseFromServer6 = reader6.ReadToEnd();
                Console.WriteLine("[>] Country Population: " + responseFromServer6);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request7 = WebRequest.Create("https://ipapi.co/" + ip + "/continent_code");
                WebResponse response7 = request7.GetResponse();
                Stream dataStream7 = response7.GetResponseStream();
                StreamReader reader7 = new StreamReader(dataStream7);
                string responseFromServer7 = reader7.ReadToEnd();
                Console.WriteLine("[>] Continent Code: " + responseFromServer7);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request8 = WebRequest.Create("https://ipapi.co/" + ip + "/postal");
                WebResponse response8 = request8.GetResponse();
                Stream dataStream8 = response8.GetResponseStream();
                StreamReader reader8 = new StreamReader(dataStream8);
                string responseFromServer8 = reader8.ReadToEnd();
                Console.WriteLine("[>] Postal Code: " + responseFromServer8);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request9 = WebRequest.Create("https://ipapi.co/" + ip + "/latitude");
                WebResponse response9 = request9.GetResponse();
                Stream dataStream9 = response9.GetResponseStream();
                StreamReader reader9 = new StreamReader(dataStream9);
                string responseFromServer9 = reader9.ReadToEnd();
                Console.WriteLine("[>] Latitude: " + responseFromServer9);
                System.Threading.Thread.Sleep(1600); // ANTI RATE LIMIT
                WebRequest request10 = WebRequest.Create("https://ipapi.co/" + ip + "/longitude");
                WebResponse response10 = request10.GetResponse();
                Stream dataStream10 = response10.GetResponseStream();
                StreamReader reader10 = new StreamReader(dataStream10);
                string responseFromServer10 = reader10.ReadToEnd();
                Console.WriteLine("[>] Longitude: " + responseFromServer10);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request11 = WebRequest.Create("https://ipapi.co/" + ip + "/timezone");
                WebResponse response11 = request11.GetResponse();
                Stream dataStream11 = response11.GetResponseStream();
                StreamReader reader11 = new StreamReader(dataStream11);
                string responseFromServer11 = reader11.ReadToEnd();
                Console.WriteLine("[>] Timezone: " + responseFromServer11);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request12 = WebRequest.Create("https://ipapi.co/" + ip + "/country_calling_code");
                WebResponse response12 = request12.GetResponse();
                Stream dataStream12 = response12.GetResponseStream();
                StreamReader reader12 = new StreamReader(dataStream12);
                string responseFromServer12 = reader12.ReadToEnd();
                Console.WriteLine("[>] Calling Code: " + responseFromServer12);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request13 = WebRequest.Create("https://ipapi.co/" + ip + "/currency");
                WebResponse response13 = request13.GetResponse();
                Stream dataStream13 = response13.GetResponseStream();
                StreamReader reader13 = new StreamReader(dataStream13);
                string responseFromServer13 = reader13.ReadToEnd();
                Console.WriteLine("[>] Currency: " + responseFromServer13);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT
                WebRequest request14 = WebRequest.Create("https://ipapi.co/" + ip + "/languages");
                WebResponse response14 = request14.GetResponse();
                Stream dataStream14 = response14.GetResponseStream();
                StreamReader reader14 = new StreamReader(dataStream14);
                string responseFromServer14 = reader14.ReadToEnd();
                Console.WriteLine("[>] Languages: " + responseFromServer14);
                System.Threading.Thread.Sleep(1000); // ANTI RATE LIMIT 
                WebRequest request15 = WebRequest.Create("https://ipapi.co/" + ip + "/asn");
                WebResponse response15 = request15.GetResponse();
                Stream dataStream15 = response15.GetResponseStream();
                StreamReader reader15 = new StreamReader(dataStream15);
                string responseFromServer15 = reader15.ReadToEnd();
                Console.WriteLine("[>] Languages: " + responseFromServer15);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(endmessage);
                Console.WriteLine("------------------------------------------------------------------");
                var exit = Console.ReadKey();
            }
            if (option == "2")
            {
                Console.Clear();
                Console.Write("IP: ");
                Console.ForegroundColor = ConsoleColor.Red;
                var ip = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                WebRequest request15 = WebRequest.Create("http://proxycheck.io/v2/" + ip + "?key=111111-222222-333333-444444");
                WebResponse response15 = request15.GetResponse();
                Stream dataStream15 = response15.GetResponseStream();
                StreamReader reader15 = new StreamReader(dataStream15);
                string responseFromServer15 = reader15.ReadToEnd();
                Console.WriteLine("[>] Proxy: " + responseFromServer15);
                var exit = Console.ReadKey();
            }
        }
    }
}
// MADE WITH LOVE BY DAYOFPAY <3 || EASIEST POSSIBLE IP RESOLVER DEVELOPED WITH IPAPI & PROXYCHECK.IO // 
