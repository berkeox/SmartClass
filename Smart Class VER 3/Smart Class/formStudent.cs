using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Class
{
    public partial class formStudent : Form
    {
        ToolTip Aciklama = new ToolTip();
       
        Point lastPoint;
        Student student = Student.GetInstance();
        LinkedList<Question> questions=new LinkedList<Question>();
        private LinkedListNode<Question> questionNode;
    
        Random random = new Random();
        int minute;
        int second;
        string CorrectAnswer;


        public formStudent()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

     

        private void panelDragg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelDragg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void buttonProfileExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin f = new formLogin();
            f.Show();
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            //lblStudentName.Text = student.name + " " + student.surname;
            //  lblStudentMail.Text = student.email;
           // Aciklama.IsBalloon = true;
            Aciklama.UseFading = true;
            Aciklama.SetToolTip(buttonProfileExit, "Çıkış");
            Aciklama.SetToolTip(buttonStatistics, "İstatistik");
            Aciklama.SetToolTip(buttonResults, "Test Sonuçları");
            Aciklama.SetToolTip(buttonTest, "Test Ol");
            questions = DBOperations.GetQuestions();
            questionNode = questions.First;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second++;
            string stringSecond = (10 <= second) ? second.ToString() : "0"+ second.ToString() ;
            string stringMinute = (10 <= minute) ? minute.ToString() : "0" + minute.ToString();

           
            if(second == 60)
            {
                second = 0;
                minute++;
            }
            labelTimer.Text = stringMinute+":"+stringSecond;
         
        }

      

        private void radioButtonAnswerA_Enter(object sender, EventArgs e)
        {
            radioButtonAnswerA.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void radioButtonAnswerB_Enter(object sender, EventArgs e)
        {
            radioButtonAnswerB.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void radioButtonAnswerC_Enter(object sender, EventArgs e)
        {
            radioButtonAnswerC.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void radioButtonAnswerD_Enter(object sender, EventArgs e)
        {
            radioButtonAnswerD.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void radioButtonAnswerA_Leave(object sender, EventArgs e)
        {
            radioButtonAnswerA.ForeColor = Color.FromName("White");
        }

        private void radioButtonAnswerB_Leave(object sender, EventArgs e)
        {
            radioButtonAnswerB.ForeColor = Color.FromName("White");
        }

        private void radioButtonAnswerC_Leave(object sender, EventArgs e)
        {
            radioButtonAnswerC.ForeColor = Color.FromName("White");
        }

        private void radioButtonAnswerD_Leave(object sender, EventArgs e)
        {
            radioButtonAnswerD.ForeColor = Color.FromName("White");

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Teste başlanacak, devam edilsin mi?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelTest.Visible = true;
                timer.Interval = 1000;
                timer.Start();
                ReadyQuestions();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

        private void ReadyQuestions()
        {
            Question currentQuestion = questionNode.Value;

            PlaceAnswers(currentQuestion);             
            textBoxDescription.Text = currentQuestion.description;
            textBoxQuestion.Text = currentQuestion.questionText;
            CorrectAnswer= currentQuestion.correctAnswer;

            questionNode = questionNode.Next;
        }



        private void PlaceAnswers(Question question)
        {          
            LinkedList<RadioButton> radioButtons = new LinkedList<RadioButton>();
            radioButtons.AddLast(radioButtonAnswerA);
            radioButtons.AddLast(radioButtonAnswerB);
            radioButtons.AddLast(radioButtonAnswerC);
            radioButtons.AddLast(radioButtonAnswerD);

            LinkedListNode<RadioButton> radioButtonsNode;

            while(radioButtons.Count != 0)
            {
                int random = Random(radioButtons.Count+1);
                radioButtonsNode = radioButtons.First;

                for (int i = 1; i < random; i++)
                    radioButtonsNode = radioButtonsNode.Next;

                switch (radioButtons.Count)
                {
                    case 4:
                        radioButtonsNode.Value.Text = question.correctAnswer;
                        break;
                    case 3:
                        radioButtonsNode.Value.Text = question.falseAnswerFirst;
                        break;
                    case 2:
                        radioButtonsNode.Value.Text = question.falseAnswerSecond;
                        break;
                    case 1:
                        radioButtonsNode.Value.Text = question.falseAnswerThird;
                        break;
                    default:
                        break;
                }

                radioButtons.Remove(radioButtonsNode);
            }          
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (IsAnswered())
            {
                CheckAnswer(radioButtonAnswerA);
                CheckAnswer(radioButtonAnswerB);
                CheckAnswer(radioButtonAnswerC);
                CheckAnswer(radioButtonAnswerD);
                ReadyQuestions();
            }
            else
            {
                MessageBox.Show("Bir seçimde bulunmadınız!", "Seçim yapılmadı!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
           
        }

        private bool IsAnswered()
        {
            if (radioButtonAnswerA.Checked || radioButtonAnswerB.Checked || radioButtonAnswerC.Checked ||
                radioButtonAnswerD.Checked)
                return true;
            else
                return false;
        }
        private int Random(int limit)
        {
            return random.Next(1, limit);
        }
       

        private void CheckAnswer(RadioButton Answer)
        {
            if(Answer.Checked)
            {
                if (CorrectAnswer == Answer.Text)
                {
                    UpdateStatistics(true);
                    MessageBox.Show("Doğru");
                }
                else
                {
                    UpdateStatistics(false);
                    MessageBox.Show("Yanlış");
                }
            }

            Answer.Checked = false;
        }



        private void UpdateStatistics(bool answerIsCorrect)
        {
            student.statistics.IncreaseTotalAnswers();

            SubjectStatistics subjectStatistics;
            if ((subjectStatistics=student.SearchStudentSubjectStatistics(questionNode.Value.subject)) == null)
            {
                SubjectStatistics newSubjectStatistics=new SubjectStatistics(questionNode.Value.subject);
                student.statistics.subjectStatistics.AddLast(newSubjectStatistics);     
            }
            else
            {
                subjectStatistics.IncreaseTotalAnswered();
            }
            
           

            if (answerIsCorrect)
            {
                student.statistics.IncreaseCorrectAnswers();
                subjectStatistics.IncreaseCorrectAnswered();
            }
        }
    }
}
