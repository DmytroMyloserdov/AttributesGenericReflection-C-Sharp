using System;

namespace InstancesAndAttributes.Instances.Interfaces
{
    interface IWorkable
    {
        decimal CurrentBalance { get; set; }
        decimal Salary { get; set; }
        decimal YearSalary { get; set; }
        DateTime LastDayOfSalary { get; set; }
        DateTime DayOfSalary { get; set; }
        string Position { get; set; }
        string ReasonOfLostLastJob { get; set; }

        void GetSalary();
        void GetBonus(decimal bonusValue);
        void GetJob(decimal salary, string position);
        void LoseJob(string reason);
    }
}
