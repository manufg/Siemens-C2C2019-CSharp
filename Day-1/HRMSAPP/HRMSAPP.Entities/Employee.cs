namespace HRMSAPP.Entities
{
    public class Employee
    {
        string name;
        int id;
        decimal basicPayment;
        decimal daPayment;
        decimal hraPayment;
        string projectName;
        decimal totalSalary;

        public Employee()
        {

        }
        public Employee(string name, int id, decimal basic, decimal da, decimal hra, string project = null)
        {
            this.name = name;
            this.id = id;
            this.basicPayment = basic;
            this.daPayment = da;
            this.hraPayment = hra;
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

        public string ProjectName
        {
            set => projectName = value;
            get => projectName;
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
        //public decimal TotalSalary
        //{
        //    get { return totalSalary; }
        //}
        //public decimal TotalSalary
        //{
        //    get => totalSalary;
        //}
        public decimal TotalSalary => totalSalary;

        public void CalculateSalary()
        {
           this.totalSalary = this.basicPayment + this.daPayment + this.hraPayment;
        }
    }
}
