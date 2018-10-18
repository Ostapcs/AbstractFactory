namespace AbstractFabric
{
    abstract class AbstractFactory
    {
        public abstract AbstrDate CreateDate();
        public abstract Money CreateMoney();
    }
}