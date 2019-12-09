using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Smart_Class
{
    class Teacher : User
    {
        private static Teacher teacher;

       public  string branch;

        private Teacher(string name,string surname,string email,string branch )
        {
            this.branch = branch;
            this.name = name;
            this.surname = surname;
            this.email = email;
           
        }

        public static Teacher GetInstance(string name, string surname, string email, string branch)
        {            
            teacher = new Teacher(name,surname,email,branch);
            return teacher;
        }
        public static Teacher GetInstance()
        {
            return teacher;
        }
    }
}
