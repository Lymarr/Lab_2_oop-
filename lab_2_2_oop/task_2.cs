using System;
using lab_2_2_oop;

namespace lab_2_2_oop
{
    class task_2
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(40.49, 39.94, 0.6);

            Console.WriteLine("Введiть, що ви бажаєте обмiняти:");
            Console.WriteLine($"1.UAH на USD");
            Console.WriteLine($"2.UAH на EUR");    
            Console.WriteLine($"3.UAH на RUB");
            Console.WriteLine($"4.USD на UAH");
            Console.WriteLine($"5.EUR на UAH");
            Console.WriteLine($"6.RUB на UAH");
            converter.CheckingChoice();
            Console.WriteLine("Яку суму бажаєте обміняти?");
            converter.CheckingCurrent();
            converter.AnotherCurrent();
            Console.ReadKey();
        }   
    }
}