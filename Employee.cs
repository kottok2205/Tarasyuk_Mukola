using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Employee
    {
        private string Surname, Name;
        private int Stag = 22;
        private string Posad = "Помічник головного інженера";
        private double Oclad, Nalog_zbor;
        private int Zp;
        private const double Nalog = 0.2;


        public Employee(string surname, string name)
        {
            this.Name = name;
            this.Surname = surname;
            Console.WriteLine("Робітник: " + surname + " " + name);
            Calculator();
        }
        //Стаж записується в місяцях
        private void CalculatorOclad()
        {
            if (Stag <= 12)
            {
                Oclad = Zp * 1.0;
                Nalog_zbor = Oclad * Nalog;
                Console.WriteLine("Оклад: " + Oclad + "\nНалоговий збір: " + Nalog_zbor);

            }
            else if (Stag >= 13 && Stag <= 18)
            {
                Oclad = Zp * 1.1;
                Nalog_zbor = Oclad * Nalog;
                Console.WriteLine("Оклад: " + Oclad + "\nНалоговий збір: " + Nalog_zbor);
            }
            else if (Stag >= 19 && Stag <= 36)
            {
                Oclad = Zp * 1.3;
                Nalog_zbor = Oclad * Nalog;
                Console.WriteLine("Оклад: " + Oclad + "\nНалоговий збір: " + Nalog_zbor);
            }
            else
            {
                Oclad = Zp * 1.5;
                Nalog_zbor = Oclad * Nalog;
                Console.WriteLine("Оклад: " + Oclad + "\nНалоговий збір: " + Nalog_zbor);
            }
        }
        public void Calculator()
        {
            //Console.Write("Введіть яку посаду ви хочете обчислити: ");
            //Posad = Console.ReadLine();
            //Stag = Convert.ToInt32(Console.ReadLine());
            if(Posad == "Інженер")
            {
                Zp = 8900;
                Console.WriteLine("Посада: " + Posad);
                CalculatorOclad();

            }
            else if(Posad == "Помічник головного інженера")
            {
                Zp = 11200;
                Console.WriteLine("Посада: " + Posad);
                CalculatorOclad();
            }
            else if(Posad == "Головний інженер")
            {
                Zp = 15000;
                Console.WriteLine("Посада: " + Posad);
                CalculatorOclad();
            }
            else
            {
                Console.WriteLine("Такої посади не їснує: ");
                Calculator();
            }
            
        }
    }
}
