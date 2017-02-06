using System;

namespace PrototypePattern
{
    public abstract class User : ICloneable
    {
        public Address BusinessAddress { get; set; }
        public string FirstName { get; set; }
        public Address HomeAddress { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public abstract object Clone();

        public abstract User DeepClone();
    }
}