using System;
using System.ComponentModel.DataAnnotations;
namespace Shared
{
    public class MovieModel
    {
        [Key]
        public string Title{get;set;}
        public string Genre{get;set;}
        public string Description{get;set;}
        public string Director{get;set;}
        public string Actors{get;set;}
        public int Year{get;set;}
        public int Runtime{get;set;}
        public float Rating{get;set;}
        public long Votes{get;set;}
    }
}