using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatabaseConnect.Master;

namespace DatabaseConnect
{
    public class Database : DbContext 
    {
        private readonly object _saveLock = new object();

        public DbSet<Users> Users { get; set; }
        public DbSet<PartMaster> PartMaster { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}
