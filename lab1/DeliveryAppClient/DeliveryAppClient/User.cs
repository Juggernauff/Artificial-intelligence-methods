namespace DeliveryAppClient
{
    public enum Role
    {
        User,
        Admin
    }
    public class User
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string patronymic { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Role role { get; set; }


        public User(string lastName, string firstName, string patronymic, string phoneNumber, string address, string login, string password, Role role = Role.User)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.login = login;
            this.password = password;
            this.role = role;
        }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
