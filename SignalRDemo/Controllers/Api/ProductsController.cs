using SignalRDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IntroToKnockoutJs.Controllers
{
    public class ProductsController : ApiController
    {
        //
        // GET: /Products/

        public IHttpActionResult Get()
        {
            var myProducts = GetProducts();

            // Sorting because I'm too lazy to do it manually. ;-P
            // Plus I needed an excuse to write some LINQ somewhere.
            return Ok(myProducts.OrderBy(p => p.Name).ToList());
        }

        private static List<Product> GetProducts()
        {
            var myProducts = new List<Product>()
            {
                new Product()
                {
                    Sku = "DOG-0001",
                    Name = "Bichon Frisé",
                    UnitPrice = 300.00M
                },
                new Product()
                {
                    Sku = "DOG-0002",
                    Name = "Poodle",
                    UnitPrice = 500.00M
                },
                new Product()
                {
                    Sku = "DOG-0003",
                    Name = "Chihuahua",
                    UnitPrice = 500.00M
                },
                new Product()
                {
                    Sku = "DOG-0004",
                    Name = "Pekingese",
                    UnitPrice = 300.00M
                },
                new Product()
                {
                    Sku = "BRD-0001",
                    Name = "Parrot",
                    UnitPrice = 100.00M
                },
                new Product()
                {
                    Sku = "BRD-0002",
                    Name = "Woodpecker",
                    UnitPrice = 100.00M
                },
                new Product()
                {
                    Sku = "REP-0001",
                    Name = "Green Iguana",
                    UnitPrice = 50.00M
                },
                new Product() 
                {
                    Sku = "REP-0002",
                    Name = "Azulejo",
                    UnitPrice = 100.00M
                },
                new Product() 
                {
                    Sku = "REP-0003",
                    Name = "Striped Lizard",
                    UnitPrice = 100.00M
                },
                new Product() 
                {
                    Sku = "REP-0004",
                    Name = "Lizard",
                    UnitPrice = 19.95M
                },
                new Product() 
                {
                    Sku = "REP-0005",
                    Name = "Garter Snake",
                    UnitPrice = 30.50M
                },
                new Product()
                {
                    Sku = "FSH-001",
                    Name = "Goldfish",
                    UnitPrice = 10.00M
                },
                new Product()
                {
                    Sku = "FSH-002",
                    Name = "Betta Fish",
                    UnitPrice = 16.50M
                },
                new Product()
                {
                    Sku = "EXO-0001",
                    Name = "Opossum",
                    UnitPrice = 50.00M
                },
                new Product()
                {
                    Sku = "EXO-0002",
                    Name = "Bat",
                    UnitPrice = 50.00M
                },
                new Product()
                {
                    Sku = "ROD-0001",
                    Name = "Guinea Pig",
                    UnitPrice = 12.00M
                },
                new Product()
                {
                    Sku = "ROD-0002",
                    Name = "Rabbit",
                    UnitPrice = 25.00M
                },
                new Product()
                {
                    Sku = "REP-0006",
                    Name = "Chameleon",
                    UnitPrice = 85.00M
                },
            };

            return myProducts;
        }

    }
}
