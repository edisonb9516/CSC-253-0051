using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string name, string id, string dept, string position)
        {
            Name = name;
            ID = id;
            Dept = dept;
            Position = position;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public string Dept { get; set; }
        public string Position { get; set; }

    }
}
