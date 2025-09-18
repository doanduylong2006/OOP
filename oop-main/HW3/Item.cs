public class Item
{
    private string name;
    private double price;
    private double discount;

    public Item(string name, double price, double discount = 0.0)
    {
        this.name = name;
        this.price = price;
        this.discount = discount;
    }

    public string GetName() => name;
    public double GetPrice() => price;
    public double GetDiscount() => discount;
}
