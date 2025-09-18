class Program
{
    static void Main(string[] args)
    {
        Employee e = new Employee("Alice");
        Item candy = new Item("Candy Bar", 1.35, 0.25);
        Item milk = new Item("Milk", 2.00);
        Item bread = new Item("Bread", 1.50, 0.10);

        Console.WriteLine("===== Normal Bill =====");
        GroceryBill gb = new GroceryBill(e);
        gb.Add(candy);
        gb.Add(milk);
        gb.Add(bread);
        gb.PrintReceipt();

        Console.WriteLine("\n===== Discount Bill (Preferred) =====");
        DiscountBill db = new DiscountBill(e, true);
        db.Add(candy);
        db.Add(milk);
        db.Add(bread);
        db.PrintReceipt();

        Console.WriteLine("\n===== Bill with BillLine =====");
        GroceryBillWithLine gbl = new GroceryBillWithLine(e);
        gbl.Add(new BillLine(candy, 3));
        gbl.Add(new BillLine(milk, 2));
        gbl.Add(new BillLine(bread, 5));
        gbl.PrintReceipt();
    }
}
