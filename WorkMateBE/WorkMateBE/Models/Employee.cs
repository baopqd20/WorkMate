﻿namespace WorkMateBE.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationId {  get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public int DepartmentId { get; set; }
        public Department Department {  get; set; }

    }
}
