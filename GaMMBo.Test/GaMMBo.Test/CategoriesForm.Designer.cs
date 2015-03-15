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
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(72, 33);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(94, 68);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(272, 33);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(94, 68);
            this.btnGames.TabIndex = 1;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = true;
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(72, 164);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(94, 68);
            this.btnMovies.TabIndex = 2;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(272, 164);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(94, 68);
            this.btnMusic.TabIndex = 3;
            this.btnMusic.Text = "Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(347, 240);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 285);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnBooks);
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnLogout;
    }
}