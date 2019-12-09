using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Smart_Class
{
    public class Question
    {
        public string description { get; private set; }
        public string questionText { get; private set; }
        public string correctAnswer { get; private set; }
        public string falseAnswerFirst { get; private set; }
        public string falseAnswerSecond { get; private set; }
        public string falseAnswerThird { get; private set; }
        public Image questionPicture { get; private set; }
        public string subject { get; private set; }


        public Question(string description, string questionText, string correctAnswer,string falseAnswerFirst, string falseAnswerSecond, string falseAnswerThird,Image questionPicture,string subject)
        {
            this.description = description;
            this.questionText = questionText;
            this.correctAnswer = correctAnswer;
            this.falseAnswerFirst = falseAnswerFirst;
            this.falseAnswerSecond = falseAnswerSecond;
            this.falseAnswerThird = falseAnswerThird;
            this.questionPicture = questionPicture;
            this.subject = subject;
        }
    }
}
