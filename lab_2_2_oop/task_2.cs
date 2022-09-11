using System;
using lab_2_2_oop;

namespace lab_2_2_oop
{
    class task_2
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(40.49, 39.94, 0.6);
            converter.name = "USD";
            Converter converter1 = new Converter(40.49, 39.94, 0.6);
            converter1.name = "EUR";
            Converter converter2 = new Converter(40.49, 39.94, 0.6);
            converter2.name = "RUB";
            Converter converter3 = new Converter(40.49, 39.94, 0.6);
            converter3.name = "UAH";
            Input input = new Input(40.49, 39.94, 0.6);

            Console.WriteLine("Введiть, що ви бажаєте обмiняти:");
            Console.WriteLine($"1.{converter3.name} на {converter.name}");
            Console.WriteLine($"2.{converter3.name} на {converter1.name}");    
            Console.WriteLine($"3.{converter3.name} на {converter2.name}");
            Console.WriteLine($"4.{converter.name} на {converter3.name}");
            Console.WriteLine($"5.{converter1.name} на {converter3.name}");
            Console.WriteLine($"6.{converter2.name} на {converter3.name}");
            input.Print_money();
            input.Converting();
            Console.ReadKey();
        }   
    }
}