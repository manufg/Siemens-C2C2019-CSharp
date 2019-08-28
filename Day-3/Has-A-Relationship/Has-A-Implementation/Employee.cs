namespace Has_A_Implementation
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; private set; }

        private Department departmentInfo;
        public Department DepartmentInfo
        {
            set
            {
                departmentInfo = value;
                if (value != null)
                {
                    DepartmentId = value.DepartmentId;
                }
            }
            get => departmentInfo;
        }
        public Employee()
        {

        }
        public Employee(string name, int id, decimal salary, Department department = null)
        {
            EmployeeId = id;
            EmployeeName = name;
            Salary = salary;

            departmentInfo = department;
            if (department != null)
                DepartmentId = department.DepartmentId;
        }
    }
}
