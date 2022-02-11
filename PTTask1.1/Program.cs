using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTask1._1
{
    class Program
    {
        static void Main(string[] args)
        {
        HomePage:
            Console.WriteLine("Please select a currency type: \n1-USD\n2-EUR\n3-TL");
            int selected_currency = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount");
            double amount_entered = double.Parse(Console.ReadLine());
            switch (selected_currency)
            {
                case 1:
                    ValutaExchanger.Exchange(CurrencyType.USD, amount_entered);
                    break;
                case 2:
                    ValutaExchanger.Exchange(CurrencyType.EUR, amount_entered);
                    break;
                case 3:
                    ValutaExchanger.Exchange(CurrencyType.TL, amount_entered);
                    break;
            }
            Console.WriteLine("------------------------------------------------");
            goto HomePage;
            Console.ReadLine();

        }
    }
}
