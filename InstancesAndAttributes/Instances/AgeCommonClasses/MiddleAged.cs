using InstancesAndAttributes.Actions;
using InstancesAndAttributes.Attributes.AgeClass;
using InstancesAndAttributes.Instances.CommonIClasses;
using InstancesAndAttributes.Instances.Interfaces;
using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Instances.AgeCommonClasses
{
    [AgeClass(Names.MiddleAged)]
    public class MiddleAged : WorkablePerson<Elder>, IMiddleAged<Elder>
    {
        public string OldLastName { get; set; }
        public string CoupleName { get; set; }
        public bool IsMarried { get; set; }

        public MiddleAged() { }
        public MiddleAged(string[] pName, DateTime bDate)
            : base(pName, bDate)
        {
            OldLastName = pName[1];
        }
        public MiddleAged(string pName, DateTime bDate)
            : base(pName, bDate)
        {
            OldLastName = pName.Split(' ')[1];
        }

        public void Divorce()
        {
            FullName[0] = OldLastName;
            IsMarried = false;
        }
        public void GetMarried(string newLastName, string coupleName)
        {
            CoupleName = coupleName;
            FullName[0] = newLastName;
            IsMarried = true;
        }
        public void GetMarried(string coupleName)
        {
            CoupleName = coupleName;
            IsMarried = true;
        }

        public override Elder GoNextAge()
        {
            Elder upgradePerson = new Elder();
            Mapping.Map(this, ref upgradePerson);
            return upgradePerson;
        }
        public override string ToString()
        {
            return Overrided.ToString(this);
        }
        public override List<string> GetAgeAdvantages()
        {
            return GetAttributeParams.GetAdvantages<MiddleAged>();
        }
    }
}
