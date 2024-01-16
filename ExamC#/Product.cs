using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    public abstract class Product
    {
        private int id;
        private string name;    
        private double price;
        private string producer;

        public Product (int id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set {  price = value; }
        }

        public string Producer
        {
            get { return producer; }
            set {  producer = value; }
        }

        public void OutputInfoProduct()
        {
            Console.WriteLine("The product id                 : " + Id);
            Console.WriteLine("The product name               : " + Name);
            Console.WriteLine("The product price              : " + Price);
            Console.WriteLine("The producer                   : " + Producer);
        }

        public abstract double computeTax();
    }
}
