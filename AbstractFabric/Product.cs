using System;

namespace AbstractFabric
{
    class Product
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public decimal price { get; private set; }
        public string producer { get; private set; }
        public DateTime date { get; private set; }

        public Product(int id, string name, decimal price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
            
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, 31);
            
            date = new DateTime(2018,month,day);
            
        }

        public Product()
        {
        }
    }
}