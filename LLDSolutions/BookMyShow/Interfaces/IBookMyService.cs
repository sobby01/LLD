using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.BookMyShow.Interfaces
{
    public interface IBookMyService
    {
        public List<Movie> GetAllMovies(DateTime date, string city);

        public List<CinemaHalls> GetAllCinemaHalls(string city);
    }
}
