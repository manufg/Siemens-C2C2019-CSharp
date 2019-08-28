using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSorting
{
    class EmployeeComparison : IComparer<Employee>
    {
        private int choice;
        public EmployeeComparison()
        {

        }
        public EmployeeComparison(int choice)
        {
            this.choice = choice;
        }
        public int Compare(Employee x, Employee y)
        {
            int comparisonResult = 0;
            switch (choice)
            {
                case 1:
                    comparisonResult = x.Id.CompareTo(y.Id);
                    break;

                case 2:
                    comparisonResult = x.Name.CompareTo(y.Name);
                    break;

                case 3:
                    comparisonResult = x.Salary.CompareTo(y.Salary);
                    break;

                default:
                    comparisonResult = x.Id.CompareTo(y.Id);
                    break;
            }
            return comparisonResult;
        }
    }
}
