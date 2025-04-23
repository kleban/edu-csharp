using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Helpers
{
    public class CinemaHelper
    {
        static string[] ageRatings = new string[]
        {
            "G",        // General Audience – для всіх
            "PG",       // Parental Guidance – з батьківським наглядом
            "PG-13",    // Дітям до 13 не бажано
            "R",        // Обмеження – до 17 тільки з дорослими
            "NC-17",    // Тільки для дорослих (18+)
            "16+",      // Український стандарт (з 16 років)
            "18+"       // Український стандарт (з 18 років)
        };

        public static List<string> AgeRatings
        {
            get
            {
                return ageRatings.ToList();
            }
        }

        static string[] genres = new string[]
      {
        "Action",
        "Adventure",
        "Comedy",
        "Drama",
        "Horror",
        "Thriller",
        "Fantasy",
        "Science Fiction",
        "Romance",
        "Documentary",
        "Animation",
        "Mystery",
        "Crime",
        "Musical",
        "Family"
      };

        public static List<string> Genres
        {
            get
            {
                return genres.ToList();
            }
        }
        public static string GetRandomGenre()
        {
            Random random = new Random();
            int index = random.Next(0, genres.Length);
            return genres[index];
        }
        public static string GetRandomAgeRating()
        {
            Random random = new Random();
            int index = random.Next(0, ageRatings.Length);
            return ageRatings[index];
        }
    }
}
