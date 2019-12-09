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

        Point lastPoint;
        Student student = Student.GetInstance();

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
            lblStudentName.Text = student.name + " " + student.surname;
            lblStudentMail.Text = student.email;
        }
    }
}
