using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class CategoryDTO
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; } = string.Empty;

        public int ParentID { get; set; } = -1;

        public string Image { get; set; }
    }
}
