using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSorting
{
    class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name}, {Id}, {Salary}";
        }

        public override bool Equals(object obj)
        {
            Employee other = obj as Employee;
            if (this == other)
                return true;

            if (!this.Id.Equals(other.Id))
                return false;

            if (!this.Name.Equals(other.Name))
                return false;

            if (!this.Salary.Equals(other.Salary))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            const int prime = 43;
            return this.Id.GetHashCode() * prime;
        }

        public int CompareTo(Employee other)
        {
            if (this.Id == other.Id)
                if (this.Name.CompareTo(other.Name) == 0)
                    return this.Salary.CompareTo(other.Salary);
                else
                    return this.Name.CompareTo(other.Name);
            else
                return this.Id.CompareTo(other.Id);
        }

        /*
        public static bool operator >(Employee first, Employee second)
        {
            //if (first.Id == second.Id)
            //    if (first.Name.CompareTo(second.Name) == 0)
            //        return first.Salary.CompareTo(second.Salary);
            //    else
            //        return first.Name.CompareTo(second.Name);
            //else
            //    return first.Id.CompareTo(second.Id);
            return first.Id.CompareTo(second.Id) > 0 ? true : false;
        }
        public static bool operator <(Employee first, Employee second)
        {
            //if (second.Id == first.Id)
            //    if (second.Name.CompareTo(first.Name) == 0)
            //        return second.Salary.CompareTo(first.Salary);
            //    else
            //        return second.Name.CompareTo(first.Name);
            //else
            //    return second.Id.CompareTo(first.Id);

            return second.Id.CompareTo(first.Id) > 0 ? true : false;
        }
        */
    }
}
