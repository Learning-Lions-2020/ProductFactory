using ProductFactory;

// Defined method to execute when a product is created
ProductCreated<IProduct> onProductCreated = (product) =>
{
    Console.WriteLine("Custom Product Information:");
    product.ShowInfo();
    Console.WriteLine($"Description has {product.Description.CountVowels()} vowels.");
};

// ProductFactory instance with the delegate
var factory = new ProductFactory.ProductFactory(onProductCreated);

Console.WriteLine("Creating Clothing Product:");
var clothing = factory.CreateProduct<Clothing>("T-Shirt", "Medium", 1199.99, "A comfortable cotton T-shirt with a classic fit");
Console.WriteLine();

Console.WriteLine("Creating Furniture Product:");
var furniture = factory.CreateProduct<Furniture>("Table", "Wood", 10999.99, "A sturdy oak dining table for family gatherings");
Console.WriteLine();

bool isFurnitureMoreExpensive = furniture.IsMoreExpensiveThan(clothing);
Console.WriteLine($"Is Furniture more expensive than Clothing? {isFurnitureMoreExpensive}");