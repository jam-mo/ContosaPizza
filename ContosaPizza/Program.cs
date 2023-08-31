using ContosaPizza.Data;
using ContosaPizza.Models;

using ContosaPizzaContext context = new ContosaPizzaContext(); // ensures context property is disposed off properly when done using it

//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};
//context.Products.Add(veggieSpecial);
//Product deluxeMeat = new Product()
//{
//    Name = "Deluxe Meat Pizza",
//    Price = 12.99M
//};
//context.Add(deluxeMeat);
//context.SaveChanges();

// fluent api syntax
//var products = context.Products
//    .Where(p => p.Price > 10.00M)
//    .OrderBy(p => p.Name);
// linq syntax
var veggieSpecial = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();
if (veggieSpecial is Product)
{
    //veggieSpecial.Price = 10.99M
    context.Remove(veggieSpecial);
}
context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.0M
               orderby product.Name
               select product;

foreach (Product p in products)
{
    Console.WriteLine($"ID:    {p.Id}");
    Console.WriteLine($"Name:   {p.Name}");
    Console.WriteLine($"Price:   {p.Price}");
    Console.WriteLine(new string('-', 20));
}