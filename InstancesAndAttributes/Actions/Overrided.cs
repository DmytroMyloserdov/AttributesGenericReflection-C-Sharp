using System;
using System.Collections.Generic;
using System.Text;

namespace InstancesAndAttributes.Actions
{
    public class Overrided
    {
        public static string ToString<T>(T obj) where T : class
        {
            Type t = typeof(T);
            StringBuilder answer = new StringBuilder();
            answer.Append($"{ t.Name }:\n");
            foreach (var property in t.GetProperties())
            {
                var value = property.GetValue(obj) == null ? "NULL" : property.GetValue(obj);

                if (value.ToString() != "NULL")
                {
                    if (value is List<string>)
                    {
                        var list = value as List<string>;
                        var stringValue = new StringBuilder();
                        foreach (var el in list)
                        {
                            stringValue.Append("\t" + el + "\n");
                        }
                        value = stringValue.ToString();
                        answer.Append(property.Name + ":\n" + value);
                    }
                    else if (value is Dictionary<string, int>)
                    {
                        var dictionary = value as Dictionary<string, int>;
                        var stringValue = new StringBuilder();
                        foreach (var el in dictionary)
                        {
                            stringValue.Append("\t" + el.Key + " " + el.Value + "\n");
                        }
                        value = stringValue.ToString();
                        answer.Append(property.Name + ":\n" + value);
                    }
                    else if (value is Dictionary<int, Dictionary<string, int>>)
                    {
                        var dictionary = value as Dictionary<int, Dictionary<string, int>>;
                        var stringValue = new StringBuilder();
                        foreach (var el in dictionary)
                        {
                            stringValue.Append("\tForm:" + el.Key + "\n");
                            foreach (var sub in el.Value)
                            {
                                stringValue.Append("\t\t" + sub.Key + " " + sub.Value + "\n");
                            }
                        }
                        value = stringValue.ToString();
                        answer.Append(property.Name + ":\n" + value);
                    }
                    else if (value is string[])
                    {
                        var arr = value as string[];
                        var stringValue = new StringBuilder();
                        foreach (var str in arr)
                        {
                            stringValue.Append(str + " ");
                        }
                        value = stringValue.ToString();
                        answer.Append(property.Name + ":\n" + value + "\n");
                    }
                    else
                    {
                        answer.Append(property.Name + ":\n\t" + value + "\n");
                    }
                }
                else
                {
                    answer.Append(property.Name + ":\n\t" + value + "\n");
                }
            }

            return answer.ToString();
        }
    }
}
