﻿namespace WorkMateBE.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int BaseSalary { get; set; }
        public int Bonus { get; set; }
        public int Deduction { get; set; }
        public int Total { get; set; }
        public DateTime PaidAt { get; set; }
        public DateTime SalaryMonth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int Status { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
