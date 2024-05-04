using System;

class LinearEquationSolver
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Phuong trinh cua ban la: {a}x + {b} = 0");
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Nghiem cua phuong trinh x = {x}");
        }
    }
}
