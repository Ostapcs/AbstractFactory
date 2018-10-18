using System;

namespace AbstractFabric
{
    
    class UADate : AbstrDate 
    {
        public override string GetDate(DateTime date)
        {
            return date.Day.ToString() +"." + date.Month.ToString()+"." + date.Year.ToString() ; 
        }
    }
}