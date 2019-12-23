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
    public partial class formTeacher : Form
    {
        ToolTip Aciklama = new ToolTip();
        Point lastPoint;
        Image image;
        Teacher teacher= Teacher.GetInstance();
        public formTeacher()
        {
            InitializeComponent();
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Görüntü |*.jpg; *.jpeg; *.png;";
            DialogResult dr = FileDialog.ShowDialog();
            image = Image.FromFile(FileDialog.FileName);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void panelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Question question = new Question(textBoxDescription.Text, textBoxQuestion.Text,textBoxCorrectAnswer.Text,textBoxFalseAnswerFirst.Text,textBoxFalseAnswerSecond.Text,textBoxFalseAnswerThird.Text, comboBoxSubject.SelectedItem.ToString(), image);
            DBOperations.AddQuestion(question);
          
        }

        private void buttonProfileExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin f = new formLogin();
            f.Show();
        }

        private void formTeacher_Load(object sender, EventArgs e)
        {
            // lblTeacherName.Text = teacher.name + " " + teacher.surname;
            // pictureBoxProfile.Image = teacher;
            Aciklama.UseFading = true;
            Aciklama.SetToolTip(buttonProfileExit, "Çıkış");
        }

        

        private void textBoxCorrectAnswer_Enter(object sender, EventArgs e)
        {
            if (textBoxCorrectAnswer.Text == "Doğru cevap") 
            textBoxCorrectAnswer.Clear();

            textBoxCorrectAnswer.ForeColor = Color.FromArgb(78, 184, 206);
            separatorCorrectAnswer.LineColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxDescription_Enter(object sender, EventArgs e)
        {
            if (textBoxDescription.Text == "Açıklama")
                textBoxDescription.Clear();

            textBoxDescription.ForeColor = Color.FromArgb(78, 184, 206);
            separatorDescription.LineColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxFalseAnswerFirst_Enter(object sender, EventArgs e)
        {
            if (textBoxFalseAnswerFirst.Text == "Yanlış cevap 1")
                textBoxFalseAnswerFirst.Clear();

            textBoxFalseAnswerFirst.ForeColor = Color.FromArgb(78, 184, 206);
            separatorFalseFirst.LineColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxFalseAnswerSecond_Enter(object sender, EventArgs e)
        {
            if (textBoxFalseAnswerSecond.Text == "Yanlış cevap 2")
                textBoxFalseAnswerSecond.Clear();

            textBoxFalseAnswerSecond.ForeColor = Color.FromArgb(78, 184, 206);
            separatorFalseSecond.LineColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxFalseAnswerThird_Enter(object sender, EventArgs e)
        {
            if (textBoxFalseAnswerThird.Text == "Yanlış cevap 3")
                textBoxFalseAnswerThird.Clear();

            textBoxFalseAnswerThird.ForeColor = Color.FromArgb(78, 184, 206);
            separatorFalseThird.LineColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxQuestion_Enter(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text == "Soru")
                textBoxQuestion.Clear();

            textBoxQuestion.ForeColor = Color.FromArgb(78, 184, 206);
            separatorQuestion.LineColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxDescription_Leave(object sender, EventArgs e)
        {
            if (textBoxDescription.Text == "")
                textBoxDescription.Text = "Açıklama";

            textBoxDescription.ForeColor = Color.FromName("White");
            separatorDescription.LineColor = Color.FromName("White");
        }

        private void textBoxQuestion_Leave(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text == "")
                textBoxQuestion.Text = "Soru";

            textBoxQuestion.ForeColor = Color.FromName("White");
            separatorQuestion.LineColor = Color.FromName("White");
        }

        private void textBoxCorrectAnswer_Leave(object sender, EventArgs e)
        {
            if (textBoxCorrectAnswer.Text == "")
                textBoxCorrectAnswer.Text = "Doğru cevap";

            textBoxCorrectAnswer.ForeColor = Color.FromName("White");
            separatorCorrectAnswer.LineColor = Color.FromName("White");
        }

        private void textBoxFalseAnswerFirst_Leave(object sender, EventArgs e)
        {
            if (textBoxFalseAnswerFirst.Text == "")
                textBoxFalseAnswerFirst.Text = "Yanlış cevap 1";

            textBoxFalseAnswerFirst.ForeColor = Color.FromName("White");
            separatorFalseFirst.LineColor = Color.FromName("White");
        }

        private void textBoxFalseAnswerSecond_Leave(object sender, EventArgs e)
        {
            if (textBoxFalseAnswerSecond.Text == "")
                textBoxFalseAnswerSecond.Text = "Yanlış cevap 2";

            textBoxFalseAnswerSecond.ForeColor = Color.FromName("White");
            separatorFalseSecond.LineColor = Color.FromName("White");
        }

        private void textBoxFalseAnswerThird_Leave(object sender, EventArgs e)
        {
            if (textBoxFalseAnswerThird.Text == "")
                textBoxFalseAnswerThird.Text = "Yanlış cevap 3";

            textBoxFalseAnswerThird.ForeColor = Color.FromName("White");
            separatorFalseThird.LineColor = Color.FromName("White");
        }
    }
}
