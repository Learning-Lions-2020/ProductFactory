using ProductFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating Clothing Product:");
        var clothing = ProductFactory.ProductFactory.CreateProduct<Clothing>("T-Shirt", "Medium", 1999.99);
        Console.WriteLine();

        Console.WriteLine("Creating Furniture Product:");
        var furniture = ProductFactory.ProductFactory.CreateProduct<Furniture>("Table", "Wood", 10199.99);
        Console.WriteLine();

        bool isFurnitureMoreExpensive = furniture.IsMoreExpensiveThan(clothing);
        Console.WriteLine($"Is Furniture more expensive than Clothing? {isFurnitureMoreExpensive}");
    }
}