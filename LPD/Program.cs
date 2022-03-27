using System;

namespace LPD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составьте программу определения наименьшего общего кратного двух натуральных чисел.

            int _LeastComDivider;
            int _GreatComDivider;
            int a, b, result;
            //Ввод данных + проверка
            do
            {
                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 0);

            do
            {
                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b < 0);

            //нахождение первой части НОД
            result = a - b;

            //нахождение второй части НОД
            _LeastComDivider = b - result;

            if (_LeastComDivider == 0) 
                //нахождение НОК
                _GreatComDivider = a * b / b;
            else
                //нахождение НОК
                _GreatComDivider = a * b / _LeastComDivider;

            Console.WriteLine("НОК = "+ _GreatComDivider);
            Console.ReadKey();

        }
    }
}
