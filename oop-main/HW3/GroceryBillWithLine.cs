public class GroceryBillWithLine
{
    private Employee clerk;
    private List<BillLine> billLines;

    public GroceryBillWithLine(Employee clerk)
    {
        this.clerk = clerk;
        billLines = new List<BillLine>();
    }

    public void Add(BillLine bl)
    {
        billLines.Add(bl);
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (BillLine bl in billLines)
        {
            total += bl.GetLineTotal();
        }
        return total;
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Clerk: " + clerk.GetName());
        foreach (BillLine bl in billLines)
        {
            Console.WriteLine(bl);
        }
        Console.WriteLine("Total: " + GetTotal().ToString("0.00"));
    }
}
