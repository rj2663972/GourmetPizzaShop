using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GourmetPizza.Models;

namespace GourmetPizza.Models
{
    public class MvcPizzaContext : DbContext
    {
        public MvcPizzaContext(DbContextOptions<MvcPizzaContext> options) : base(options)
        { }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<GourmetPizza.Models.Customer> Customer { get; set; }
    }
}
