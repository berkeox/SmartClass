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
    public partial class formLogin : Form
    {
        Point lastPoint;
    
        public formLogin()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panelDragg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelDragg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void textBoxUsername_Enter(object sender, EventArgs e)
        {

            if (textBoxUsername.Text == "Kullanıcı Adı")
                textBoxUsername.Clear();

            textBoxUsername.ForeColor = Color.FromArgb(78, 184, 206);
            separatorUser.LineColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
                textBoxUsername.Text = "Kullanıcı Adı";

            textBoxUsername.ForeColor = Color.FromName("White");
            separatorUser.LineColor = Color.FromName("White");
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Şifre")
                textBoxPassword.Clear();

            textBoxPassword.ForeColor = Color.FromArgb(78, 184, 206);
            separatorPassword.LineColor = Color.FromArgb(78, 184, 206);

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
                textBoxPassword.Text = "Şifre";
            textBoxPassword.ForeColor = Color.FromName("White");
            separatorPassword.LineColor = Color.FromName("White");
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnklblBerke_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/berke-%C3%B6nc%C3%BCl-b99b0618b/");
        }

        private void lnklblBeyza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/beyza-onar-757130199/");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (!radioButtonTeacher.Checked && !radioButtonStudent.Checked)
                {
                    MessageBox.Show("Giriş türünü seçiniz!", "Giriş türü seçilmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonStudent.Checked && DBOperations.CheckStudent(textBoxUsername.Text, textBoxPassword.Text))
                {
                    this.Hide();
                    formStudent f = new formStudent();
                    f.Show();

                }
                else if (DBOperations.CheckTeacher(textBoxUsername.Text, textBoxPassword.Text))
                {
                    this.Hide();
                    formTeacher f = new formTeacher();
                    f.Show();
                }
            }
            catch
            {
                MessageBox.Show("Bir hata gerçekleşti", "Bir hata oldu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTeacher f = new formTeacher();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formTeacher f = new formTeacher();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formStudent f = new formStudent();
            f.Show();
        }
    }
}
