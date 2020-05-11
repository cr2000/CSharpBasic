using ProductsG8.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsG8.Entities
{
    public class Product
    {

        public Product()
        {

        }
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        


    }
}
