using System;

namespace AbstractFabric
{
    class UAMoney : Money
    {
        public override string GetMoney(decimal price)
        {
            var convertPrice = (Math.Floor(price)).ToString();
            
            var remainder = (int)((price - Math.Floor(price)) * 100) ;
            
            if (remainder % 10 == 0)
            {
                remainder /= 10;
                return convertPrice  + "." +remainder.ToString() + "0";
            }
            else if (remainder <= 9)
            {
                return convertPrice  + ".0" +remainder.ToString()  ;
            }
            else if (remainder == 0)
            {
                return convertPrice.ToString() + ".00";
            }

            return convertPrice.ToString() + "."+remainder.ToString();
        }
    }
}