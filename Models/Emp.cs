using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCodeFirst.Models
{
    public class Emp
    {
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public string Edesig { get; set; }
        public DateTime Edoj { get; set; }
    }
}