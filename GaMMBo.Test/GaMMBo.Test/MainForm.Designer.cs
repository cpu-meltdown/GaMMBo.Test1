namespace GaMMBo.Test
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.guest = new System.Windows.Forms.PictureBox();
            this.newUser = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guest
            // 
            this.guest.Image = ((System.Drawing.Image)(resources.GetObject("guest.Image")));
            this.guest.Location = new System.Drawing.Point(393, 217);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(165, 110);
            this.guest.TabIndex = 5;
            this.guest.TabStop = false;
            this.guest.Click += new System.EventHandler(this.guest_Click);
            // 
            // newUser
            // 
            this.newUser.Image = ((System.Drawing.Image)(resources.GetObject("newUser.Image")));
            this.newUser.Location = new System.Drawing.Point(218, 231);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(159, 109);
            this.newUser.TabIndex = 6;
            this.newUser.TabStop = false;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // login
            // 
            this.login.Image = ((System.Drawing.Image)(resources.GetObject("login.Image")));
            this.login.Location = new System.Drawing.Point(55, 222);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(157, 105);
            this.login.TabIndex = 7;
            this.login.TabStop = false;
            this.login.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(615, 410);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GaMMBo";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox guest;
        private System.Windows.Forms.PictureBox newUser;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}