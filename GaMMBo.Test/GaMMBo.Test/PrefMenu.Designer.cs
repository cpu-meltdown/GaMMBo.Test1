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
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.categoryObjectName = new System.Windows.Forms.Label();
            this.categoryObjectDescription = new System.Windows.Forms.Label();
            this.categoryImage = new System.Windows.Forms.PictureBox();
            this.btnDislike = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkip
            // 
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Image = global::GaMMBo.Test.Properties.Resources.skip_button9999;
            this.btnSkip.Location = new System.Drawing.Point(340, 363);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(110, 105);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(514, 430);
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
            this.categoryObjectName.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryObjectName.ForeColor = System.Drawing.Color.Black;
            this.categoryObjectName.Location = new System.Drawing.Point(11, 9);
            this.categoryObjectName.Name = "categoryObjectName";
            this.categoryObjectName.Size = new System.Drawing.Size(68, 25);
            this.categoryObjectName.TabIndex = 5;
            this.categoryObjectName.Text = "Name";
            this.categoryObjectName.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryObjectDescription
            // 
            this.categoryObjectDescription.AutoSize = true;
            this.categoryObjectDescription.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryObjectDescription.ForeColor = System.Drawing.Color.Black;
            this.categoryObjectDescription.Location = new System.Drawing.Point(12, 49);
            this.categoryObjectDescription.Name = "categoryObjectDescription";
            this.categoryObjectDescription.Size = new System.Drawing.Size(103, 21);
            this.categoryObjectDescription.TabIndex = 7;
            this.categoryObjectDescription.Text = "Description";
            this.categoryObjectDescription.Click += new System.EventHandler(this.label2_Click);
            // 
            // categoryImage
            // 
            this.categoryImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryImage.Location = new System.Drawing.Point(158, 78);
            this.categoryImage.Name = "categoryImage";
            this.categoryImage.Size = new System.Drawing.Size(227, 274);
            this.categoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryImage.TabIndex = 6;
            this.categoryImage.TabStop = false;
            this.categoryImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.FlatAppearance.BorderSize = 0;
            this.btnDislike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDislike.Image = global::GaMMBo.Test.Properties.Resources.dislikeButton99999;
            this.btnDislike.Location = new System.Drawing.Point(213, 363);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(110, 105);
            this.btnDislike.TabIndex = 1;
            this.btnDislike.UseVisualStyleBackColor = true;
            this.btnDislike.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLike
            // 
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Image = global::GaMMBo.Test.Properties.Resources.like_button99999;
            this.btnLike.Location = new System.Drawing.Point(86, 363);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(110, 105);
            this.btnLike.TabIndex = 0;
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrefMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 507);
            this.ControlBox = false;
            this.Controls.Add(this.categoryObjectDescription);
            this.Controls.Add(this.categoryImage);
            this.Controls.Add(this.categoryObjectName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnDislike);
            this.Controls.Add(this.btnLike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrefMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrefMenu";
            this.Load += new System.EventHandler(this.PrefMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnLike;
        public System.Windows.Forms.Button btnDislike;
        public System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label categoryObjectName;
        public System.Windows.Forms.PictureBox categoryImage;
        public System.Windows.Forms.Label categoryObjectDescription;
    }
}