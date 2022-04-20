using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeRest
{
    public class QuoteMaker
    {
        public static void KanyeQuote()
        {

            var kanyeURL = "https://api.kanye.rest/";

            var client = new HttpClient();

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye said: {kanyeQuote}");
            Console.WriteLine($"------------------------");
            Console.WriteLine();
        }


        public static void RonQuote()
        {

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var client = new HttpClient();

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"__________________________________");

            Console.WriteLine($"Ron said:{ronQuote}");

               Console.WriteLine();

       }
              
    }

}
