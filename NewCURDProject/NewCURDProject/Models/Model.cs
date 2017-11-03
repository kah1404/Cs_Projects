using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NewCURDProject.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}