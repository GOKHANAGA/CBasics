using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Giyotin
{
    [DataContract]
    class Person
    {
        public Person()
        {

        }

        public Person(string FirstName,string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }


        public override string ToString()
        {
            return FirstName+" "+LastName;
        }
    }
}
