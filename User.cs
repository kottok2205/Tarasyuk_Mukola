using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class User
    {
        private string login, name, surname;
        private int age;
        private string date;

        
        public void UserInfo()
        {
            Console.Write("Введіть свій логін: ");
            login = Console.ReadLine();

            Console.Write("Введіть своє ім'я: ");
            name = Console.ReadLine();

            Console.Write("Введіть своє прізвище: ");
            surname = Console.ReadLine();

            Console.Write("Введіть свій вік: ");
            age = Convert.ToInt32(Console.ReadLine());

            date = Convert.ToString(DateTime.Now);

            Console.WriteLine($"Логін: {login}\nІм'я: {name}\nПрізвище: {surname}\nВік: {age}\nДата запрвнення анкети: {date}");
        }
    }
}
