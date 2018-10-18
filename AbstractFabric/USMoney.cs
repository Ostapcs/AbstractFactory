using System;

namespace AbstractFabric
{
    class USMoney : Money 
    {
        public override string GetMoney(decimal price)
        {
            var convertPrice = (Math.Floor(price)).ToString();
            
            
            var remainder = (int)((price - Math.Floor(price)) * 100) ;
            
            var count = 0;
            for (var i = convertPrice.Length - 1; i >= 0; i--)
            {
                ++count;
                if (count % 3 == 0 && count != (Math.Floor(price)).ToString().Length)
                {
                    convertPrice = convertPrice.Insert(i, ",");
                    
                }
               
            }
            
            if (remainder % 10 == 0)
            {
                remainder /= 10;
                return convertPrice  + "." +remainder.ToString() + "0";
            }
            else if (remainder <= 9)
            {
                return convertPrice  + ".0" +remainder.ToString()  ;
            }
            
            return convertPrice  + "." +remainder.ToString();
        }
    }
}