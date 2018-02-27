using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMVCApp.Data;
using MyFirstMVCApp.Entities;
namespace MyFirstMVCApp.BussinessLogic
{
    public class BLLProfessor
    {
        public Professor getProfessor() {
            return new DALProfessor().getProfessorDetails();
        }
    }
}

