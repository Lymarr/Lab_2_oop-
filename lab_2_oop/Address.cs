using System;
using System.Collections.Generic;
using System.Text;
using lab_2_1_oop;

namespace lab_2_1_oop
{

    class Address
    {
        private string country;
        private string city;
        private string street;
        //------------------------------------
        private int index;
        private int house;
        private int apartment;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        //-----------------------------
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

    }
}
