using System;
using System.IO;
using System.Net;

namespace Practice.API_Testing
{
    class APIUtility : IPractice
    {
        public string ApiUtilityMethod(string url)
        {
            string html = string.Empty;
            

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);

            return html;
        }
        public void execute()
        {
            string url = @"https://reqres.in/api/users/1";
            APIUtility apiUtility = new APIUtility();
            apiUtility.ApiUtilityMethod(url);
        }
    }
}
