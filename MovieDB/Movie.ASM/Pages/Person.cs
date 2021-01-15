using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Movie.ASM
{
    public class Person
    {
        public string UserName{get; set;}
        public string Password{get; set;}
        public Dictionary<string, string> Members = new Dictionary<string, string>();
    }

}
