
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDCar
{
    class Car
    {
        private string mark, color;
        private int number, traveledKM;
        private static int nbC = 0;
        // constructor
        public Car(string mark, string color, int number, int traveledKM)
        {
            this.mark = mark; this.color = color;
            this.number = number; this.traveledKM = traveledKM;
            nbC++;
        }
        //properties
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int TraveledKM
        {
            get { return traveledKM; }
            set { if(value > traveledKM) traveledKM = value; }
        }
        public static int NbC
        {
            get { return nbC; }
        }
        public override string ToString()
        {
            string s = "";
            s += "Car :\n";
            s += "Mark: " + mark + "\n";
            s += "Color: " + color + "\n";
            s += "Number: " + number + "\n";
            s += "TraveledKM: " + traveledKM + "\n";
            return s;
        }
        public void modifyKM(int L)
        {
            traveledKM += 11 * L;
        }
    }
}
