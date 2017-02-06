namespace Structural___DecoratorPattern
{
    public partial class Memory16Option : ComputerDecorator
    {
        public Memory16Option(Computer baseComputer) : base(baseComputer)
        {
            OptionCode = "16RAM";
            Price = 150.0M;
        }
    }
}