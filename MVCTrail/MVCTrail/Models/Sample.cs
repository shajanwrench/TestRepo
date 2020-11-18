using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTrail.Models
{
    public class StudentInfo
    {
        public int SID { get; set; }
        public string SName { get; set; }
        public string SNo { get; set; }
        public List<Marks> marks { get; set; }
    }

    public class Marks
    {
        public int Mark { get; set; }
        public int MaxMark { get; set; }
    }
}