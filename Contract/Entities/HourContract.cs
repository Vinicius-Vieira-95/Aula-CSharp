using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.Entities
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePorHour { get; set; }
        public int Hour { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePorHour = valuePerHour;
            Hour = hour;
        }

        public double totalValue()
        {
            return ValuePorHour * Hour;
        }

    }
}
