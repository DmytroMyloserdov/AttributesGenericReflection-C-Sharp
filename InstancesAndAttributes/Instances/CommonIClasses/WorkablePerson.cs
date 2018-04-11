using InstancesAndAttributes.Instances.Interfaces;
using System;

namespace InstancesAndAttributes.Instances.CommonIClasses
{
    public abstract class WorkablePerson<TNextAge> : Person<TNextAge>, IWorkable where TNextAge : class, new()
    {
        public decimal Salary { get; set; }
        public decimal YearSalary { get; set; }
        public DateTime LastDayOfSalary { get; set; }
        public DateTime DayOfSalary { get; set; }
        public string Position { get; set; }
        public string ReasonOfLostLastJob { get; set; }
        public decimal CurrentBalance { get; set; }

        public WorkablePerson() { }
        public WorkablePerson(string[] pName, DateTime bDate)
            : base(pName, bDate)
        { }
        public WorkablePerson(string pName, DateTime bDate)
            : base(pName, bDate)
        { }

        public void GetSalary()
        {
            if (DateTime.Now.Day >= DayOfSalary.Day && DayOfSalary.Month - LastDayOfSalary.Month >= 1)
            {
                CurrentBalance += Salary * (DayOfSalary.Month - LastDayOfSalary.Month);
                DayOfSalary.AddMonths(1);
                LastDayOfSalary.AddMonths(DayOfSalary.Month - LastDayOfSalary.Month);
            }
        }
        public void GetBonus(decimal bonusValue)
        {
            CurrentBalance += bonusValue;
        }
        public void GetJob(decimal salary, string position)
        {
            Salary = salary;
            YearSalary = salary * 12;
            Position = position;
            LastDayOfSalary = DateTime.Now;
        }
        public void LoseJob(string reason)
        {
            ReasonOfLostLastJob = reason;
        }
    }
}
