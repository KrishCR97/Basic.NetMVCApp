using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMVCApp.Entities;

namespace MyFirstMVCApp.Data
{
    public class DALProfessor
    {
        public Professor getProfessorDetails() {
            Professor prof = new Professor();
            prof.FirstName = "Shawn";
            prof.LastName = "Marsh";
            prof.ProfessorID = 919547809;
            prof.DepartmentName = "Satistics";
            return prof;
        }
    }
}

