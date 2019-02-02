using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcWebUI.Entity
{
    public class Product
    {

        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }


        //herbir ürünün kategori tablosunda bir id ye karşılık geldiği
        public int CategoryId { get; set; }
        //her bir ürünün bir kategorisi olucak
        public Category Category { get; set; }
    }
}