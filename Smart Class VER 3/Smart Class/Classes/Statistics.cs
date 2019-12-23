using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Class
{
    class Statistics
    {
   
       public int testsTaken { get;private set; }
       public int correctAnswers { get; private set; }
        public int totalAnswers { get; private set; }

       public LinkedList<SubjectStatistics> subjectStatistics;

        public void IncreaseTakenTests()
        {
            this.testsTaken++;
        }

        public void IncreaseCorrectAnswers()
        {
            this.testsTaken++;
        }

        public void IncreaseTotalAnswers()
        {
            this.testsTaken++;
        }
    }
}
