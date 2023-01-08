using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Pharmacy_2023
{
    public class Medicine
    {
        private string name;
        private double price;
        public Medicine(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid price");
                }
                price = value; 
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }
        public override string ToString()
        {
            return $"Medicine: {this.name} with price {this.Price:f2}";
        }
    }
}
