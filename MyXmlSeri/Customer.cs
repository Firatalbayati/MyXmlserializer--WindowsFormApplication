using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXmlSeri
{
    public class Customer
    {
        [MyAttribute("id", isAttribute = true)]
        public int Id { get; set; }
        [MyAttribute("Adı")] 
        public string Name { get; set; }
        [MyAttribute("Soyadı")]
        public string SurName { get; set; }
        public string Email { get; set; }
        public string TcKimlikNo { get; set; }
        public string Address { get; set; }
        public string TelNo { get; set; }
        public int YearOfBirth { get; set; }



    }
}
