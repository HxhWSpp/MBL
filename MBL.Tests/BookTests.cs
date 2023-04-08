using MBL.Data;
using MBL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MBL.Tests
{
    public class Tests
    {
        private ApplicationDbContext _context;
        [SetUp]
        public void Setup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot _configuration = builder.Build();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            options.UseLazyLoadingProxies();
            _context = new ApplicationDbContext(options: options.Options);
               
        }

        [Test]
        public void TestForAddingBook()
        {
            var book = new Book()
            {

                Author = "Test",
                ImagePath = "Test.jpg",
                Language = "Test",
                Link = "Test",
                Pages = "1",
                Title = "Test",
                Description = "Test",
                Genre = "Test"
            };
            _context.Books.Add(book);
            int result = _context.SaveChanges();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestForDeletingBook()
        {
            var book = new Book()
            {

                Author = "TestDelete",
                ImagePath = "TestDelete.jpg",
                Language = "TestDelete",
                Link = "TestDelete",
                Pages = "1",
                Title = "TestDelete",
                Description = "TestDelete",
                Genre = "TestDelete"
            };
            _context.Books.Add(book);
            int result = _context.SaveChanges();

            Assert.AreEqual(1, result);
        }
       
    }
}