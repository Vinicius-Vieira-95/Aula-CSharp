using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.Entities
{
    class Department
    {
        public string Name { get; set; }
        public Worker Worker { get; set; }

        public Department (string name, Worker worker)
        {
            Name = name;
            Worker = worker;
        }

        public override string ToString()
        {
            return "Name: " + Worker.Name
                   +"\nDepartment: " + Name;
        }
    }
}
