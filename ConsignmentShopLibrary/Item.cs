using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }
        public string Display
        {
            get
            {
                return string.Format("{0} - ${1}", Title, Price.ToString("F"));
            }
        }


        public Item()
        {

        }
        public Item(string title, string description, decimal price, Vendor owner)
        {
            Title = title;
            Description = description;
            Price = price;
            //Sold = false;
            //PaymentDistributed = paymentDistributed;
            Owner = owner;



        }

       



    }
}
