using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1T5M9_11.Entities
{
    class HourContract
    {
        public DateTime _date { get; private set; }
        private double _valuePerHour;
        private double _hour;

        public HourContract(DateTime date, double valuePerHour, double hour)
        {
            _date = date;
            _valuePerHour = valuePerHour;
            _hour = hour;
        }

        public double ContractValue() => _valuePerHour * _hour;
    }
}
