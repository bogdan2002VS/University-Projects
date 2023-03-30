namespace DataL.DTO
{
    public class DepartmentDTO
    {
        public DepartmentDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public DepartmentDTO(string name)
        {
            Name = name;
        }

        public DepartmentDTO(int id)
        {
            Id = id;
        }

        public DepartmentDTO()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
