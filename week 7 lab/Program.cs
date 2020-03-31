using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_7_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, state;
            int quantity;
            double price, sales, tax;
            Console.WriteLine("Please enter your name: ");
            name =Console.ReadLine();

            Console.WriteLine("Please enter the number of items sold: ");
            quantity =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the unit price of the item: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your state (NJ) for New Jersey, (FL) for Florida, (NY) for New York: ");
            state =Console.ReadLine().ToUpper();

            
            sales = computeTotal(quantity, price);
            tax = computeTax(sales, state);
            
            Console.WriteLine("The total sales for " + name + " are: " + sales.ToString("C"));
            Console.WriteLine("The total with tax is: "+ Math.Round(tax,2).ToString("C"));
            Console.ReadLine();
        }
        public static double computeTotal(int quantity, double price)
        {
            return (quantity * price);
        }
        public static double computeTax(double sales, string state)
        {
            double taxAmount = 0;
            if (state == "NJ")
            {
                taxAmount = .07;
            }
            else if (state == "FL")
            {
                taxAmount = .06;
            }
            else if (state == "NY")
            {
                taxAmount = .04;
            }
            return (sales +(sales* taxAmount));
        }

    }
}
