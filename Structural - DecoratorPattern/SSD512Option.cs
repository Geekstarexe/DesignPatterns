namespace Structural___DecoratorPattern
{
    public partial class SSD512Option : ComputerDecorator
    {
        public SSD512Option(Computer baseComputer) : base(baseComputer)
        {
            OptionCode = "SSD512";
            Price = 174.0M;
        }
    }
}