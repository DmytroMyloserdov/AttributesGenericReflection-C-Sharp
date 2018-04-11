using InstancesAndAttributes.Actions;
using InstancesAndAttributes.Instances.AgeCommonClasses;
using InstancesAndAttributes.Instances.Interfaces;
using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Instances
{
    public abstract class Person<TNextAge> : IAgable<TNextAge> where TNextAge : class, new()
    {
        public string[] FullName { get; set; }
        public DateTime Birth { get; set; }
        public int Years
        {
            get
            {
                if (DateTime.Now.Month - Birth.Month > 0)
                {
                    return DateTime.Now.Year - Birth.Year;
                }
                else if (DateTime.Now.Month - Birth.Month == 0)
                {
                    if (DateTime.Now.Day - Birth.Day >= 0)
                    {
                        return DateTime.Now.Year - Birth.Year;
                    }
                    else
                    {
                        return DateTime.Now.Year - Birth.Year - 1;
                    }
                }
                else
                {
                    return DateTime.Now.Year - Birth.Year - 1;
                }
            }
        }

        public Person(string[] pName, DateTime bDate)
        {
            FullName = pName;
            Birth = bDate;
        }
        public Person(string pName, DateTime bDate)
        {
            FullName = pName.Split(' ');
            Birth = bDate;
        }
        public Person() { }

        public abstract TNextAge GoNextAge();
        public abstract List<string> GetAgeAdvantages();

        public bool InNextAge()
        {
            var range = GetAttributeParams.GetAgeRanges<TNextAge>();
            return (Years >= range.From && Years <= range.To);
        }
        public DeadPerson Die()
        {
            return new DeadPerson(FullName, Birth);
        }
    }
}
