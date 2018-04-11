using InstancesAndAttributes.Instances.AgeCommonClasses;
using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = 2012;
            var child = new Child("John Smith", new DateTime(year, 4, 10));

            Console.WriteLine($"Advantages of child:");
            foreach (var advant in child.GetAgeAdvantages())
            {
                Console.WriteLine("\t" + advant);
            }

            child.AddMusic("Smoke On The Water");
            child.AddRangeOfMusic(new List<string>() { "Highway To Hell", "Thunder" });

            child.StartLearning("VTL");

            for (int i = 0; i < 11; i++)
            {
                Dictionary<string, int> marks = new Dictionary<string, int>();
                marks.Add("Object", i);
                child.SetMarks(marks);
                child.StartLearningYear--;
                child.ExpectedFinishYear--;
                child.Birth = new DateTime(--year, 4, 10);
            }

            child.SetFinalTestResult("Test", 12);

            child.EndLearning();
            child.Birth = new DateTime(--year, 4, 10);
            Console.WriteLine(child.ToString());

            Console.WriteLine("In next age:" + child.InNextAge() + "\n");

            if (child.InNextAge())
            {
                Console.WriteLine(child.GoNextAge().ToString());
            }

            Console.ReadLine();
        }
    }
}
