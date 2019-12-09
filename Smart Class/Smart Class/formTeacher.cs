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
            Question question = new Question(textBoxDescription.Text, textBoxQuestion.Text,textBoxCorrectAnswer.Text,textBoxFalseAnswerFirst.Text,textBoxFalseAnswerSecond.Text,textBoxFalseAnswerThird.Text, image, comboBoxSubject.SelectedItem.ToString());
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
            lblTeacherName.Text = teacher.name + " " + teacher.surname;
           // pictureBoxProfile.Image = teacher;
        }
    }
}
