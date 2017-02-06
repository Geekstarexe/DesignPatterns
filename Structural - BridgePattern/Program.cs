using System;

namespace Structural___BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern - decouples the application from feature implementations");
            Console.WriteLine("Like posting to social media. You add Twitter but then later add FB you just want  ");
            Console.WriteLine("the application to know about positing to social media not to Fb or Twitter");


            string command = null;

            while (true)
            {
                command = Console.ReadLine();


                var messageController = new MessageController();
                if (command == "email")
                {
                  messageController.SetMessageType(MessageType.Email);
                }
                else
                {
                    messageController.SetMessageType(MessageType.Sms);
                }
                
                //Not implimented
                //messageController.SendMessage("phonenumber or email", "This is a exciting message");
                Console.WriteLine(messageController.Message.GetType());

            }


        }
    }
}
