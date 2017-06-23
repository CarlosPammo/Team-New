using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class Person: Contact
    {
        public string LastnameDad { get; set; }
        public string LastnameMom { get; set; }
        public string Photo { get; set; }
    }
}
