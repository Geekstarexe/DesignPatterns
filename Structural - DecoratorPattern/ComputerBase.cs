namespace Structural___DecoratorPattern
{
    public class ComputerBase : Computer
    {
        public override string GetOptionCode()
        {
            return string.Empty;
        }

        public override decimal GetPrice()
        {
            return 499.0M;
        }
    }
}