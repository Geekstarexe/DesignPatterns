using System;

namespace Structural___DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * A object that has a lot of options on it maybe like a car
             * Adding class capibilites
             *
             *Subclass the original class into a decorator class 
             * In the decorator class add a component member
             * pass the component into the Decorator Constructor
             * override methods as needed
             * 
             **/


            ComputerBase baseComputer = new ComputerBase() {Model = "Starter PC"};

            Console.WriteLine(baseComputer.Model);
            Console.WriteLine(baseComputer.GetPrice());

            ComputerDecorator ramDecorator = new Memory16Option(baseComputer);

            ComputerDecorator ssDecorator = new SSD512Option(ramDecorator);

            DiscountDecorator discountDecorator = new DiscountDecorator(ssDecorator);

            Console.WriteLine(baseComputer.Model);
            Console.WriteLine(baseComputer.GetPrice());


            Console.WriteLine(ramDecorator.Model);
            Console.WriteLine(ramDecorator.GetPrice());

            Console.WriteLine(ssDecorator.Model);
            Console.WriteLine(ssDecorator.GetPrice());

            Console.WriteLine(discountDecorator.Model);
            Console.WriteLine(discountDecorator.GetPrice());



            System.Threading.Thread.Sleep(8000);
        }
        
    }
}


























