using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp // Lesson #1 by Aleksandr K
{
    class Program
    {
        static void Main(string[] args)
        {
                Form_A();       // Конкатенация
                Form_B();       // Форматирование
                Form_C();       // Со знаком $

                BMI();          // ИМТ

                Distance();     // Расстояние между 2мя точками       

                Swap();         // Обмен значений 2х переменных

                Data();         // Информация выводится по центру
        }

        private static void Data()
        {
            Console.WriteLine("Расскажите немного о себе:");

            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Ваш город: ");
            string city = Console.ReadLine();

            string output = $"Ваше имя: {name} , Ваша фамилия: {surname} , Ваш город: {city}";

            int centerX = (Console.WindowWidth / 2) - (output.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(output);

            Console.ReadKey();
        }

        private static void Swap()
        {
            Console.WriteLine("Давайте поменяем местами значения переменных a и b :");

            Console.Write("Введите значение переменной a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение переменной b: ");
            int b = int.Parse(Console.ReadLine());
            
            int t;
            t = a;
            a = b;
            b = t;


            Console.WriteLine($"a: {a} , b: {b}");
            Console.ReadKey();
        }

        private static void Distance()
        {
            Console.WriteLine("Давайте посчитаем расстояние между точками :");

            Console.Write("Введите координаты х1: ");
            double x1 = double.Parse((Console.ReadLine()));

            Console.Write("Введите координаты y1: ");
            double y1 = double.Parse((Console.ReadLine()));

            Console.Write("Введите координаты х2: ");
            double x2 = double.Parse((Console.ReadLine()));

            Console.Write("Введите координаты y2: ");
            double y2 = double.Parse((Console.ReadLine()));

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между точками будет равно : {r:0.00}");

            Console.ReadKey();
        }
        
        private static void BMI()
        {
            Console.WriteLine("Добро пожаловать в программу по расчету ИМТ (индекс массы тела) :");

            Console.Write("Введите ваш рост в метрах: ");
            double h = double.Parse((Console.ReadLine()));

            Console.Write("Введите ваш вес в килограммах: ");
            double m = double.Parse((Console.ReadLine()));

            double i = m / (h * h);

            Console.WriteLine($"Ваш ИМТ: {i:0.00}");

            if (i < 16)
                {
                Console.Write("У вас дефицит массы тела");
                }
            else if (i >= 18 && i <= 25)
                {
                Console.Write("Ваша масса тела в норме");
                }
            else if (i >= 26)
                {
                Console.Write("У вас избыточная масса тела");
                }

            Console.ReadKey();
        }

        private static void Form_A()
        {
            Console.WriteLine("Заполните пожалуйста Анкету :");

            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Ваш возраст: ");
            int age = int.Parse((Console.ReadLine()));

            Console.Write("Ваш рост: ");
            double height = double.Parse((Console.ReadLine()));

            Console.Write("Ваш вес: ");
            double weight = double.Parse((Console.ReadLine()));

            string output = "Имя: " + name + " Фамилия: " + surname + " Возраст: " + age.ToString() + " Рост: " + height.ToString() + " Вес " + weight.ToString();
            Console.WriteLine("Ваши данные:   " + output);


            Console.ReadKey();

        }


        private static void Form_B()
        {
            Console.WriteLine("Заполните пожалуйста Анкету :");

            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Ваш возраст: ");
            int age = int.Parse((Console.ReadLine()));

            Console.Write("Ваш рост: ");
            double height = double.Parse((Console.ReadLine()));

            Console.Write("Ваш вес: ");
            double weight = double.Parse((Console.ReadLine()));


            string pattern = "Имя: {0},  Фамилия: {1},  Возраст: {2},  Рост: {3},  Вес: {4}";  // Выводим шаблон в отдельную переменную.
            string output = String.Format(pattern, name, surname, age, height, weight);             

            Console.WriteLine("Ваши данные:   " + output);

            Console.ReadKey();
        }

       
        private static void Form_C()
        {
            Console.WriteLine("Заполните пожалуйста Анкету :");

            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Ваш возраст: ");
            int age = int.Parse((Console.ReadLine()));

            Console.Write("Ваш рост: ");
            double height = double.Parse((Console.ReadLine()));

            Console.Write("Ваш вес: ");
            double weight = double.Parse((Console.ReadLine()));

            Console.WriteLine($"Имя: {name},  Фамилия: {surname},  Возраст: {age},  Рост: {height},  Вес: {weight}");

            Console.ReadKey();
        }
    

    }
}
