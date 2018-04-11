using InstancesAndAttributes.Attributes.AgeClass;
using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Actions
{
    public class GetAttributeParams
    {
        public static RangeOfAgeClasses GetAgeRanges<T>() where T : class
        {
            return (Attribute.GetCustomAttribute(typeof(T), typeof(AgeClassAttribute), true) as AgeClassAttribute).Ranges;
        }
        public static List<string> GetAdvantages<T>() where T : class
        {
            return (Attribute.GetCustomAttribute(typeof(T), typeof(AgeClassAttribute), true) as AgeClassAttribute).Advanteges;
        }
    }
}
