using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentsApp.Models
{
    public class Person
    {
        public string Salutation { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }

        public override string ToString() 
            => $"{Salutation} {GivenName} {FamilyName}";
    }
}