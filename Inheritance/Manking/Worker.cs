namespace Manking
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workingHours;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkingHours
        {
            get { return this.workingHours; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHours = value;
            }
        }

        private decimal CalculateSalaryPerHour()
        {
            return WeekSalary / (WorkingHours * 5m);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}")
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkingHours:f2}")
                .AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():f2}");

            return sb.ToString();
        }
    }
}