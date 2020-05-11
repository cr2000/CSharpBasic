using ProductsG8.Entities;
using ProductsG8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsG8.Helpers
{
    public class ProductsHelper
    {
        public static List<Product> GetAllProducts()
        {

            {
                return new List<Product>()
                {

                new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
};
            }
        }

        //Add product // create method to add product to the list of products

        public static void AddProduct(List<Product> productList, string name, int price, Category category)
        {
            productList.Add(new Product()
            {
                Name = name,
                Price = price,
                Category = category
                
            });       
        }


        //Remove product // and a method to remove it - use name as parameter

        public static void RemoveProduct(List<Product> productList, string name)
        {
            var removeProduct = productList.SingleOrDefault(product => product.Name.Equals(name));
            if (removeProduct != null)
            {
                productList.Remove(removeProduct);
            }
        }

    }
}