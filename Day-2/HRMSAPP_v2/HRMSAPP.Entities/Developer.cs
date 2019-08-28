using System;

namespace HRMSAPP.Entities
{
    public class Developer : Employee
    {
        decimal incentivePayment;
        string projectName;

        public Developer()
        {

        }
        public Developer(string name, int id, decimal basic, decimal da, decimal hra, decimal incentive, Designation designation, string project = null)
            : base(name, id, basic, da, hra, designation)
        {
            this.incentivePayment = incentive;
            this.projectName = project;
        }
        public string ProjectName
        {
            set => projectName = value;
            get => projectName;
        }
        public decimal IncentivePayment { get => incentivePayment; set => incentivePayment = value; }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalSalary = this.TotalSalary + this.incentivePayment;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
