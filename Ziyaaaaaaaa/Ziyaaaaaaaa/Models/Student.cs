using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ziyaaaaaaaa.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        
        public int Age { get; set; }
        public Standard standard { get; set; }

        public class Standard
        {
            public int StandardId { get; set; }
            public string StandardName { get; set; }
        }

        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
    


}