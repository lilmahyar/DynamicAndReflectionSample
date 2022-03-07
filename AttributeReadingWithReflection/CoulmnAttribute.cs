using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeReadingWithReflection
{
    [AttributeUsage(
        AttributeTargets.Property|AttributeTargets.Method
        ,AllowMultiple=false)]

    public class CoulmnAttribute  : Attribute
    {
        public CoulmnAttribute(string name)
        {
            Name = name; 
        }
        public string Name { get; set; }
        public string  Format { get; set; }
    }
}
