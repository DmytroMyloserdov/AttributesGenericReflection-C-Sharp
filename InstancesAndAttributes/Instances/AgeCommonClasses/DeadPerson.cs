using System;

namespace InstancesAndAttributes.Instances.AgeCommonClasses
{
    public class DeadPerson
    {
        public string[] Name { get; set; }
        public DateTime Born { get; set; }
        public DateTime Dead { get; set; }

        public DeadPerson() { }
        public DeadPerson(string[] name, DateTime born)
        {
            Name = name;
            Born = born;
            Dead = DateTime.Now;
        }
        public DeadPerson(string[] name, DateTime born, DateTime dead)
        {
            Name = name;
            Born = born;
            Dead = dead;
        }
    }
}
