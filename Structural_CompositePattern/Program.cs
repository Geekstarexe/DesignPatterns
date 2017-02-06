using System;
using System.Collections.Generic;

namespace Structural_CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composite Pattern");
            Console.WriteLine("Solves the problem of an object with several children of the same type");
            Console.WriteLine("All the classes / objects need to be of the same abstract class or interface");

            Assembly topWidget = new Assembly("Main Assembly", 1);
            Assembly chassis = new Assembly("Chassis Assembly", 2);
            Assembly display = new Assembly("Display Assembly", 5);
            Assembly powersupply = new Assembly("Power Supply Assembly", 6);
            Part bolt = new Part("bolt",24);
            Part mainCase = new Part("main case",1);
            Part screen = new Part("screen",3);
            Part displayElectronics = new Part("display electronics",8);
            Part transformer = new Part("Transformer",9);
            Part powerBoard = new Part("power board",0);
            Part ductTape = new Part("duct tape",2);
            Part gum = new Part("gum",7);


            topWidget.Add(chassis);
            topWidget.Add(display);
            topWidget.Add(powersupply);
            chassis.Add(bolt);
            chassis.Add(mainCase);
            display.Add(screen);
            display.Add(displayElectronics);
            powersupply.Add(transformer);
            powersupply.Add(powerBoard);
            powersupply.Add(ductTape);
            topWidget.Add(gum);

            DisplayPartsList(topWidget);

            System.Threading.Thread.Sleep(50000);
        }

        private static void DisplayPartsList(Assembly topWidget)
        {
            List<string> partsList = new List<string>();

            //Write Parts List is the reason you use the composite method so you can call it anywhere in the tree 
            topWidget.WritePartsList(partsList);

            foreach (string assembly in partsList)
            {
                Console.WriteLine(assembly);
            }
        }
    }
}
