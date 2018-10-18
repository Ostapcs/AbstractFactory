using System;

namespace AbstractFabric
{
    class USDate: AbstrDate
    {
        public override string GetDate(DateTime date)
        {
            return date.Month.ToString() + "." + date.Day.ToString() + "." + date.Year.ToString() ;
        }
    }
}