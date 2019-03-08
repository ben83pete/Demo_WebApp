using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models {
    public class SalesDb : DbContext {

        public DbSet<Product> Products { get; set; }

        public static implicit operator Database(SalesDb v) {
            throw new NotImplementedException();
        }
    }
}