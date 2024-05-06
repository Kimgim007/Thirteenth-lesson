using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirteenth_lesson
{
    public class User
    {

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


        //Напишите метод, который возвращает
        //"<FirstName> <MiddleName>
        //<LastName>", если отчество присутствует Или "<FirstName> <LastName>", если
        //отчество отсутствует.


        public string GenerateFullName()
        {
            if (LastName != null)
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }
            else
            {
                return $"{FirstName} {LastName}";
            }
        }



    }
}
