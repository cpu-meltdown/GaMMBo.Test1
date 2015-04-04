namespace GaMMBo.Test
{
    partial class PrefMenu
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
            this.btnLike = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.categoryObjectName = new System.Windows.Forms.Label();
            this.categoryImage = new System.Windows.Forms.PictureBox();
            this.categoryObjectDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(93, 307);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 0;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.Location = new System.Drawing.Point(189, 307);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(75, 23);
            this.btnDislike.TabIndex = 1;
            this.btnDislike.Text = "Dislike";
            this.btnDislike.UseVisualStyleBackColor = true;
            this.btnDislike.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(285, 307);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(386, 373);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // categoryObjectName
            // 
            this.categoryObjectName.AutoSize = true;
            this.categoryObjectName.Location = new System.Drawing.Point(21, 37);
            this.categoryObjectName.Name = "categoryObjectName";
            this.categoryObjectName.Size = new System.Drawing.Size(35, 13);
            this.categoryObjectName.TabIndex = 5;
            this.categoryObjectName.Text = "Name";
            this.categoryObjectName.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryImage
            // 
            this.categoryImage.Location = new System.Drawing.Point(147, 84);
            this.categoryImage.Name = "categoryImage";
            this.categoryImage.Size = new System.Drawing.Size(162, 184);
            this.categoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryImage.TabIndex = 6;
            this.categoryImage.TabStop = false;
            this.categoryImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // categoryObjectDescription
            // 
            this.categoryObjectDescription.AutoSize = true;
            this.categoryObjectDescription.Location = new System.Drawing.Point(21, 62);
            this.categoryObjectDescription.Name = "categoryObjectDescription";
            this.categoryObjectDescription.Size = new System.Drawing.Size(60, 13);
            this.categoryObjectDescription.TabIndex = 7;
            this.categoryObjectDescription.Text = "Description";
            this.categoryObjectDescription.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrefMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 421);
            this.Controls.Add(this.categoryObjectDescription);
            this.Controls.Add(this.categoryImage);
            this.Controls.Add(this.categoryObjectName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnDislike);
            this.Controls.Add(this.btnLike);
            this.Name = "PrefMenu";
            this.Text = "PrefMenu";
            this.Load += new System.EventHandler(this.PrefMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label categoryObjectName;
        private System.Windows.Forms.PictureBox categoryImage;
        private System.Windows.Forms.Label categoryObjectDescription;
    }
}