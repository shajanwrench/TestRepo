using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTrail.Models;

namespace MVCTrail.Controllers
{
    public class SampleController : Controller
    {
        //
        // GET: /Sample/

        public ActionResult StudentInfo()
        {
            MVCTrail.Models.StudentInfo studInfo = new StudentInfo();
            studInfo.marks = new List<Marks>();
            studInfo.marks.Add(new Marks() { Mark=85, MaxMark=100 });
            studInfo.marks.Add(new Marks() { Mark = 86, MaxMark = 100 });
            studInfo.marks.Add(new Marks() { Mark = 87, MaxMark = 100 });
            studInfo.marks.Add(new Marks() { Mark = 88, MaxMark = 100 });
            return View(studInfo);
        }



    }
}
