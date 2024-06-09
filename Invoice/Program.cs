﻿namespace Invoice;
class Program
{
    static void Main(string[] args)
    {
        Invoice inv = new Invoice("678904", "Alex", "Foxtrot");
        inv.Article = "USB-hab";
        inv.Quantity = 6;
        inv.Price = 30;
        decimal cost = inv.CostCalculation(true);
        Console.WriteLine($"Total cost: {cost}");
    }
}
