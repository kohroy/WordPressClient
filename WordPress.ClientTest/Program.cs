using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WordPress.Client;

namespace WordPress.ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test();

            Console.Read();
        }

        static async Task Test()
        {
            var wordPressClient = new WordPressClient("");
            await wordPressClient.RequestJWToken("", "");

            //var categories = await wordPressClient.Categories.GetAll(useAuth: true);
            //Console.WriteLine(JsonConvert.SerializeObject(categories));

            //await wordPressClient.Categories.Create(new Client.Models.Category { Name = "接口创建的分类", Description = "通过接口创建的分类" });
            var posts = await wordPressClient.Media.GetAll(useAuth: true);
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
        }
    }
}