using System;

namespace MovieDatabaseApp
{
    public class Movie
    {
        public string Title { get; }
        public int Year { get; }
        Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
    }
}
