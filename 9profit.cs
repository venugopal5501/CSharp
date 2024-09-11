using System;
class profit
{
    public static void Main(string[] args)
    {
        int costprice, sellingprice, total, profit;
        Console.Write("Enter CostPrice : ");
        costprice = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter SellingPrice : ");
        sellingprice = Convert.ToInt32(Console.ReadLine());
        total = sellingprice - costprice;
        profit = total + costprice;

        if (profit >= costprice)
        {
            Console.Write("The transaction is profit");
        }
        else
        {
            Console.Write("The transaction is loss");
        }

    }
}