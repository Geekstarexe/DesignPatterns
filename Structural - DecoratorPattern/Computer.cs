namespace Structural___DecoratorPattern
{
    public abstract class Computer
    {
        public string Description { get; set; }
        public string Model { get; set; }

        public abstract string GetOptionCode();
        public abstract decimal GetPrice();
    }
}