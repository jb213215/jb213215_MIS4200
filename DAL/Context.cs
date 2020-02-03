using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace jb213215_MIS4200.DAL
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        { 
        
        }

        public System.Data.Entity.DbSet<jb213215_MIS4200.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<jb213215_MIS4200.Models.Order> Orders { get; set; }
    }
}