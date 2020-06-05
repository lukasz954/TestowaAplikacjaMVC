using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowy.Domain;

namespace DbService.DbService
{
    public class EFDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
