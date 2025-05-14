public class Furniture : IProduct
{
    private string item;
    private string material;
    private double price;

    public Furniture(string item, string material, double price)
    {
        this.item = item;
        this.material = material;
        this.price = price;
    }
    public double Price => price;

    public void ShowInfo()
    {
        Console.WriteLine($"Furniture: {item}");
        Console.WriteLine($"Material: {material}");
        Console.WriteLine($"Price: KES{price:F2}");
    }
}