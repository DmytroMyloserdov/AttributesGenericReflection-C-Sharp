using System;
using System.Collections.Generic;

namespace InstancesAndAttributes.Attributes.AgeClass
{
    public class Advanteges
    {
        private static List<string> child = new List<string>()
        {
            "A lot of free time",
            "A lot of energy",
            "Can choose own world-way"
        };
        private static List<string> youth = new List<string>()
        {
            "A lot of opportunities",
            "Reflictions (by Sasha)"
        };
        private static List<string> midaged = new List<string>()
        {
            "Own family",
            "No restrictions"
        };
        private static List<string> elder = new List<string>()
        {
            "A lot of free time",
            "Can choose any hobby"
        };

        public static List<string> GetAdvantages(string name)
        {
            switch (name)
            {
                case Names.Child:
                    return child;
                case Names.Youth:
                    return youth;
                case Names.MiddleAged:
                    return midaged;
                case Names.Elder:
                    return elder;
                default:
                    throw new ArgumentException("name");
            }
        }
    }
}
