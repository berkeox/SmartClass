using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Class
{
    class Student :User
    {
        private static Student student;

        LinkedList<Test> tests;
        Statistics statistics;


        private Student(string name,string surname,string email)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            
        }

        public static Student GetInstance(string name,string surname,string email)
        {
             student = new Student(name,surname,email);
             return student;

        }
        public static Student GetInstance()
        {
            return student;
        }
    

    }
}
