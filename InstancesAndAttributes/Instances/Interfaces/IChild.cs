using System.Collections.Generic;

namespace InstancesAndAttributes.Instances.Interfaces
{
    interface IChild<TNextAge> : IAgable<TNextAge> where TNextAge : class
    {
        string Hobby { get; set; }
        bool IsLearning { get; set; }
        int Form { get; set; }
        string SchoolName { get; set; }
        List<string> ListOfMusic { get; set; }
        int FinishYear { get; set; }
        int StartLearningYear { get; set; }
        int ExpectedFinishYear { get; set; }
        Dictionary<string, int> FinalTestResults { get; set; }
        Dictionary<int, Dictionary<string, int>> SchoolScoreSheet { get; set; }

        void EndLearning();
        void SetFinalTestResult(string finalObject, int mark);
        void StartLearning(string schoolName);
        void SetMarks(Dictionary<string, int> markScore);
        void AddMusic(string name);
        void AddRangeOfMusic(string[] names);
        void AddRangeOfMusic(List<string> names);
    }
}
