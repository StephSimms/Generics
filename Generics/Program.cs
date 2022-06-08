using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<Things> employee = new Employee<Things>();
            Employee employee = new Employee();

            employee.fName = new List<string>() { " Steph " , " Spencer ", " Devlan "};
            employee.lName = new List<string>() { " Simms " , " Simms ", " Simms "};
            employee.ID = new List<int>() { 7, 13, 21 };
        }
    }
}
