using System;
using System.Collections.Generic;
using System.Text;

namespace ExempLinq.Entities
{
    class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }

        public Category() { }

        public Category(int id, string name, int tier)
        {
            Id = id;
            Name = name;
            Tier = tier;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Tier;
        }

    }
}
