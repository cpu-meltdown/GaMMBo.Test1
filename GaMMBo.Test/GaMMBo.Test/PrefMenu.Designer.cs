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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.categoryObjectName = new System.Windows.Forms.Label();
            this.categoryImage = new System.Windows.Forms.PictureBox();
            this.categoryObjectDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Like";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dislike";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Skip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(310, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(334, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // categoryObjectName
            // 
            this.categoryObjectName.AutoSize = true;
            this.categoryObjectName.Location = new System.Drawing.Point(26, 9);
            this.categoryObjectName.Name = "categoryObjectName";
            this.categoryObjectName.Size = new System.Drawing.Size(35, 13);
            this.categoryObjectName.TabIndex = 5;
            this.categoryObjectName.Text = "Name";
            this.categoryObjectName.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryImage
            // 
            this.categoryImage.Location = new System.Drawing.Point(42, 35);
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
            this.categoryObjectDescription.Location = new System.Drawing.Point(249, 55);
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
            this.ClientSize = new System.Drawing.Size(421, 340);
            this.Controls.Add(this.categoryObjectDescription);
            this.Controls.Add(this.categoryImage);
            this.Controls.Add(this.categoryObjectName);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PrefMenu";
            this.Text = "PrefMenu";
            this.Load += new System.EventHandler(this.PrefMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label categoryObjectName;
        private System.Windows.Forms.PictureBox categoryImage;
        private System.Windows.Forms.Label categoryObjectDescription;
    }
}