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
    class MenuItems
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public MenuItems(string name, int quantity, double price)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
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
            this.price = price;
        }
        public double getPrice()
        {
            return price;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public override string ToString()
        {
            return string.Format("{0}{1}{2}", name, quantity,price);
        }

    }
}
