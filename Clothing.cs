public class Clothing : IProduct
{
    private string type;
    private string size;
    private double price;

    public Clothing(string type, string size, double price)
    {
        this.type = type;
        this.size = size;
        this.price = price;
    }
    public double Price => price;

    public void ShowInfo()
    {
        Console.WriteLine($"Clothing: {type}");
        Console.WriteLine($"Size: {size}");
        Console.WriteLine($"Price: KES{price:F2}");
    }
}