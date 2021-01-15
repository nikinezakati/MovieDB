using System.ComponentModel.DataAnnotations;
using System;
namespace Movie.ASM
{
    public class Search
    {
        [Required (ErrorMessage = "Search bar Cannot be Empty", AllowEmptyStrings=false)]
        public string MovieName{get; set;}
    }

}

