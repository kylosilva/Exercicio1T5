using System;
using Ex1T5M9_11.Entities.Enum;
using Ex1T5M9_11.Entities;

namespace Ex1T5M9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerData();
        }

        static void WorkerData()
        {
            Console.Write("\nEnter department's name --> ");
            string name = Console.ReadLine();
            Department department = new Department(name);

            Console.WriteLine("\n\nEnter worker data: ");
            Console.Write("\tName --> ");
            string workerName = Console.ReadLine();
            Console.Write("\tLevel (Junior/MidLevel/Senior) --> ");
            WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("\tBase salary --> ");
            double baseSal = double.Parse(Console.ReadLine());

            Worker worker = new Worker(workerName, baseSal);

            Contracts();

            Console.Write("\n\nEnter the month and the year to calculate the total value (MM/YYYY): ");
            string valorData = Console.ReadLine();
            int mes = int.Parse(valorData.Substring(0, 2));
            int ano = int.Parse(valorData.Substring(3));

            Console.Clear();

            Console.WriteLine("\n\n\t" + department.ToString());
            Console.WriteLine("\tWorker name --> " + worker._name);
            Console.WriteLine("\tTotal value in {0} = {1:F2}", valorData, worker.TotalValue(mes, ano));
            Console.ReadKey();
        }

        static void Contracts()
        {
            Console.Write("\n\nHow many contracts to this worker? --> ");
            byte nContracts = byte.Parse(Console.ReadLine());

            for (int x = 1; x <= nContracts; x++)
            {
                Console.WriteLine($"\n\tEnter #{x} contract data:");
                Console.Write("\n\t\tDate (DD/MM/YYYY) --> ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("\t\tValue per hour --> ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("\t\tDuration (hour) --> ");
                double hour = double.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hour);
                Worker.AddContract(contract);
            }
        }
    }
}
