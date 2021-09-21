using System;
using System.Collections.Generic;
using System.Text;

namespace BindingCrashCourse
{
    public class TreeObject
    {
        public List<TreeObject> Children { get; set; }
        public string NodeName { get; set; }
        public TreeObject(string name, List<TreeObject> children) 
        {
            Children = children;
            NodeName = name;
        }
    }
}
