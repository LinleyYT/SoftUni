using System;
using System.Collections.Generic;

namespace _10.CreateCustomClassAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class WeaponCustomAttribute : Attribute
    {
        public WeaponCustomAttribute(string author, int revisions, string description, params string[] strings)
        {
            this.Author = author;
            this.Revisions = revisions;
            this.Description = description;
            this.Reviewers = new List<string>(strings);
        }

        public string Author { get; private set; }
        public int Revisions { get; private set; }
        public string Description { get; private set; }
        public List<string> Reviewers { get; private set; }
    }
}