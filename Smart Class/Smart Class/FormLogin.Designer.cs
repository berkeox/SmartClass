namespace Smart_Class
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelDragg = new System.Windows.Forms.Panel();
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctPassword = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.lnklblBerke = new System.Windows.Forms.LinkLabel();
            this.lnklblBeyza = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(58, 192);
            this.textBoxUsername.MaxLength = 20;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(250, 15);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Text = "Kullanıcı Adı";
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonLogin.Location = new System.Drawing.Point(58, 313);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(250, 39);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelDragg
            // 
            this.panelDragg.BackColor = System.Drawing.Color.Transparent;
            this.panelDragg.Location = new System.Drawing.Point(-2, -2);
            this.panelDragg.Name = "panelDragg";
            this.panelDragg.Size = new System.Drawing.Size(245, 60);
            this.panelDragg.TabIndex = 10;
            this.panelDragg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDragg_MouseDown);
            this.panelDragg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDragg_MouseMove);
            // 
            // pctUser
            // 
            this.pctUser.Enabled = false;
            this.pctUser.Image = ((System.Drawing.Image)(resources.GetObject("pctUser.Image")));
            this.pctUser.Location = new System.Drawing.Point(12, 176);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(40, 40);
            this.pctUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUser.TabIndex = 11;
            this.pctUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(58, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 12;
            // 
            // logo
            // 
            this.logo.Enabled = false;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(119, 52);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(109, 59);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(58, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 17;
            // 
            // pctPassword
            // 
            this.pctPassword.Enabled = false;
            this.pctPassword.Image = ((System.Drawing.Image)(resources.GetObject("pctPassword.Image")));
            this.pctPassword.Location = new System.Drawing.Point(12, 237);
            this.pctPassword.Name = "pctPassword";
            this.pctPassword.Size = new System.Drawing.Size(40, 40);
            this.pctPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPassword.TabIndex = 16;
            this.pctPassword.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(58, 255);
            this.textBoxPassword.MaxLength = 15;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(250, 15);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Şifre";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblAppName.Location = new System.Drawing.Point(106, 114);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(125, 24);
            this.lblAppName.TabIndex = 18;
            this.lblAppName.Text = "Smart Class";
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(291, -1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(48, 52);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(243, -1);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(48, 52);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // lnklblBerke
            // 
            this.lnklblBerke.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lnklblBerke.AutoSize = true;
            this.lnklblBerke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblBerke.Font = new System.Drawing.Font("Arial", 9F);
            this.lnklblBerke.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lnklblBerke.Location = new System.Drawing.Point(9, 403);
            this.lnklblBerke.Name = "lnklblBerke";
            this.lnklblBerke.Size = new System.Drawing.Size(74, 15);
            this.lnklblBerke.TabIndex = 6;
            this.lnklblBerke.TabStop = true;
            this.lnklblBerke.Text = "Berke Öncül";
            this.lnklblBerke.VisitedLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.lnklblBerke.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBerke_LinkClicked);
            // 
            // lnklblBeyza
            // 
            this.lnklblBeyza.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lnklblBeyza.AutoSize = true;
            this.lnklblBeyza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblBeyza.Font = new System.Drawing.Font("Arial", 9F);
            this.lnklblBeyza.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lnklblBeyza.Location = new System.Drawing.Point(14, 426);
            this.lnklblBeyza.Name = "lnklblBeyza";
            this.lnklblBeyza.Size = new System.Drawing.Size(69, 15);
            this.lnklblBeyza.TabIndex = 7;
            this.lnklblBeyza.TabStop = true;
            this.lnklblBeyza.Text = "Beyza Onar";
            this.lnklblBeyza.VisitedLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.lnklblBeyza.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBeyza_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // formLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnklblBeyza);
            this.Controls.Add(this.lnklblBerke);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pctPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.panelDragg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Class";
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelDragg;
        private System.Windows.Forms.PictureBox pctUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.LinkLabel lnklblBerke;
        private System.Windows.Forms.LinkLabel lnklblBeyza;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

