using System.Collections.Generic;

namespace InstancesAndAttributes.Instances.Interfaces
{
    interface IYouth<TNextAge> : IAgable<TNextAge> where TNextAge : class
    {
        string UniversityName { get; set; }
        int Course { get; set; }
        Dictionary<int, Dictionary<string, int>> ScoreSheet { get; set; }
        int StartYear { get; set; }
        int ExpectedGradYear { get; set; }
        int GradYear { get; set; }

        void GoToUniversity(string name);
        void SetMarks(Dictionary<string, int> markScore);
        void Graduate();
    }
}
