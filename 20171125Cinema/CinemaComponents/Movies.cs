using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComponents
{
    public class Movies:DictionaryOperations<Movie>
    {
        private Dictionary<string,Movie> movieList;
        private static Movies _moviesInstance;

        private Movies()
        {
            movieList =new Dictionary<string, Movie>();
        }

        public static Movies GetInstance()
        {
            if (_moviesInstance == null)
            {
                _moviesInstance = new Movies();
            }

            return _moviesInstance;
        }

        public override void AddComponent(Movie componentType)
        {
            /*Movie Name + Release Date = MovieID*/
            componentType.MovieID = componentType.MovieName + componentType.Release.FirstDayOfRelease.Year.ToString();
            movieList.Add(componentType.MovieID,componentType);
        }

        public override void DeleteComponent(Movie componentType)
        {
            movieList.Remove(componentType.MovieID);
        }

        public override Dictionary<string, Movie> GetComponents()
        {
            return movieList;
        }

        public override bool IsEmpty()
        {
            if (movieList.Count == 0)
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
