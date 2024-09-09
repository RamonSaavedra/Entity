using System.ComponentModel.DataAnnotations;

namespace myBackend.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; } = string.Empty;
        public string DepartmentHead { get; set; }
        public string DepartmentDescription { get; set; }
       
    }
}
