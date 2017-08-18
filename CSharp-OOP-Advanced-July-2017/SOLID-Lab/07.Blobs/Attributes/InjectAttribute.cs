using System;

namespace _02.Blobs.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class InjectAttribute : Attribute
    {

    }
}