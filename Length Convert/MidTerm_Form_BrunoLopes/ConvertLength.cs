using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_Form_BrunoLopes
{
    internal class ConvertLength
    {
        //private fields
        private double length1;


        //properties
        public double Lenght1
        {
            get { return length1; }
            set { length1 = value; }
        }

        //constructor
        public ConvertLength(double lenght1)
        {
            Lenght1 = lenght1;
        }

        //methods
        public double btnMYd_Click() //meters to yard
        {
            double lenght2 = Lenght1 * 1.0936;
            return lenght2;
        }
        public double btnKmMile_Click() //km to miles
        {
            double lenght2 = Lenght1 * 0.6214;
            return lenght2;
        }



    }
}
