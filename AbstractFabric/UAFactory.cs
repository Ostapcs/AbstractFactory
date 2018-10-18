namespace AbstractFabric
{
    class UAFactory : AbstractFactory
    {
        public override AbstrDate CreateDate()
        {
            return new UADate();
        }

        public override Money CreateMoney()
        {
            return new UAMoney();
        }
    }
}