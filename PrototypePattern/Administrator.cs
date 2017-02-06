namespace PrototypePattern
{
    public class Administrator : User
    {
        //returns a shallow object with references the to Address so you can not change them 
        //without changing the class that's being derived from
        public override object Clone()
        {
            return MemberwiseClone() as User;
        }

        //Creates a deep copy creating new address objects. 
        public override User DeepClone()
        {
            Administrator administrator = MemberwiseClone() as Administrator;

            administrator.BusinessAddress = new Address
            {
                Address1 = this.BusinessAddress.Address1,
                Address2 = this.BusinessAddress.Address2,
                City = this.BusinessAddress.City,
                Zip = this.BusinessAddress.Zip,
                State = this.BusinessAddress.State
            };  

            administrator.HomeAddress = new Address
            {
                Address1 = this.HomeAddress.Address1,
                Address2 = this.HomeAddress.Address2,
                City = this.HomeAddress.City,
                Zip = this.HomeAddress.Zip,
                State = this.HomeAddress.State
            };


            return administrator;
        }
    }
}