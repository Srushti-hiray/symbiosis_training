using System;

public class Product
{
    public string ProductID;
    public string Name ;
    public decimal Price ;

    public Product(string productId, string name, decimal price)
    {
        ProductID = productId;
        Name = name;
        Price = price;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Product ID: "+ProductID+ " Name: "+ Name+ " Price: " +Price);
    }
}
public class Clothing : Product
{
    public string Size ;
    public string Color ;
    public string Material ;

    public Clothing(string productId, string name, decimal price, string size, string color, string material)
        : base(productId, name, price)
    {
        Size = size;
        Color = color;
        Material = material;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine(" Size: "+Size+ " Color: "+ Color+ " Material: " +Material);
    }
}
public class MensClothing : Clothing
{
    public string Fit;
    public string SleeveLength;

    public MensClothing(string productId, string name, decimal price, string size, string color, string material, string fit, string sleeveLength)
        : base(productId, name, price, size, color, material)
    {
        Fit = fit;
        SleeveLength = sleeveLength;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine(" Fit: "+ Fit + " Sleeve Length: "+ SleeveLength);
    }
}
class Program1
{
    static void Main(string[] args)
    {
        MensClothing mensShirt = new MensClothing("001", "Men's Formal Shirt", 49.99m, "L", "Blue", "Cotton", "Slim", "Long");

        mensShirt.DisplayInfo();
    }
}
