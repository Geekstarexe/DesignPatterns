namespace Structural___DecoratorPattern
{
    public partial class DiscountDecorator : ComputerDecorator
    {
        public int DiscountRate { get; set; }
        public DiscountDecorator(Computer baseComputer) : base(baseComputer)
        {
            DiscountRate = 5;
            OptionCode = "Discount";
            Price = 0;
        }

        public override string GetOptionCode()
        {
            return base.GetOptionCode() + string.Format("Disc {0}", DiscountRate);
        }

        public override decimal GetPrice()
        {
            return (100 - DiscountRate)*BaseComputer.GetPrice()/100;
        }
    }
}