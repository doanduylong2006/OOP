using System;
using System.Collections.Generic;

public class GroceryBill
{
    protected Employee clerk;
    protected List<Item> items;

    public GroceryBill(Employee clerk)
    {
        this.clerk = clerk;
        this.items = new List<Item>();
    }

    public void Add(Item i)
    {
        items.Add(i);
    }

    public virtual double GetTotal()
    {
        double total = 0;
        foreach (Item i in items)
        {
            total += i.GetPrice();
        }
        return total;
    }

    public virtual void PrintReceipt()
    {
        Console.WriteLine("Clerk: " + clerk.GetName());
        foreach (Item i in items)
        {
            Console.WriteLine($"{i.GetName()} - Price: {i.GetPrice():0.00}");
        }
        Console.WriteLine("Total: " + GetTotal().ToString("0.00"));
    }
}
