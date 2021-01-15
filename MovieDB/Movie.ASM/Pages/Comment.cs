using System.ComponentModel.DataAnnotations;
using System;
namespace Movie.ASM
{
    public class Comment
    {
        [Required (ErrorMessage = "Comment Cannot be Empty", AllowEmptyStrings=false)]
        public string Context{get; set;}
    }

}

