using System;

namespace GraphQL
{
    /// <summary>
    /// Does not add the marked property to the auto-registered GraphQL type as a field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class IgnoreAttribute : Attribute
    {
    }
}
