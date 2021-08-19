
using Contract.Enums;
using System.Collections.Generic;

namespace Contract.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        private List<HourContract> list = new List<HourContract>();


        public Worker(string name, WorkerLevel level, double salary)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
        }

        public void addContract(HourContract contract)
        {
            list.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            list.Remove(contract);
        }

        public double  income(int year, int month)
        {
            double income = BaseSalary;

            foreach (HourContract contract in list)
            {
                if (contract.Date.Year == year && contract.Date.Month == month )
                {
                    income += contract.totalValue();
                }
            }

            return income;
        }

    }
}
