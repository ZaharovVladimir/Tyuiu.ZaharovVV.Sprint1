using Tyuiu.ZaharovVV.Sprint1.Task4.V19.Lib;


namespace Tyuiu.ZaharovVV.Sprint1.Task4.V19
{
    class Programm
    {
        static void Main(String[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Захаров В. В. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Захаров Владимир Владимирович | ИСТНб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  (x + y) / |x - 2|                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.Calculate(x, y));

            Console.ReadLine();

        }
    }
}
