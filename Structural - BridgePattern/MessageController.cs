using System;

namespace Structural___BridgePattern
{
    //This is your BRIDGE Class
    public class MessageController
    {
        public IMessage Message { get; set; }

        //this looks like the Imessage interface but it's not
        public void SendMessage(string to, string message)
        {
            Message.SendMessage(to, message);
        }

        public void SetMessageType(MessageType messageType)
        {
            switch (messageType)
            {
                    case MessageType.Email:
                    Message = new EmailMessage();
                    break;
                    case MessageType.Sms:
                    Message = new SmsMessage();
                    break;
            }
        }
    }
}