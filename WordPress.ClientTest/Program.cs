using System;
using System.Linq;
using System.Threading.Tasks;
using WordPress.Client;

namespace WordPress.ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                Test().GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }

        static async Task Test()
        {
            var wordPressClient = new WordPressClient("http://localhost/wp-json/");
            await wordPressClient.RequestJWToken("admin", "admin");

            var categories = await wordPressClient.Categories.GetAll();
            Console.WriteLine($"{nameof(categories)}:{categories.Count()}");

            //await wordPressClient.Categories.Create(new Client.Models.Category { Name = "接口创建的分类", Description = "通过接口创建的分类" });
            var posts = await wordPressClient.Posts.GetAll();
            Console.WriteLine($"{nameof(posts)}:{posts.Count()}");

            var medias = await wordPressClient.Media.GetAll();
            Console.WriteLine($"{nameof(medias)}:{medias.Count()}");

            var comments = await wordPressClient.Comments.GetAll();
            Console.WriteLine($"{nameof(comments)}:{comments.Count()}");

            var pages = await wordPressClient.Pages.GetAll();
            Console.WriteLine($"{nameof(pages)}:{pages.Count()}");

            var tags = await wordPressClient.Tags.GetAll();
            Console.WriteLine($"{nameof(tags)}:{tags.Count()}");

            var taxonomies = await wordPressClient.Taxonomies.GetAll();
            Console.WriteLine($"{nameof(taxonomies)}:{taxonomies.Count()}");

            var users = await wordPressClient.Users.GetAll();
            Console.WriteLine($"{nameof(users)}:{users.Count()}");

            var postStatuses = await wordPressClient.PostStatuses.GetAll();
            Console.WriteLine($"{nameof(postStatuses)}:{postStatuses.Count()}");

            var postTypes = await wordPressClient.PostTypes.GetAll();
            Console.WriteLine($"{nameof(postTypes)}:{postTypes.Count()}");
        }
    }
}