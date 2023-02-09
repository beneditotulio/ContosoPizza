using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

var vaggieSpecial = context.Products
    .Where(p=> p.Name == "Vaggie Spcial Pizza")
    .FirstOrDefault();

if (vaggieSpecial is Product)
{
    context.Remove(vaggieSpecial);
}

context.SaveChanges();

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