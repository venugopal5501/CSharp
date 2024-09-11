using System;
class electricity
{
    public static void Main(string[] args)
    {
        int id, unit;
        double total, surcharge, fin;
        string name;
        Console.Write("Enter CustomerId : ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name : ");
        name = Console.ReadLine();
        Console.Write("Enter Consumed Unit : ");
        unit = Convert.ToInt32(Console.ReadLine());
        if (unit <= 199)
        {
            total = unit * 1.20;
            if (total > 400)
            {
                surcharge = total * 0.15 + total;
                Console.Write("The Amount to pay : Rs " + surcharge);

            }
            else if (total < 100)
            {
                Console.Write("You don't need to pay");

            }
            else
            {
                Console.Write("The Amount to pay : Rs " + total);
            }

        }
        else if (unit >= 200 && unit <= 400)
        {
            total = unit * 1.50;
            if (total > 400)
            {
                surcharge = total * 0.15 + total;
                Console.Write("The Amount to pay : Rs " + surcharge);

            }
            else if (total < 100)
            {
                Console.Write("You don't need to pay");

            }
            else
            {
                Console.Write("The Amount to pay : Rs " + total);
            }


        }
        else if (unit >= 400 && unit <= 600)
        {
            total = unit * 1.80;
            if (total > 400)
            {
                surcharge = total * 0.15 + total;
                Console.Write("The Amount to pay : Rs " + surcharge);

            }
            else if (total < 100)
            {
                Console.Write("You don't need to pay");

            }
            else
            {
                Console.Write("The Amount to pay : Rs " + total);
            }


        }
        else if (unit >= 600)
        {
            total = unit * 2.00;
            if (total > 400)
            {
                surcharge = total * 0.15;
                fin = surcharge + total;
                Console.Write("The Amount to pay : Rs " + fin);

            }
            else if (total < 100)
            {
                Console.Write("You don't need to pay");

            }
            else
            {
                Console.Write("The Amount to pay : Rs " + total);
            }


        }

    }
}