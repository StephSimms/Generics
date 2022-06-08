using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        public List<T> fName { get; set; }
        public List<T> lName { get; set; }
        
    }
}
