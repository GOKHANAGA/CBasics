using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
    [DataContract]
    class Person
    {
        /*----DataContractJsonSerializer sınıfıyle serialize edebilmek için DataContract'ı sınıfa DataMember ıda serialize edilecek üyelerin başına eklenir----*/
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return Name+" "+LastName+" "+BirthDate.ToShortDateString()+" "+Gender.ToString();
        }
    }
}
