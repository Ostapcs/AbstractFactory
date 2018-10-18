namespace AbstractFabric
{
     class USFactory: AbstractFactory
    {
        public override AbstrDate CreateDate()
        {
            return new USDate();
        }

        public override Money CreateMoney()
        {
            return new USMoney();
        }
    }
}