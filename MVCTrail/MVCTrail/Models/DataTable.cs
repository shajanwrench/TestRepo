using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTrail.Models
{
    public class EmployeeDetails
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Extn { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
    }
}