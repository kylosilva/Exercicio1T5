using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1T5M9_11.Entities
{
    class Worker
    {
        public string _name { get; private set; }
        private double _baseSal;
        public static List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, double baseSal)
        {
            _name = name;
            _baseSal = baseSal;
        }

        public static void AddContract(HourContract contract) => Contracts.Add(contract);

        public static void RemoveContract(HourContract contract) => Contracts.Remove(contract);

        public double TotalValue(int month, int year)
        {
            double total = _baseSal;

            foreach (HourContract ch in Contracts)
            {
                if ((ch._date.Year == year) && (ch._date.Month == month))
                    total += ch.ContractValue();
            }

            return total;
        }
    }
}
