using System;

namespace InstancesAndAttributes.Instances.Interfaces
{
    public interface IAgable<T> where T : class
    {
        DateTime Birth { get; set; }
        int Years { get; }

        bool InNextAge();
        T GoNextAge();
    }
}
