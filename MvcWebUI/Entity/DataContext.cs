using Microsoft.AspNet.Identity.EntityFramework;
using MvcWebUI.identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebUI.Entity
{
    public class DataContext : DbContext
    {
       
        //connection string yazmamız gerekli
        public DataContext() : base("dataConnection")
        {
            //datainitializer'i aktive ediyoruz
        }
 //bu context in kullandığı entity'leri eklememiz gerekiyo
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

    }
}