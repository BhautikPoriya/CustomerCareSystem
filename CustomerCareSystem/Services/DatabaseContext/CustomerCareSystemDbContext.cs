using CustomerCareSystem.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Type = CustomerCareSystem.Models.Domain.Type;

namespace CustomerCareSystem.Services.DatabaseContext
{
    public class CustomerCareSystemDbContext : DbContext
    {

        public CustomerCareSystemDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Token> Token { get; set; }

        public DbSet<ExecutiveLogin> ExecutiveLogin { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExecutiveLogin>().HasData(
                new ExecutiveLogin { Id = 1, User = "general@executive.com", Password = "general123", QueryType = Type.General },
                new ExecutiveLogin { Id = 2, User = "repair@executive.com", Password = "repair123", QueryType = Type.Repair },
                new ExecutiveLogin { Id = 3, User = "return@executive.com", Password = "return123", QueryType = Type.Return },
                new ExecutiveLogin { Id = 4, User = "inquiry@executive.com", Password = "inquiry123", QueryType = Type.NewProductInquiry }
            );
        }
    }
}
