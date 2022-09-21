using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Address
    {
        private string street;
        private int houseNum;
        private string city;
        private int pBox;

        public Address(string street, int houseNum, string city, int pBox)
        {
            this.street = street;
            this.houseNum = houseNum;
            this.city = city;
            this.pBox = pBox;
        }

        //פעולה בונה מעתיקה
        public Address(Address address)
        {
            street = address.street;
            houseNum = address.houseNum;
            city = address.city;
        }

        //פעולות מאחזרות
        public string GetStreet() { return street; }
        public int GetHouseNum() { return houseNum; }
        public string GetCity() { return city; }
        public int GetPBox() { return pBox; }

        //פעולות קובעות
        public void SetStreet(string street) { this.street = street; }
        public void SetHouseNum(int houseNum) { this.houseNum = houseNum; }
        public void SetCity(string city) { this.city = city; }
        public void SetPBox(int pBox) { this.pBox = pBox; }

    }
}
