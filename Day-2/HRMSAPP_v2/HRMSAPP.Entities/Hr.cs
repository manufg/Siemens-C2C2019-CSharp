using System;

namespace HRMSAPP.Entities
{
    public sealed class Hr : Employee
    {
        decimal gratuityPayment;
        public Hr()
        {

        }
        public Hr(string name, int id, decimal basic, decimal da, decimal hra, decimal gratuity, Designation designation)
            : base(name, id, basic, da, hra, designation)
        {
            this.gratuityPayment = gratuity;
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalSalary = this.TotalSalary + gratuityPayment;
        }
        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }        
    }
}
