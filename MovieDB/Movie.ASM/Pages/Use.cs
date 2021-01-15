using System.Collections.Generic;

public class Use
{
    public string url{get;set;}
    public bool Signedin{get;set;}
    public bool FromMovie{get;set;}
    public Dictionary<string,List<string>> comments=new Dictionary<string,List<string>>();
}


   