using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giyotin
{
    class People
    {
        private static People _people;
        private static HashSet<Person> peopleList = new HashSet<Person>();


        private People()
        {

        }

        public static People GetPeople()
        {
            if (_people == null)
            {
                _people = new People();
            }

            return _people;
        }

 
        public static void AddPerson(Person person){
            peopleList.Add(person);
        }

        public static void DeletePerson(Person person)
        {
            peopleList.Remove(person);
        }

        public static void DeletePerson(int element)
        {
            peopleList.Remove(peopleList.ElementAt(element));
        }


        public static HashSet<Person> GetList()
        {
            return peopleList;
        }
    }
}
