using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXmlSeri
{
    class MyAttribute:Attribute
    {
        public string Name { get; set; }

        public bool isAttribute { get; set; }

        public MyAttribute(string name)
        {
            this.Name = name;
        }
    }
}
