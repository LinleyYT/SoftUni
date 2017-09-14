namespace _12.Google
{
    public class Company
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Company(string name, string dept, decimal salary)
        {
            this.Name = name;
            this.Department = dept;
            this.Salary = salary;
        }
    }
}