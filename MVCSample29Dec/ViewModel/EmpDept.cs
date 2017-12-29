using MVCSample29Dec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample29Dec.ViewModel
{
    public class EmpDept
    {
        Employee e=new Employee();

        public string FirstName
        {
            get { return e.FirstName; }
            set { e.FirstName = value; }
        }

        Department d = new Department();

        public string DepartmentName
        {
            get { return d.DepartmentName; }
            set { d.DepartmentName = value; }
        }
    }

    

}