using InstancesAndAttributes.Actions;
using InstancesAndAttributes.Attributes.AgeClass;
using InstancesAndAttributes.Instances.Interfaces;
using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Instances.AgeCommonClasses
{
    [AgeClass(Names.Youth)]
    public class Youth : Person<MiddleAged>, IYouth<MiddleAged>
    {
        public string UniversityName { get; set; }
        public int Course { get; set; }
        public Dictionary<int, Dictionary<string, int>> ScoreSheet { get; set; }
        public int StartYear { get; set; }
        public int ExpectedGradYear { get; set; }
        public int GradYear { get; set; }

        public Youth()
        {
            ScoreSheet = new Dictionary<int, Dictionary<string, int>>();
        }

        public override MiddleAged GoNextAge()
        {
            MiddleAged upgradePerson = new MiddleAged();
            Mapping.Map(this, ref upgradePerson);
            return upgradePerson;
        }
        public override string ToString()
        {
            return Overrided.ToString(this);
        }
        public override List<string> GetAgeAdvantages()
        {
            return GetAttributeParams.GetAdvantages<Youth>();
        }

        public void GoToUniversity(string name)
        {
            StartYear = DateTime.Now.Year;
            ExpectedGradYear = StartYear + 5;
            UniversityName = name;
            Course = 1;
        }
        public void Graduate()
        {
            GradYear = DateTime.Now.Year;
        }
        public void SetMarks(Dictionary<string, int> markScore)
        {
            ScoreSheet.Add(Course, markScore);
            Course++;
        }
    }
}
