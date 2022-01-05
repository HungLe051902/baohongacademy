using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoHongAcademy.Domain.Entities;

namespace BaoHongAcademy.Infrastructure
{
    public class BaoHongContext : DbContext
    {
        public BaoHongContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
