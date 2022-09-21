using System;
using System.Collections.Generic;
using System.Text;
using lab_2_2_oop;

namespace lab_2_2_oop
{
    public class Converter
    {
        public string name;
        public int money;
        public int choice;

        private double usd = 40.49;
        private double eur = 39.94;
        private double rub = 0.6;

        public double Usd()
        {
            return this.usd;
        }
        public double Eur()
        {
            return this.eur;
        }
        public double Rub()
        {
            return rub;
        }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }


        public void AnotherCurrent()
        {
            double result1 = this.money / Usd();
            double result2 = this.money / Eur();
            double result3 = this.money / Rub();
            double result4 = this.money * Usd();
            double result5 = this.money * Eur();
            double result6 = this.money * Rub();

            switch (this.choice)
            {
                case 1:
                    Console.WriteLine($"Обмiн становить:{ result1 }");
                    break;
                case 2:
                    Console.WriteLine($"Обмiн становить: {result2 }");
                    break;
                case 3:
                    Console.WriteLine($"Обмiн становить: {result3}");
                    break;
                case 4:
                    Console.WriteLine($"Обмiн становить: {result4 }");
                    break;
                case 5:
                    Console.WriteLine($"Обмiн становить: {result5}");
                    break;
                case 6:
                    Console.WriteLine($"Обмiн становить: {result6 }");
                    break;
            }
        }
        public void CheckingCurrent()
        {
            while (true)
            {
                var input1 = Console.ReadLine();

                 if (int.TryParse(input1, out this.money) || this.money < 0) 
                    break;
                else
                {
                    Console.WriteLine("Щось пішло не так! Введiть число, починаючи з нуля");
                    Console.WriteLine("Спробуйте знову:");
                }

            }
        }

        public void CheckingChoice()
        {
            while (true)
            {
                var input2 = Console.ReadLine();
                if (this.choice <= 6 || this.choice >= 1)
                    break;
                if (int.TryParse(input2, out this.choice))
                    break;
                else
                {
                    Console.WriteLine("Щось пiшло не так! Введiть цифру від 1 до 6!");
                    Console.WriteLine("Спробуйте знову");
                }
            }
            

        }
    }
}
      

    


