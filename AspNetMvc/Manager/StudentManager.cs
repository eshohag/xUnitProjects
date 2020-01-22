using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc.Manager
{
  public  class StudentManager
    {
        public bool IsValid(string aNumber)
        {
            return aNumber == "Test" ? true : false;
        }
    }
}
