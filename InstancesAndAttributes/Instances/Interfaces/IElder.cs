namespace InstancesAndAttributes.Instances.Interfaces
{
    interface IElder<TNextAge> : IAgable<TNextAge> where TNextAge : class
    {
        decimal Pension { get; set; }
        int WorkedYears { get; set; }

        void Retire(int workedYears, decimal pensoin);
        TNextAge Die();
    }
}
