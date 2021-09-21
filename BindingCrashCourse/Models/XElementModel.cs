using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BindingCrashCourse.Models
{
    public class XElementModel
    {
        public XElementModel(XElement node, XElementModel parent)
        {
            this.linqNode = node;
            this.parent = parent;
        }
        public XElement linqNode;
        public string Name
        {
            get
            {
                if (linqNode != null)
                    return linqNode.Name.ToString();
                else
                    return null;
            }
        }
        public List<XElementModel> Children { get; set; } = new List<XElementModel>();
        public XElementModel parent { get; set; }
    }
}
