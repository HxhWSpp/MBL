using MBL.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MBL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserReadBook>().HasKey(urb => new { urb.BookId, urb.UserId });

            modelBuilder.Entity<UserReadBook>()
                .HasOne<AppUser>(urb => urb.User)
                .WithMany(u => u.ReadBooks)
                .HasForeignKey(urb => urb.UserId);


            modelBuilder.Entity<UserReadBook>()
                .HasOne<Book>(urb => urb.Book)
                .WithMany(b => b.ReadBooks)
                .HasForeignKey(urb => urb.BookId);


            modelBuilder.Entity<UserWantedBook>().HasKey(urb => new { urb.BookId, urb.UserId });

            modelBuilder.Entity<UserWantedBook>()
                .HasOne<AppUser>(urb => urb.User)
                .WithMany(u => u.WantedBooks)
                .HasForeignKey(urb => urb.UserId);


            modelBuilder.Entity<UserWantedBook>()
                .HasOne<Book>(urb => urb.Book)
                .WithMany(b => b.WantedBooks)
                .HasForeignKey(urb => urb.BookId);

        }


        public DbSet<Book> Books { get; set; }
        public DbSet<UserReadBook> UserReadBooks { get; set; }
        public DbSet<UserWantedBook> UserWantedBooks { get; set; }

        //public DbSet<UserList> UserList { get; set; }
    }
}