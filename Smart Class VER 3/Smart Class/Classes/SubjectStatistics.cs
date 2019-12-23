using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Class
{
    class SubjectStatistics
    {
      public  string subjectName { get; private set; }
       public int totalAnswered { get; private set; }
       public int correctAnswered { get; private set; }


       public SubjectStatistics(string subjectName)
       {
           this.subjectName = subjectName;
           this.totalAnswered = 1;
           this.correctAnswered = 0;
       }

       public void IncreaseTotalAnswered()
       {
           this.totalAnswered++;
       }

       public void IncreaseCorrectAnswered()
       {
           this.correctAnswered++;
       }
    }
}
