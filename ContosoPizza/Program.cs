using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

//var products = context.Products
//    .Where(p => p.Price > 10.00M)
//    .OrderBy(p => p.Name);
var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;

foreach (Product item in products)
{
    Console.WriteLine($"Id:     {item.Id}");
    Console.WriteLine($"Name:     {item.Name}");
    Console.WriteLine($"Price:     {item.Price}");
    Console.WriteLine(new string('-', 20));
}