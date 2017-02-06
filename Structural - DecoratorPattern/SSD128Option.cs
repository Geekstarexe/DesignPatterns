namespace Structural___DecoratorPattern
{
    public partial class SSD128Option : ComputerDecorator
    {
        public SSD128Option(Computer baseComputer) : base(baseComputer)
        {
            OptionCode = "SSD128";
            Price = 74.0M;
        }
    }
}