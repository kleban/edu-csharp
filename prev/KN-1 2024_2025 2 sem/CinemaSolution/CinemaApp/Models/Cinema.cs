using CinemaApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class Cinema
    {
        private List<Movie> movies;
        private List<Session> sessions;
        private List<string> halls = new List<string> { "#1", "#2", "#3" };
        public Cinema()
        {
            movies = new();
            sessions = new();
            generateMovies();
        }

        private void generateMovies()
        {
            movies.Add(new Movie { Id = 1, Title = "Inception", Genre = CinemaHelper.GetRandomGenre(), Duration = 148, AgeRating = CinemaHelper.GetRandomAgeRating() });
            movies.Add(new Movie { Id = 2, Title = "The Godfather", Genre = CinemaHelper.GetRandomGenre(), Duration = 175, AgeRating = CinemaHelper.GetRandomAgeRating() });
            movies.Add(new Movie { Id = 3, Title = "The Dark Knight", Genre = CinemaHelper.GetRandomGenre(), Duration = 152, AgeRating = CinemaHelper.GetRandomAgeRating() });
            movies.Add(new Movie { Id = 4, Title = "Pulp Fiction", Genre = CinemaHelper.GetRandomGenre(), Duration = 154, AgeRating = CinemaHelper.GetRandomAgeRating() });
        }

        private bool isSessionTimeValid(Session session)
        {
            foreach (var existingSession in sessions.Where(s => s.Hall == session.Hall))
            {
                if (session.StartTime < existingSession.EndTime && session.EndTime > existingSession.StartTime)
                {
                    return false; 
                }
            }
            return true; 
        }

        public bool AddSession(Session session)
        {
            if (isSessionTimeValid(session))
            {
                sessions.Add(session);
                return true;
            }
            return false;
        }
        public void AddMovie(Movie movie)
        {
            movie.Id = movies.Max(x => x.Id) + 1;
            movies.Add(movie);
        }
        public void RemoveSession(Session session)
        {
            sessions.Remove(session);
        }

        public bool RemoveMovie(Movie movie)
        {
            if (sessions.Any(s => s.Movie == movie))
            {
                return false; 
            }
            movies.Remove(movie);
            return true;
        }
        public List<Session> GetSessions()
        {
            return sessions;
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public List<string> GetHalls()
        {
            return halls;
        }

        public void UpdateMovie(Movie movie)
        {
            int index = movies.FindIndex(m => m.Id == movie.Id);
            if (index != -1)
            {
                movies[index] = movie;
            }
        }
    }
}
