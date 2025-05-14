using ProductFactory;

Console.WriteLine("Creating Clothing Product:");
var clothing = ProductFactory.ProductFactory.CreateProduct<Clothing>("T-Shirt", "Medium", 1199.99, "Comfortable Cotton T-shirt");
Console.WriteLine();

Console.WriteLine("Creating Furniture Product:");
var furniture = ProductFactory.ProductFactory.CreateProduct<Furniture>("Table", "Wood", 10999.99, "Dining Table made of wood");
Console.WriteLine();

bool isFurnitureMoreExpensive = furniture.IsMoreExpensiveThan(clothing);
Console.WriteLine($"Is Furniture more expensive than Clothing? {isFurnitureMoreExpensive}");