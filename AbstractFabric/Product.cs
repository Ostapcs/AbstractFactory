using System;

namespace AbstractFabric
{
    class Product
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public decimal price { get; private set; }
        public string producer { get; private set; }
        public DateTime Date { get; private set; }

        public Product(int id, string name, decimal price, string producer,DateTime date)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
            Date = date;   
        }
        
        public Product()
        {
        }
    }
}