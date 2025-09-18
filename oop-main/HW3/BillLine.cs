public class BillLine
{
    private Item item;
    private int quantity;

    public BillLine(Item item, int quantity)
    {
        this.item = item;
        this.quantity = quantity;
    }

    public void SetQuantity(int q) => quantity = q;
    public int GetQuantity() => quantity;

    public void SetItem(Item i) => item = i;
    public Item GetItem() => item;

    public double GetLineTotal()
    {
        return item.GetPrice() * quantity;
    }

    public double GetLineDiscountedTotal()
    {
        return (item.GetPrice() - item.GetDiscount()) * quantity;
    }

    public override string ToString()
    {
        return $"{item.GetName()} x {quantity} - Unit Price: {item.GetPrice():0.00}, Discount: {item.GetDiscount():0.00}";
    }
}
