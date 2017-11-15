using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    public class Student
    {
        /*----Members----*/
        /*----1.Field----*/
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private int _sgkNo = 0;
        /*----Class altında tanımlanan değişkenlere field denir,
         * ----önlerine '_' konarak isimlendirilirler
         *----Değişkenlerden hiç bir farkı yoktur----*/



        /*----Methods----*/
        public int GetAge()
        {
            int age = DateTime.Now.Year - _dateOfBirth.Year;
            return age;
        }


        /*----Properties----*/
        /*----Field gibi değer tutmaz ama taşır.----*/
        /*----Get ve Set silinirse Property değil field tanımlamış olunur----*/
        /*----Get olmadan set olmaz,erişilemeyen alana değer atanamaz----*/
        public int studentNumber { get; set; }

        public string lastName { 
            get 
            {
                return _lastName;
            }
            set
            {
                if (value != string.Empty)
                {
                _lastName = value;
                }
                else
                {
                    _lastName = "Öğrenci";
                }
            }
        }

        public bool IsHaveClothes { get; set; }

        public int sgkNo
        {
            /*----Sadece değer almak için kullanılır değer değişikliği yapılamaz----*/
            get
            {
                return _sgkNo;
            }
            
            
        }

       

    }

    
}
