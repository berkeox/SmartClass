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

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Kullanıcı Adı")
                textBoxUsername.Clear();
           
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text=="Şifre")
            textBoxPassword.Clear();
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            textBoxUsername.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            textBoxUsername.ForeColor = Color.FromName("White");
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = Color.FromName("White");
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
            this.Hide();
            formStudent f = new formStudent();
            f.Show();

           
        }
    }
}
