using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcWebUI.Entity
{
    public class Category
    {

        public int Id { get; set; }
        [DisplayName("Kategori Adi")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        //her bir kategorinin birden fazla ürünü olucak
        public List<Product> Products { get; set; }
    }
}