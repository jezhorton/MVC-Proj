using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC2017Version.Models
{
    public class Customer
    {
        string firstName = "", lastName = "";
        int age = 0;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
    }
}