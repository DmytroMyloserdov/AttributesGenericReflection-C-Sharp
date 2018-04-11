using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Attributes.AgeClass
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AgeClassAttribute : Attribute
    {
        public string ClassName { get; set; }
        public List<string> Advanteges { get; set; }
        public RangeOfAgeClasses Ranges { get; set; }

        public AgeClassAttribute(string className)
        {
            ClassName = className;
            Advanteges = AgeClass.Advanteges.GetAdvantages(className);
            Ranges = new RangeOfAgeClasses(className);
        }
    }

    public struct RangeOfAgeClasses
    {
        public int From, To;

        public RangeOfAgeClasses(string className)
        {
            switch (className)
            {
                case Names.Child:
                    From = 6;
                    To = 17;
                    break;
                case Names.Youth:
                    From = 18;
                    To = 24;
                    break;
                case Names.MiddleAged:
                    From = 25;
                    To = 60;
                    break;
                case Names.Elder:
                    From = 61;
                    To = 100;
                    break;
                default:
                    From = -1;
                    To = -1;
                    break;
            }
        }
    }
}
