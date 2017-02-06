using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Pattern - Creation Pattern");
            Console.WriteLine("Used when you need to make copies of objects");
            Console.WriteLine("to pass around.  You create one object and then copy that instance.");
            Console.WriteLine("We will do this via the iCloable interface");
            Console.WriteLine("you have to consider Deep and shallow objects");
            Console.WriteLine("Shallow copies don't make actual copies they make refrence so if you make a change to a clone it changes the original");
            Console.WriteLine("Deep copies create new instances that don't refrence the target");


            User administrator;
            User administratorClone;
            User administratorDeepClone;


            administrator = new Administrator
            {
                FirstName = "Allen",
                LastName = "Crane",
                UserName = "Allen.Crane",
                Password = "Guess",
                BusinessAddress = new Address
                {
                    Address1 = "12 something",
                    Address2 = "Apt 120",
                    City = "Burbs",
                    State = "CO",
                    Zip = "1231233"
                },
                HomeAddress = new Address
                {
                    Address1 = "123 something",
                    Address2 = "Apt 1204",
                    City = "Freemont",
                    State = "CA",
                    Zip = "111111"
                }
            };

            administratorClone = (User) administrator.Clone();
            administratorDeepClone = administrator.DeepClone();

            Console.WriteLine("Admin Address line one '{0}'", administrator.BusinessAddress.Address1);
            Console.WriteLine("Admin Clone Address line one '{0}'", administratorClone.BusinessAddress.Address1);
            Console.WriteLine("Admin Deep Clone Address line one '{0}'", administratorDeepClone.BusinessAddress.Address1);

            Console.WriteLine("Change the address line one of the original");

            administrator.BusinessAddress.Address1 = "333 Simpson Ave";

            Console.WriteLine("Admin Address line one '{0}'", administrator.BusinessAddress.Address1);
            Console.WriteLine("Admin Clone Address line one '{0}'", administratorClone.BusinessAddress.Address1);
            Console.WriteLine("Admin Deep Clone Address line one '{0}'", administratorDeepClone.BusinessAddress.Address1);


            System.Threading.Thread.Sleep(50000);

        }
    }
}
