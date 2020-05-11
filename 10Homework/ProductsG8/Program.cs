using ProductsG8.Entities;
using ProductsG8.Enums;
using ProductsG8.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProductsG8
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = ProductsHelper.GetAllProducts();
            Console.WriteLine("All the products in the store are:");
            products.ForEach(produt => Console.WriteLine(produt.Name));

            //Search products by category // return all products from given category
            var allByCategory = products.Where(product => product.Category.Equals(Category.ItEquipment)).ToList();
            Console.WriteLine("\n\nAll the products in category ITEQuip are:");
            allByCategory.ForEach(product => Console.WriteLine(product.Name));


            //Filter products by price range(from min to max) // return all products that fall in the given price range
            var productsByPrice = products.OrderBy(product => product.Price).ToList();
            Console.WriteLine("\n\nOrdered by price:");
            productsByPrice.ForEach(product => Console.WriteLine(product.Name));

            //Find products by part of name // get all products that consist the part in their names
            var partOfNameSearch = products.Where(product => product.Name.ToLower().Contains("tra")).ToList();
            Console.WriteLine("\n\nOrdered by part of name:");
            partOfNameSearch.ForEach(product => Console.WriteLine(product.Name));

            //Get only products ids // return only the ids of the products
            Console.WriteLine("\n\nList of all IDs of the products:");
            products.ForEach(product => Console.WriteLine(product.generateID()));


            //Get product price // get the price of the product - give the id as parameter
            var priceProducts = products.Select(product => product.Price).ToList();
            Console.WriteLine("\n\nList of all prices of the products:");
            priceProducts.ForEach(product => Console.WriteLine(product));

            //Get cheapest product // return the cheapest product
            var lowestPrice = products.Min(product => product.Price);
            var cheapestProduct = products.SingleOrDefault(product => product.Price.Equals(lowestPrice));
            Console.WriteLine("\n\nThe cheapest product is:");
            Console.WriteLine(cheapestProduct.Name);


            //vtor obid
            var lowest = products.OrderBy(product => product.Price).Take(1).ToList();
            foreach (var item in lowest)
            {
                Console.WriteLine(item.Name);
            }

            //Get most expensive product // return the most expensive one
            var highestPrice = products.Max(product => product.Price);
            var priciestProduct = products.SingleOrDefault(product => product.Price.Equals(highestPrice));
            Console.WriteLine("\n\nThe most expencive product is:");
            Console.WriteLine(priciestProduct.Name);


            //Add product // create method to add product to the list of products
            ProductsHelper.AddProduct(products, "RAM", 3500, Category.ItEquipment);
            Console.WriteLine("\n\nWith added product:");
            products.ForEach(product => Console.WriteLine(product.Name));

            //Remove product // and a method to remove it - use id as parameter
            ProductsHelper.RemoveProduct(products, "RAM");
            Console.WriteLine("\n\nWith removed product:");
            products.ForEach(product => Console.WriteLine(product.Name));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\bThis is the end");
            Console.ReadLine();
        }
    }
}
