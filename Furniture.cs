using System;

public class Furniture : IProduct
{
    private string item;
    private string material;
    private double price;
    private string description;

    public Furniture(string item, string material, double price, string description)
    {
        this.item = item;
        this.material = material;
        this.price = price;
        this.description = description;
    }
    public double Price => price;
    public string Description => description;

    public void ShowInfo()
    {
        Console.WriteLine($"Furniture: {item}");
        Console.WriteLine($"Material: {material}");
        Console.WriteLine($"Price: KES{price:F2}");
    }
}