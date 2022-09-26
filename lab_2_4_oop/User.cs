using System;
using System.Collections.Generic;
using System.Text;
using lab_2_4_oop;

namespace lab_2_4_oop
{
    public class User
    {

        private string login = "3O45dW.3";
        private string name = "Olena";
        private string lastname = "Muller";
        private readonly string date;



        private string Date
        {
            get { return this.date; }
        }

        public User(string date)
        {
            this.date = date;
        }

        public void Print()
        {
            Console.WriteLine($" Login: {login}");
            Console.WriteLine($" Name: {name}");
            Console.WriteLine($" Last name: {lastname}");
            Console.WriteLine($" Regist date: {date} ");

        }

    }

}
