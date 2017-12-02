using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sales_Report
{
    class Sales
    {
        public string town { get; set; }
        public string product { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }

        public double TotalPrice()
        {
            return price * quantity;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Sales> sales=new List<Sales>();

            for (int i = 0; i < num; i++)
            {
                string[] saleParameters = Console.ReadLine().Split();

                Sales sale = new Sales()
                {
                    town = saleParameters[0],
                    product = saleParameters[1],
                    price = double.Parse(saleParameters[2]),
                    quantity = double.Parse(saleParameters[3])
                };
                sales.Add(sale);
            }

            List<string> towns = sales.Select(x => x.town).Distinct().OrderBy(x => x).ToList();

            foreach (var town in towns)
            {
                double townPrice = sales.Where(sale => sale.town == town).Select(sale => sale.TotalPrice()).Sum();

                Console.WriteLine($"{town} -> {Math.Round(townPrice, 2):F2}");
            }

        }
    }
}
