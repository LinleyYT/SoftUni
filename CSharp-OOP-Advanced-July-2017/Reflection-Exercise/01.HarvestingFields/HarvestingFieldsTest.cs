using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _01HarestingFields
{
    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type classType = typeof(HarvestingFields);
            FieldInfo[] fieldsInfo =
                classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var accModFilterDict = new Dictionary<string, Func<FieldInfo[]>>()
            {
                {"private", () => fieldsInfo.Where(f => f.IsPrivate).ToArray()},
                {"protected", () => fieldsInfo.Where(f => f.IsFamily).ToArray()},
                {"public" , () => fieldsInfo.Where(f => f.IsPublic).ToArray()},
                {"all", () => fieldsInfo}
            };
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "HARVEST")
            {
                accModFilterDict[input]()
                    .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                    .ToList()
                    .ForEach(r => Console.WriteLine(r.Replace("family", "protected")));
            }
        }
    }
}
