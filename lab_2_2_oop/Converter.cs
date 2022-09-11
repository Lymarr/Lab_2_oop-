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

        private double usd;
        private double eur;
        private double rub;
     
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
        public void Converting()
        {
            switch (this.choice)
            {
                case 1:
                    Console.WriteLine($"Обмiн становить: {this.money / Usd() }");
                    break;
                case 2:
                    Console.WriteLine($"Обмiн становить: {this.money / Eur() }");
                    break;
                case 3:
                    Console.WriteLine($"Обмiн становить: {this.money / Rub() }");
                    break;
                case 4:
                    Console.WriteLine($"Обмiн становить: {this.money * Usd() }");
                    break;
                case 5:
                    Console.WriteLine($"Обмiн становить: {this.money * Eur() }");
                    break;
                case 6:
                    Console.WriteLine($"Обмiн становить: {this.money * Rub() }");
                    break;
            }
        }
    }

    public class Input : Converter
    {
        public Input(double usd, double eur, double rub) : base(usd, eur, rub)
        {
        } 
        public void Print_money()
        {
            Print_choice();
            Console.WriteLine("Введiть суму, яку бажаєте обмiняти:");
            tryagain:
            this.money = Convert.ToInt32(Console.ReadLine());
            if (this.money < 0)
            {
                Console.WriteLine("Щось пішло не так! Введiть число, починаючи з нуля");
                goto tryagain;
            }
        }
   
        private void Print_choice()
        {
            start:
            this.choice = Convert.ToInt32(Console.ReadLine());
            if (this.choice > 6 || this.choice < 0)
            {
                Console.WriteLine("Щось пiшло не так! Введiть цифру від 1 до 6!");
                goto start;
            }           
        }
    }
}
