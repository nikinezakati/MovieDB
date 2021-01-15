using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

namespace Movie.API
{
    public class MovieRepository
    {
        private MovieDBContext _mdbContext;
        public MovieRepository(MovieDBContext mdb)
        {
            _mdbContext=mdb;
        }
        public List<string> FindByName(string name)
        {   
            List<string> result=new List<string>();
            var temp= _mdbContext.MovieData
                .Where(t=> t.Title.ToLower()==name.ToLower()).ToList();
            foreach (var t in temp)
            {
                result.Add(t.Title);
                result.Add(t.Genre);
                result.Add(t.Description);
                result.Add(t.Director);
                result.Add(t.Actors);
                result.Add(t.Year.ToString());
                result.Add(t.Runtime.ToString());
                result.Add(t.Rating.ToString());
                result.Add(t.Votes.ToString());
            }  
            return result;  
        }

        public List<string> GetAll()
        {
            return _mdbContext.MovieData.OrderBy(m=>m.Title).Select(m=>m.Title).ToList();
        }
    }
}