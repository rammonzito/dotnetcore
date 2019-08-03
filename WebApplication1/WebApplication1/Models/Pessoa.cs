using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebApplication1.Models
{
    [Serializable, XmlRoot("person")]
    public class Person
    {
        public string description { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public List<Person> ListPerson { get; set; }

        public Person()
        {
            this.ListPerson = new List<Person>();
        }
    }
}

