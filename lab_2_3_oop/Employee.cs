using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_3_oop
{
    class Employee
    {
            public double WorkHours;
            public string post;
            public double expirience;

            private string fname;
            private string lname;
            private double taxes;
            private int PayRate;

        public Employee(string firstname, string lastname)
            {
                this.fname = firstname;
                this.lname = lastname;
            }

            public void Print()
            {
                Console.WriteLine($" First name of employee: {fname} {'\n'} Last name of the employee: {lname}");
            }

        public void PostChoosing()
        {
            switch(this.post)
            {
                case "director":
                Expirience_director();
                break;
                case "manager":
                Expirience_manager();
                break;
                case "accountant":
                Expirience_accountant();
                break;
            }


        }
            public void SalaryCounting()
            {
            double fullsalary = this.WorkHours * this.PayRate;
            double salarywtaxies = this.WorkHours * this.PayRate * this.taxes;
                Console.WriteLine("Salary with no taxes is: " + fullsalary);
                Console.WriteLine("Salary with taxes is: " + salarywtaxies);
            }

        private void Expirience_director()
        {
            if (expirience <= 5)
            {
                this.PayRate = 500;
                this.taxes = 0.75;
                Console.WriteLine("So Taxes : 25%");
            }
            else if (expirience > 5)
            {
                this.PayRate = 600;
                this.taxes = 0.70;
                Console.WriteLine("So Taxes : 30%");
            }
        }

        private void Expirience_manager()
        {
            if (this.expirience <= 5)
            {
                this.PayRate = 400;
                this.taxes = 0.80;
                Console.WriteLine("So Taxes : 20%");
            }
            else if (this.expirience > 5)
            {
                this.PayRate = 500;
                this.taxes = 0.75;
                Console.WriteLine("So Taxes : 25%");
            }
        }

        private void Expirience_accountant()
        {
            if (this.expirience <= 5)
            {
                this.PayRate = 300;
                this.taxes = 0.83;
                Console.WriteLine("So Taxes : 17%");
            }
            else if (this.expirience > 5)
            {
                this.PayRate = 400;
                this.taxes = 0.77;
                Console.WriteLine("So Taxes : 23%");
            }
        }

    }
}


