public class DiscountBill : GroceryBill
{
    private bool preferred;

    public DiscountBill(Employee clerk, bool preferred) : base(clerk)
    {
        this.preferred = preferred;
    }

    public override double GetTotal()
    {
        if (!preferred) return base.GetTotal();

        double total = 0;
        foreach (Item i in items)
        {
            total += (i.GetPrice() - i.GetDiscount());
        }
        return total;
    }

    public int GetDiscountCount()
    {
        if (!preferred) return 0;

        int count = 0;
        foreach (Item i in items)
        {
            if (i.GetDiscount() > 0) count++;
        }
        return count;
    }

    public double GetDiscountAmount()
    {
        if (!preferred) return 0.0;

        double discount = 0;
        foreach (Item i in items)
        {
            discount += i.GetDiscount();
        }
        return discount;
    }

    public double GetDiscountPercent()
    {
        if (!preferred) return 0.0;

        double original = base.GetTotal();
        return (GetDiscountAmount() / original) * 100;
    }

    public override void PrintReceipt()
    {
        base.PrintReceipt();
        if (preferred)
        {
            Console.WriteLine($"Discount Count: {GetDiscountCount()}");
            Console.WriteLine($"Total Discount: {GetDiscountAmount():0.00}");
            Console.WriteLine($"Discount Percent: {GetDiscountPercent():0.00}%");
        }
    }
}
