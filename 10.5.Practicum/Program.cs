using System;

namespace _10._5.Practicum
{
    class Program
    {
        public class Calculation : ISum
        {
            public void Calculate()
            {
                double firstValue, secondValue;

                while (true)

                {
                    try
                    {
                        Console.WriteLine("Введите число 1");
                        firstValue = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите число 2");
                        secondValue = double.Parse(Console.ReadLine());
                    }
                    catch (Exception )
                    {

                        Console.WriteLine("Ошибка!Нужно ввести число"); 
                        continue;
                    }
                    double result = firstValue + secondValue;
                        Console.WriteLine($"Сумма чисел = {result}");
                        Console.WriteLine();     
                }
            }   
        }
        public interface ISum
        {
            public void Calculate();
        }
        static void Main(string[] args)
        {

            Calculation calculation = new Calculation();
            ISum sum = new Calculation();
            sum.Calculate();
        }
    }
}
