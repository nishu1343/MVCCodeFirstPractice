using System;
using Code_First_Nishu.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Nishu.Repository
{
    public class CDBContext : DbContext
    {
        public CDBContext() : base("stringDBContext")
        {

        }
        public DbSet<MyFirstTable> MyFirstTable { get; set; }
    }
}
