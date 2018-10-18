using System;

namespace AbstractFabric
{
    
    class UADate : AbstrDate 
    {
        public override string GetDate(DateTime date)
        {
            return date.ToString("dd.MM.yyyy");
            
        }
    }
}