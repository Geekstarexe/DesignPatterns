using System;

namespace Structural___BridgePattern
{
    //concrete implimentor in the Bridge Pattern
    public class EmailMessage :IMessage
    {
        public void SendMessage(string to, string message)
        {
            throw new NotImplementedException();
        }
    }
}