using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WordPress.Client;
using WordPress.Client.Models;

namespace WordPress.ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                Test();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();
        }

        static async Task Test()
        {
            var wordPressClient = new WordPressClient(ApiCredentials.WordPressUri)
            {
                AuthMethod = AuthMethod.JWT
            };
            await wordPressClient.RequestJWToken(ApiCredentials.Username, ApiCredentials.Password);
            var posts = await wordPressClient.Posts.GetAll(useAuth: true);
            Console.WriteLine(JsonConvert.SerializeObject(posts));

            //using (var httpClient = new HttpClient())
            //{
            //    var json = JsonConvert.SerializeObject(new
            //    {
            //        username = ApiCredentials.Username,
            //        password = ApiCredentials.Password
            //    });
            //    var response = await httpClient.PostAsync("http://wptest.nwroy.com/wp-json/api/v1/token", new StringContent(json, Encoding.UTF8, "application/json"));
            //    Console.WriteLine(response);
            //    var str = await response.Content.ReadAsStringAsync();
            //    Console.WriteLine(str);
            //}
            Console.Read();
        }
    }
}