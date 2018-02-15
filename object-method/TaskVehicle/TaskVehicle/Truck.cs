using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Truck : Car
    {
        protected double HaulWeight;
        protected double Usage;


        public Truck(string type, string brand, int year, double price, double motorsize, string model, int doors, double haulweight, double usage) : base(type, brand, year, price, motorsize, model, doors)
        {
            HaulWeight = haulweight;
            Usage = usage;
        }


        public string CalcCons()
        {
            double cons = HaulWeight / Usage;
            return $"Kulutus on {cons} litraa.";
        }
    }
}
