

namespace PurchaseRequestSystem.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public User(int id, string userName, string password, string firstname, string lastname, string email, string phone)
        {
            Id = id;
            UserName = userName;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phone;
        }
    }
}
