namespace Structural___DecoratorPattern
{
    public abstract  class ComputerDecorator : Computer
    {
        protected Computer BaseComputer = null;
        protected string OptionCode = string.Empty;
        protected decimal Price = 0.0M;


        protected ComputerDecorator(Computer baseComputer)
        {
            BaseComputer = baseComputer;
            Model = baseComputer.Model;
        }


        public override decimal GetPrice()
        {
            return Price + BaseComputer.GetPrice();
        }


        public override string GetOptionCode()
        {
            return string.Format("{0}-{1}", BaseComputer.GetOptionCode(), OptionCode);  
        }
    }
}