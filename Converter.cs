using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Converter
    {
        /*private const double USD_buy = 28.53;
        private const double USD_sale = 28.74;
        private const double EUR_buy = 33.10;
        private const double EUR_sale = 33.50;
        private const double RUB_buy = 0.34;
        private const double RUB_sale = 0.37;
        private const double USD = 28.58;
        private const double EUR = 33.29;
        private const double RUB = 0.36;*/

        /*public Converter(double usd, double eur, double rub)
        {
            Console.Write("Введіть яку суму ви хочете конвертувати(грн): ");
            double UAH = Convert.ToDouble(Console.ReadLine());
            Console.Write("Яку валюту ви хотіли б придбати(U = USD, E = EUR, R = RUB): ");
            string val = Console.ReadLine();
            if (val == "U")
            {
                Console.WriteLine(UAH + " гривень = " + (UAH / usd) + " долларів");
            }
            else if (val == "E")
            {
                Console.WriteLine(UAH + " гривень = " + (UAH / eur) + " євро");
            }
            else if (val == "R")
            {
                Console.WriteLine(UAH + " гривень = " + (UAH / rub) + " рублів");
            }
            else
            {
                Console.WriteLine("Введіть валюту буквою як показано в душках");

            }
            Console.Write("Хотіли б ви поміняти валюту на гривню?(Y - Yes, N - No): ");
            string val_sale = Console.ReadLine();
            if(val_sale == "Y")
            {
                Console.Write("Введіть яку суму ви хочете конвертувати: ");
                double valuta = Convert.ToDouble(Console.ReadLine());
                Console.Write("Яку валюту ви хотіли б продати(U = USD, E = EUR, R = RUB): ");
                string valut = Console.ReadLine();
                if (valut == "U")
                {
                    Console.WriteLine(valuta + " долларів = " + (valuta * usd) + " гривень");
                }
                else if (valut == "E")
                {
                    Console.WriteLine(valuta + " євро = " + (valuta * eur) + " гривень");
                }
                else if (valut == "R")
                {
                    Console.WriteLine(valuta + " рублів = " + (valuta * rub) + " гривень");
                }
                else
                {
                    Console.WriteLine("Введіть валюту буквою як показано в душках");

                }
            }
            else if (val_sale == "N")
            {

            }
            else
            {
                Console.WriteLine("Введіть \"Y\" або \"N\"");
            }
        }*/
        public Converter(double usd, double eur, double rub)
        {
            Convert_many(usd, eur, rub);
        }
        
        public void Convert_many(double USD, double EUR, double RUB)
        {
            Console.Write("Введіть яку суму ви хочете конвертувати(грн): ");
            double UAH = Convert.ToDouble(Console.ReadLine());
            Console.Write("Яку валюту ви хотілиб придбати(U = USD, E = EUR, R = RUB): ");
            string val = Console.ReadLine();
            if(val == "U" || val == "u")
            {
                Console.WriteLine(UAH + " гривень = " + (UAH * USD) + " долларів");
            }
            else if(val == "E" || val == "e")
            {
                Console.WriteLine(UAH + " гривень = " + (UAH * EUR) + " євро");
            }
            else if(val == "R" || val == "r")
            {
                Console.WriteLine(UAH + " гривень = " + (UAH * RUB) + " рублів");
            }
            else
            {
                Console.WriteLine("Введіть валюту буквою як показано в душках");
                Convert_many(USD, EUR, RUB);
            }
            Console.Write("Хотіли б ви поміняти валюту на гривню?(Y - Yes, N - No): ");
            string val_sale = Console.ReadLine();
            if (val_sale == "Y" || val_sale == "y")
            {
                Console.Write("Введіть яку суму ви хочете конвертувати: ");
                double valuta = Convert.ToDouble(Console.ReadLine());
                Console.Write("Яку валюту ви хотіли б продати(U = USD, E = EUR, R = RUB): ");
                string valut = Console.ReadLine();
                if (valut == "U")
                {
                    Console.WriteLine(valuta + " долларів = " + (valuta * USD) + " гривень");
                }
                else if (valut == "E")
                {
                    Console.WriteLine(valuta + " євро = " + (valuta * EUR) + " гривень");
                }
                else if (valut == "R")
                {
                    Console.WriteLine(valuta + " рублів = " + (valuta * RUB) + " гривень");
                }
                else
                {
                    Console.WriteLine("Введіть валюту буквою як показано в душках");

                }
            }
            else if (val_sale == "N" || val_sale == "n")
            {

            }
            else
            {
                Console.WriteLine("Введіть \"Y\" або \"N\"");
                Convert_many(USD, EUR, RUB);
            }
        }

    }
}
