
using System;
using System.IO;

namespace AbstractFabric
{
    internal class Program
    {
        public const string path = 
                     @"/Users/ostapkutyanskij/RiderProjects/AbstractFabric/AbstractFabric/ProductsItems/products.txt";
        public const string writepath =
                     @"/Users/ostapkutyanskij/RiderProjects/AbstractFabric/AbstractFabric/output/output.txt";

        
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose your localization: UA or US");
            var input = Console.ReadLine();
            AbstractFactory factory;

            while (true)
            {
                if (input == "UA")
                {
                    factory = new UAFactory();
                    break;
                }
                else if (input == "US")
                {
                    factory = new USFactory();
                    break;
                }
                else
                {
                    Console.WriteLine("Choose your localization: UA or US");
                    input = Console.ReadLine();
                }
            }        
                    
            
            
            Client c = new Client(factory);   
            using (var sr = new StreamReader(path))
            {
                string line;
                while ((  line = sr.ReadLine()) != null)
                {
                    
                    string [] a = line.Split(' ');
                    var id = int.Parse(a[0]);
                    var price = Convert.ToDecimal(a[2]);
                    var date = DateTime.ParseExact(a[4], "dd'/'MM'/'yyyy", null);
                    var product = new Product(id,a[1],price,a[3],date);
                    c.CreateCell(new Product(id,a[1],price,a[3],date));
                    
                }
                
            }
           
        }
    }
}