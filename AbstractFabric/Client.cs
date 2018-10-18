using System;
using System.IO;

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
        

       
        public void CreateCell(Product product)
        {
            
            Console.WriteLine(product.id.ToString() + "\t|\t" + product.name + "\t|\t" + product.producer +  "\t|\t" +  Date.GetDate(product.Date) + "\t|\t" + Money.GetMoney(product.price));
           // Console.Write("__________________________________________________________________________|\n");
//            using (StreamWriter sw = new StreamWriter(Program.writepath,true,System.Text.Encoding.Default))
//            {
//                sw.Write(product.id.ToString() + "\t" + product.name + "\t" + product.producer +  "\t" +  Date.GetDate(product.date) + "\t" + Money.GetMoney(product.price)+"\n");
//            }
        }
    }
}