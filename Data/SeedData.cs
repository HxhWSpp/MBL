using MBL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MBL.Data
{
    public class SeedData
    {
        public static void SeedBooks(IServiceProvider service)
        {

            using (var context = new ApplicationDbContext(service.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                var env = service.GetRequiredService<IWebHostEnvironment>();
                var path = Path.Combine(env.WebRootPath, "files", "Books.json");
                var jsonString = System.IO.File.ReadAllText(path);
                if (jsonString != null)
                {
#pragma warning disable CS8600
                    List<Book> item = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(jsonString);
#pragma warning disable CS8600
                    if (item != null)
                    {
                        context.Books.AddRange(item);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
