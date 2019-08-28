using HRMSAPP.Entities;

namespace HRMSAPP.Repository
{
    public static class EmployeeRepository
    {
        private static Employee[] employees;
        
        static EmployeeRepository()
        {
            employees = new Employee[4];
        }
        public static Employee[] Get()
        {
            return employees;
        }
    }
}
