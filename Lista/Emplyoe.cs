using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lista
{
    class Emplyoe
    {

        public long Id { get; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Emplyoe(long id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void UpdateSalry(double salary)
        {
            Salary += salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
