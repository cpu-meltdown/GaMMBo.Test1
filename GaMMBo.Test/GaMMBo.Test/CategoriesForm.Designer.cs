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
            this.booksButton = new System.Windows.Forms.Button();
            this.gamesButton = new System.Windows.Forms.Button();
            this.moviesButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // booksButton
            // 
            this.booksButton.Location = new System.Drawing.Point(103, 54);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(94, 68);
            this.booksButton.TabIndex = 0;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // gamesButton
            // 
            this.gamesButton.Location = new System.Drawing.Point(303, 54);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(94, 68);
            this.gamesButton.TabIndex = 1;
            this.gamesButton.Text = "Games";
            this.gamesButton.UseVisualStyleBackColor = true;
            this.gamesButton.Click += new System.EventHandler(this.gamesButton_Click);
            // 
            // moviesButton
            // 
            this.moviesButton.Location = new System.Drawing.Point(103, 185);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(94, 68);
            this.moviesButton.TabIndex = 2;
            this.moviesButton.Text = "Movies";
            this.moviesButton.UseVisualStyleBackColor = true;
            this.moviesButton.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // musicButton
            // 
            this.musicButton.Location = new System.Drawing.Point(313, 185);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(94, 68);
            this.musicButton.TabIndex = 3;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(443, 287);
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
            this.lblUser.Location = new System.Drawing.Point(13, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 5;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 334);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.moviesButton);
            this.Controls.Add(this.gamesButton);
            this.Controls.Add(this.booksButton);
            this.Name = "CategoriesForm";
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
    }
}