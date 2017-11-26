using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaComponents
{
    public class MovieGenres:DictionaryOperations<MovieGenre>
    {
        private Dictionary<string, MovieGenre> genreList;
        private static MovieGenres _genreInstance;

        private MovieGenres()
        {
            genreList = new Dictionary<string, MovieGenre>();
        }

        public static MovieGenres GetInstance()
        {
            if (_genreInstance == null)
            {
                _genreInstance = new MovieGenres();
            }

            return _genreInstance;
        }

        public override void AddComponent(MovieGenre componentType)
        {
            genreList.Add(componentType.GenreName,componentType);
        }

        public override void DeleteComponent(MovieGenre componentType)
        {
            genreList.Remove(componentType.GenreName);
        }

        public override Dictionary<string, MovieGenre> GetComponents()
        {
            return genreList;
        }

        public override bool IsEmpty()
        {
            if (genreList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
