using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Завдання 1
            Console.WriteLine("Завдання 1");
            Address address = new Address { index = "05964", country = "Україна", city = "Київ", street = "Академіка Єфремова", house = 26, apartment = 58 };
            Console.WriteLine($"Індекс: {address.index},\nКраїна: {address.country},\nМісто: {address.city}, \nВулиця: {address.street},\nДім: {address.house},\nКвартира: {address.apartment}");
            // Завдання 2
            Console.WriteLine("Завдання 2");
            Console.Write("Введіть першу сторону прямокутника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть другу сторону прямокутника: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine("Area: {0}, Perimeter: {1}", rectangle.Area, rectangle.Perimeter);
            // Задание 3
            Console.WriteLine("Завдання 3");

            // Завдання 4
            Console.WriteLine("Завдання 4");

            // Завдання 5
            Console.WriteLine("Завдання 5");
            User user = new User();
            user.UserInfo();
            // Завдання 6
            Console.WriteLine("Завдання 6");
            Converter converter = new Converter(28.58, 33.29, 0.36);
            // Завдання 7
            Console.WriteLine("Завдання 7");
            Employee employee = new Employee("Іванов", "Евгеній");
            // Завдання 8
            Console.WriteLine("Завдання 8");

        }
    }
}
