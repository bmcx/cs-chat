using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApi.Models;

namespace ChatApi.Models
{
    public class DBInteractor : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source = ChatApi.db;");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Chat> Chat { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User() { Id = 1, FirstName = "John", LastName = "Doe", Email = "jdoe123@gmail.com", Image = "https://randomuser.me/api/portraits/men/72.jpg", Phone = "+94711526501", Password = "1234" },
            new User() { Id = 2, FirstName = "Jane", LastName = "Doe", Email = "janed123@gmail.com", Image = "https://randomuser.me/api/portraits/women/72.jpg", Phone = "+94711526501", Password = "1234" },
            new User() { Id = 3, FirstName = "abc", LastName = "xyz", Email = "alphabet@gmail.com", Image = "https://randomuser.me/api/portraits/men/52.jpg", Phone = "+94711526501", Password = "1234" }
            );
            modelBuilder.Entity<Message>().HasData(
            new Message() { Id = 1, Body = "hello", ChatId = 1, SenderId = 1, TimeStamp = DateTime.Now, Type = 1  }
            );
            modelBuilder.Entity<Chat>().HasData(
            new Chat() { Id = 1, FriendId = 2, OwnerId = 1, LastMessage = "hello", LastMessageType = 1, LastMessageAt = DateTime.Now, LastMessageBy = 1}
            );
        }
    }
}
