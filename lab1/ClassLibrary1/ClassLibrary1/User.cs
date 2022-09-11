namespace ClassLibrary1
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Danila";
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
    }
}