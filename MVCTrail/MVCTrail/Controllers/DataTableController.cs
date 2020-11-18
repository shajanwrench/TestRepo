using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTrail.Models;

namespace MVCTrail.Controllers
{
    public class DataTableController : Controller
    {
        //
        // GET: /DataTable/

        public ActionResult DisplayDataTable()
        {
            return View("DataTable");
        }

        public ActionResult getEmployeeDetails()
        {
            int ID = 1;
            List<EmployeeDetails> empDetails = new List<EmployeeDetails>();
            for (int count = 0; count < 100; count++)
            {
                empDetails.Add(new EmployeeDetails()
                {
                    EmpID = ID,
                    Name = "ABC" + ID,
                    Office = "EKM",
                    Position = "ADM",
                    Extn = 281,
                    StartDate = DateTime.Parse("01-Jan-2016"),
                    Salary = 25000
                });
                ID = ID + 1;
            }
            return Json(empDetails, JsonRequestBehavior.AllowGet);
        }
    }
}
