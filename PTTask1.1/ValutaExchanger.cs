using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PTTask1._1
{
    public static class ValutaExchanger
    {
        public static void Exchange(CurrencyType currency, double sum)
        {
            double result1;
            double result2;
            Dictionary<CurrencyType, double> Currencies = new Dictionary<CurrencyType, double>();
            if (currency == CurrencyType.EUR)
            {
                Currencies.Add(CurrencyType.USD, result1 = sum * 1.1458);
                Currencies.Add(CurrencyType.TL, result2 = sum * 15.4838);
                Console.WriteLine($"USD equivalent {result1}\nTL equivalent {result2}");
            }
            if (currency == CurrencyType.USD)
            {
                Currencies.Add(CurrencyType.EUR, result1 = sum * 0.8727);
                Currencies.Add(CurrencyType.TL, result2 = sum * 13.4642);
                Console.WriteLine($"EUR equivalent {result1}\nTL equivalent {result2}");
            }
            if (currency == CurrencyType.TL)
            {
                Currencies.Add(CurrencyType.EUR, result1 = sum * 0.0646);
                Currencies.Add(CurrencyType.USD, result2 = sum * 0.0743);
                Console.WriteLine($"EUR equivalent {result1}\nUSD equivalent {result2}");
            }
        }
    }
    public enum CurrencyType
    {
        USD,
        EUR,
        TL
    }
}
