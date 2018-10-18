using System;

namespace AbstractFabric
{
    class USDate: AbstrDate
    {
        public override string GetDate(DateTime date)
        {
            
            return date.ToString("MM'-'dd'-'yyyy");
        }
    }
}