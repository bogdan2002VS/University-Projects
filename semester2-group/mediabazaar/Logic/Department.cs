namespace Logic
{
    public class Department
    {
        private int id;
        private string name;

        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Department(string name)
        {
            Name = name;
        }

        public Department()
        {

        }
    }
}