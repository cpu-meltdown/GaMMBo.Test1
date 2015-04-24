namespace GaMMBo.Test
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.booksButton = new System.Windows.Forms.Button();
            this.gamesButton = new System.Windows.Forms.Button();
            this.moviesButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // booksButton
            // 
            this.booksButton.Image = ((System.Drawing.Image)(resources.GetObject("booksButton.Image")));
            this.booksButton.Location = new System.Drawing.Point(329, 255);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(163, 151);
            this.booksButton.TabIndex = 0;
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // gamesButton
            // 
            this.gamesButton.Image = ((System.Drawing.Image)(resources.GetObject("gamesButton.Image")));
            this.gamesButton.Location = new System.Drawing.Point(114, 83);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(163, 151);
            this.gamesButton.TabIndex = 1;
            this.gamesButton.UseVisualStyleBackColor = true;
            this.gamesButton.Click += new System.EventHandler(this.gamesButton_Click);
            // 
            // moviesButton
            // 
            this.moviesButton.Image = ((System.Drawing.Image)(resources.GetObject("moviesButton.Image")));
            this.moviesButton.Location = new System.Drawing.Point(329, 83);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(163, 151);
            this.moviesButton.TabIndex = 2;
            this.moviesButton.UseVisualStyleBackColor = true;
            this.moviesButton.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // musicButton
            // 
            this.musicButton.Image = ((System.Drawing.Image)(resources.GetObject("musicButton.Image")));
            this.musicButton.Location = new System.Drawing.Point(114, 255);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(163, 151);
            this.musicButton.TabIndex = 3;
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(523, 427);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(26, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pick a Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(629, 474);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.moviesButton);
            this.Controls.Add(this.gamesButton);
            this.Controls.Add(this.booksButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button gamesButton;
        private System.Windows.Forms.Button moviesButton;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button musicButton;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
    }
}