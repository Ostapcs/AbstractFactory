using System;
namespace AbstractFabric
{
    class Client
    {
        private AbstrDate Date;
        private Money Money;
        public Client(AbstractFactory Factr)
        {
            Date = Factr.CreateDate();
            Money = Factr.CreateMoney();
        }
        

        public void date(Product a)
        {
            Console.WriteLine(Date.GetDate(a.date));
        }

        public void money(Product a)
        {
            Console.WriteLine(Money.GetMoney(a.price));
        }
        public void CreateCell(Product product)
        {
            Console.WriteLine(product.id.ToString() + "\t" + product.name + "\t" + product.producer +  "\t" +  Date.GetDate(product.date) + "\t" + Money.GetMoney(product.price));
        }
    }
}