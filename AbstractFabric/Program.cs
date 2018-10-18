
using System;
using System.IO;

namespace AbstractFabric
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string path = @"/Users/ostapkutyanskij/RiderProjects/AbstractFabric/AbstractFabric/ProductsItems/products.txt";


            Client c = new Client(new USFactory());   
            using (var sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                   // Console.WriteLine(line.Split(' '));
                    string [] a = line.Split(' ');
                    var id = int.Parse(a[0]);
                    var price = Convert.ToDecimal(a[2]);
                    var product = new Product(id,a[1],price,a[3]);
                    c.CreateCell(product);
                    
                }
            }
        }
    }
}