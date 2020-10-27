using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество элементов");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("введите элементы");
            for (int i = 0; i <n; i++)
            {
                a[i]=int.Parse(Console.ReadLine()); 
                    }
            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            { 
                if (a[i] > 0)
                { 
                    sum += a[i];
                }

                if (Math.Abs(a[i] % 2) == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("Сумма положительных чисел равна {0}", sum);
            Console.WriteLine("Количество нечетных чисел равно {0}", count);
            //oddSum();
            //closestNumber();
            //circleSquare();
        }

        private static void oddSum()
        {
            int sum = 0;
            for (int i = 23; i >= 11; i--)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Сумма чисел равна {0}", sum);
        }

        private static void closestNumber() 
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = int.Parse(Console.ReadLine());
            if (Math.Abs(c - a) < Math.Abs(c - b))
            {
                Console.WriteLine("Первое число ближе к третьему и равно {0}", a);
            }
            else if (Math.Abs(c - a) > Math.Abs(c - b))
            {
                Console.WriteLine("Второе число ближе к третьему и равно {0}", b);
            }
            else
            {
                Console.WriteLine("Числа одинаково близки");
            }
        }

        private static void circleSquare()
        {
            Console.WriteLine("Введите радиус круга");
            double a = double.Parse(Console.ReadLine());
            double s = a * a * Math.PI;
            Console.WriteLine("Площадь круга равна {0}", s);
        }
    }
}

