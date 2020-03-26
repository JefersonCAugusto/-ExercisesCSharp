using System.Collections.Generic;
using Exercicio1.Entities.Enums;
namespace Exercicio1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income( int month, int year)
        {
            double sum = BaseSalary;
            foreach (HourContract ctr in Contracts)
            {
                if (ctr.Date.Year == year && ctr.Date.Month == month)
                {
                    sum += ctr.TotalValue();
                }
            }
            return sum;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nLevel: {Level}\nDepartamento{Department.Name}\nContracts:{Contracts.Count}";
        }
    }
}
