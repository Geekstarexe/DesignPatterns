namespace Structural___DecoratorPattern
{
    public partial class SSD256Option : ComputerDecorator
    {
        public SSD256Option(Computer baseComputer) : base(baseComputer)
        {
            OptionCode = "SSD256";
            Price = 135.0M;
        }
    }
}