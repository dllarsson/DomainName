using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabaseApp
{
    class Review
    {
        User author;
        Movie movie;
        public string Title { get; }
        public string Content { get; }

        Review(User user, Movie movie, string title, string content)
        {
            author = user;
            this.movie = movie;
            Title = title;
            Content = content;
        }
    }
}
