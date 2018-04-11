using InstancesAndAttributes.Actions;
using InstancesAndAttributes.Attributes.AgeClass;
using InstancesAndAttributes.Instances.Interfaces;
using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Instances.AgeCommonClasses
{
    [AgeClass(Names.Child)]
    public class Child : Person<Youth>, IChild<Youth>
    {
        public string Hobby { get; set; }
        public bool IsLearning { get; set; }
        public int Form { get; set; }
        public string SchoolName { get; set; }
        public List<string> ListOfMusic { get; set; }
        public int FinishYear { get; set; }
        public int StartLearningYear { get; set; }
        public int ExpectedFinishYear { get; set; }
        public Dictionary<string, int> FinalTestResults { get; set; }
        public Dictionary<int, Dictionary<string, int>> SchoolScoreSheet { get; set; }

        public Child(string[] pName, DateTime bDate)
            : base(pName, bDate)
        {
            SchoolScoreSheet = new Dictionary<int, Dictionary<string, int>>();
            FinalTestResults = new Dictionary<string, int>();
            ListOfMusic = new List<string>();
            Form = 1;
        }
        public Child(string pName, DateTime bDate)
            : base(pName, bDate)
        {
            SchoolScoreSheet = new Dictionary<int, Dictionary<string, int>>();
            FinalTestResults = new Dictionary<string, int>();
            ListOfMusic = new List<string>();
            Form = 1;
        }

        public override Youth GoNextAge()
        {
            Youth upgradePerson = new Youth();
            Mapping.Map(this, ref upgradePerson);
            return upgradePerson;
        }
        public override string ToString()
        {
            return Overrided.ToString(this);
        }
        public override List<string> GetAgeAdvantages()
        {
            return GetAttributeParams.GetAdvantages<Child>();
        }

        public void SetMarks(Dictionary<string, int> markScore)
        {
            SchoolScoreSheet.Add(Form, markScore);
            Form++;
        }
        public void StartLearning(string schoolName)
        {
            SchoolName = schoolName;
            IsLearning = true;
            StartLearningYear = DateTime.Now.Year;
            ExpectedFinishYear = StartLearningYear + 11;
        }
        public void EndLearning()
        {
            IsLearning = false;
            FinishYear = DateTime.Now.Year;
        }
        public void SetFinalTestResult(string finalObject, int mark)
        {
            FinalTestResults.Add(finalObject, mark);
        }
        public void AddMusic(string name)
        {
            ListOfMusic.Add(name);
        }
        public void AddRangeOfMusic(string[] names)
        {
            ListOfMusic.AddRange(names);
        }
        public void AddRangeOfMusic(List<string> names)
        {
            ListOfMusic.AddRange(names);
        }
    }
}
