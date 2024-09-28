using Tyuiu.ZaharovVV.Sprint1.Task3.V11.Lib;

namespace Tyuiu.ZaharovVV.Sprint1.Task3.V11
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Захаров В. В. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Захаров Владимир Владимирович | ИСТНб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известно расстояние в метрах. Перевести расстояние в километры          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты вершин:");

            Console.Write("x1-> ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1-> ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2-> ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y2-> ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x3-> ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y3-> ");
            double y3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Площадь треугольника равна: " + ds.TriangleArea(x1, y1, x2, y2, x3, y3));

            Console.ReadLine();
        }
    }
}