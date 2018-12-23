using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name : Devdas Chatterjee
 * ID: 300874157
 */

namespace Restaurant_Bill_Collector
{
    class Appetizer
    {
        public string name { get; set; }
        public double price { get; set; }
        
        public Appetizer(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setPrice(double price)
        {
            this.price=price;
        }
        public double getPrice()
        {
            return price;
        }
        public override string ToString()
        {
            return string.Format("{0}{1}",name, price);
        }

    }
}
