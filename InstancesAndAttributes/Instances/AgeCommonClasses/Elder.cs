using InstancesAndAttributes.Actions;
using InstancesAndAttributes.Attributes.AgeClass;
using InstancesAndAttributes.Instances.Interfaces;
using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Instances.AgeCommonClasses
{
    [AgeClass(Names.Elder)]
    public class Elder : Person<DeadPerson>, IElder<DeadPerson>
    {
        public decimal Pension { get; set; }
        public int WorkedYears { get; set; }

        public Elder() { }
        public Elder(string[] pName, DateTime bDate)
            : base(pName, bDate) { }
        public Elder(string pName, DateTime bDate)
            : base(pName, bDate) { }


        public override DeadPerson GoNextAge()
        {
            return Die();
        }
        public override string ToString()
        {
            return Overrided.ToString(this);
        }
        public override List<string> GetAgeAdvantages()
        {
            return GetAttributeParams.GetAdvantages<Elder>();
        }

        public void Retire(int workedYears, decimal pensoin)
        {
            WorkedYears = workedYears;
            Pension = pensoin;
        }
    }
}
