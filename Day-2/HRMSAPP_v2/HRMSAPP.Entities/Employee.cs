using System;

namespace HRMSAPP.Entities
{
    public class Employee
    {
        string name;
        int id;
        decimal basicPayment;
        decimal daPayment;
        decimal hraPayment;
        
        decimal totalSalary;

        //field-initialization
        public const decimal JOININGBONUS = 1000;
        static decimal yearlyBonus;// = 2000;
        readonly Designation designation;
        static readonly string companyName;//="Siemens";

        static Employee()
        {
            yearlyBonus = 2000;
            companyName = "Siemens";
        }

        public Employee()
        {
            //const int x = 10;
        }
        public Employee(string name, int id, decimal basic, decimal da, decimal hra, Designation designation =  Entities.Designation.Provisional)
        {
            this.name = name;
            this.id = id;
            this.basicPayment = basic;
            this.daPayment = da;
            this.hraPayment = hra;
            this.designation = designation;
        }

        //property
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public int Id
        {
            set => id = value;
            get => id;
        }       
        public decimal BasicPayment
        {
            set => basicPayment = value;
            get => basicPayment;
        }
        public decimal DaPayment
        {
            set => daPayment = value;
            get => daPayment;
        }
        public decimal HraPayment
        {
            set => hraPayment = value;
            get => hraPayment;
        }

        public static decimal YearlyBonus => yearlyBonus;

        public static string CompanyName => companyName;

        public Designation Designation => designation;

        public decimal TotalSalary
        {
            get => totalSalary;
            protected set => totalSalary = value;
        }

        public virtual void CalculateSalary()
        {
            this.totalSalary = this.basicPayment + this.daPayment + this.hraPayment + JOININGBONUS + yearlyBonus;
        }

        public override string ToString()
        {
            return $"Name:{this.name}, Id: {this.id}";
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Employee)
                {
                    Employee other = obj as Employee;
                    if (this == other)
                        return true;

                    if (!this.id.Equals(other.id))
                        return false;

                    return true;
                }
                else
                {
                    ArgumentException ex = new ArgumentException($"argument of type {obj.GetType().Name} was passed instead of {this.GetType().Name}");
                    throw ex;
                }
            }
            else
            {
                NullReferenceException ex = new NullReferenceException($"null reference was passed to Equals method");
                throw ex;
            }
        }
    }
}
