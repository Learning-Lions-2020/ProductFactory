public class Clothing : IProduct
{
    private string type;
    private string size;
    private double price;
    private string description;

    public Clothing(string type, string size, double price, string description)
    {
        this.type = type;
        this.size = size;
        this.price = price;
        this.description = description;
    }
    public double Price => price;
    public string Description => description;

    public void ShowInfo()
    {
        Console.WriteLine($"Clothing: {type}");
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Price: KES{price:F2}");
    }
}