using ProductFactory;

var factory = new ProductFactory.ProductFactory();


// Define the method to execute when a product is created
void OnProductCreated(object sender, ProductEventArgs e)
{
    Console.WriteLine("Custom Product Information:");
    e.Product.ShowInfo();
    Console.WriteLine($"Description has {e.Product.Description.CountVowels()} vowels.");
}

//
factory.productCreatedEvent += OnProductCreated;

Console.WriteLine("Creating Clothing Product:");
var clothing = factory.CreateProduct<Clothing>("T-Shirt", "Medium", 1199.99, "A comfortable cotton T-shirt with a classic fit");
Console.WriteLine();

Console.WriteLine("Creating Furniture Product:");
var furniture = factory.CreateProduct<Furniture>("Table", "Wood", 10999.99, "A sturdy oak dining table for family gatherings");
Console.WriteLine();

bool isFurnitureMoreExpensive = furniture.IsMoreExpensiveThan(clothing);
Console.WriteLine($"Is Furniture more expensive than Clothing? {isFurnitureMoreExpensive}");