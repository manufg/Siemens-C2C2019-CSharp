namespace Has_A_Implementation
{
    class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Employee[] Employees { get; set; }
        public Department()
        {

        }
        public Department(string name, int id, Employee[] employees = null)
        {
            DepartmentId = id;
            DepartmentName = name;
            Employees = employees;
        }
        public override string ToString()
        {
            return $"Name: {DepartmentName} and Id:{DepartmentId}";
        }
    }
}
