using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DatabaseConnect
{
    public class Database : DbContext 
    {
        public DbSet<Users> Users { get; set; }
    }
}
