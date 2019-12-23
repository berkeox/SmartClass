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

        public LinkedList<Test> tests;
       public Statistics statistics;


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

        public SubjectStatistics SearchStudentSubjectStatistics(string subjectName)
        {
            LinkedListNode<SubjectStatistics> subjectStatNode = this.statistics.subjectStatistics.First;

            while (subjectStatNode != null)
            {
                if (subjectStatNode.Value.subjectName == subjectName)
                {
                    return subjectStatNode.Value;
                }

                subjectStatNode = subjectStatNode.Next;
            }
            return null;
        }

        public LinkedList<string> SearchWorstSubjects()
        {
            LinkedList<SubjectStatistics> tempsubjectStat = this.statistics.subjectStatistics;
            tempsubjectStat.OrderBy(subject=>subject.correctAnswered/ subject.totalAnswered);
      



        }
    

    }
}
