namespace myBackend.Models
{
    public class Employee
    {
        public int Id { get; set; }
    public string EmployeesName { get; set; }
    public string EmployeesLastName { get; set; }
    public string EmployeesDepartment { get; set; }
    public int EmployeesExtension { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}