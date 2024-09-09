namespace PurchaseRequestSystem.Models
{
    internal class Vendor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Vendor(int id, string code, string name, string addres, string city, string state, string zip, string phoneNumber, string email)
        {
            Id = id;
            Code = code;
            Name = name;
            Address = addres;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;

        }

    }
}
