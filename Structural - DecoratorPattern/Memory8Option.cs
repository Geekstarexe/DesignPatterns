namespace Structural___DecoratorPattern
{
    public partial class Memory8Option : ComputerDecorator
    {
        public Memory8Option(Computer baseComputer) : base(baseComputer)
        {
            OptionCode = "8RAM";
            Price = 70.0M;
        }
    }
}