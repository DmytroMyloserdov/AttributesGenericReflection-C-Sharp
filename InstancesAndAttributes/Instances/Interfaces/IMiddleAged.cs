namespace InstancesAndAttributes.Instances.Interfaces
{
    interface IMiddleAged<TNextAge> : IAgable<TNextAge> where TNextAge : class
    {
        string OldLastName { get; set; }
        string CoupleName { get; set; }
        bool IsMarried { get; set; }

        void GetMarried(string newLastName, string coupleName);
        void GetMarried(string coupleName);
        void Divorce();
    }
}
