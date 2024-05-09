using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 0; // початок 
        double b = 6; // кінець 
        double dx = 0.5; // крок

        Console.WriteLine("Результати обчислення функції y = f(x) = 1 / sqrt(x) на проміжку [{0}, {1}] з кроком {2}", a, b, dx);
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("|    x    |    y    |");
        Console.WriteLine("---------------------");

        double x = a;

        while (x <= b)
        {
            double y;

            try
            {
                if (x == 0)
                {
                    throw new DivideByZeroException(); // обробка виключення ділення на нуль
                }
                y = 1 / Math.Sqrt(x);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("|  {0,-6} |  Не визначено  |", x);
                x += dx;
                continue;
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("|  {0,-6} |  Арифметична помилка  |", x);
                x += dx;
                continue;
            }

            Console.WriteLine("|  {0,-6} |  {1,-10:F4}  |", x, y);
            x += dx;
        }

        Console.WriteLine("---------------------");
        Console.ReadLine();
    }
}
