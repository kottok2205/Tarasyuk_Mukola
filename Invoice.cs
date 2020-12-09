using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Invoice
    {
        private int account = 372;//рахунок
        private string customer = "Коваль Максим";//замовник
        private string provider = "Молотова Ірина";//продавець
        private string article;//артикуль товару
        private int quantity;//кількість
        public void SDN()
        {
            Console.Write("Введіть артиклуль бажаємого товару: ");
            article = Console.ReadLine();
            Console.Write("Введіть кількість бажаємого товару: ");
            quantity = Convert.ToInt32(Console.ReadLine());


        }
        
    }
}
