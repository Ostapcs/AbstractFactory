namespace AbstractFabric
{
    class UAMoney : Money
    {
        public override string GetMoney(decimal price)
        {
            return price.ToString() + ".00";
        }
    }
}