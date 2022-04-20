using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeRest
{
     class Program
    {
        static void Main(string[] args)
        {
            //var kanyeURL = "https://api.kanye.rest/";

            //var client = new HttpClient();

            //var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            //Console.WriteLine(kanyeQuote);
            //Console.WriteLine();


            for (int i = 0; i < 5 ; i++)

            {
                QuoteMaker.KanyeQuote();      //class.method
                QuoteMaker.RonQuote();

            }

           
                  


            



        }



    }
}
