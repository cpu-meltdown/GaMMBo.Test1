﻿namespace GaMMBo.Test
{
    partial class SearchForm
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
            this.searchFormTextBox = new System.Windows.Forms.TextBox();
            this.searchFormLabel1 = new System.Windows.Forms.Label();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.searchFormDropBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchFormBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchFormTextBox
            // 
            this.searchFormTextBox.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFormTextBox.Location = new System.Drawing.Point(189, 22);
            this.searchFormTextBox.Name = "searchFormTextBox";
            this.searchFormTextBox.Size = new System.Drawing.Size(418, 27);
            this.searchFormTextBox.TabIndex = 0;
            this.searchFormTextBox.TextChanged += new System.EventHandler(this.searchFormTextBox_TextChanged);
            this.searchFormTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchFormTextBox_KeyUp);
            // 
            // searchFormLabel1
            // 
            this.searchFormLabel1.AutoSize = true;
            this.searchFormLabel1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFormLabel1.Location = new System.Drawing.Point(12, 22);
            this.searchFormLabel1.Name = "searchFormLabel1";
            this.searchFormLabel1.Size = new System.Drawing.Size(171, 25);
            this.searchFormLabel1.TabIndex = 1;
            this.searchFormLabel1.Text = "Search by Name ";
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameButton.Location = new System.Drawing.Point(627, 22);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(75, 31);
            this.searchByNameButton.TabIndex = 2;
            this.searchByNameButton.Text = "Go";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // searchFormDropBox
            // 
            this.searchFormDropBox.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFormDropBox.FormattingEnabled = true;
            this.searchFormDropBox.Location = new System.Drawing.Point(189, 149);
            this.searchFormDropBox.Name = "searchFormDropBox";
            this.searchFormDropBox.Size = new System.Drawing.Size(177, 28);
            this.searchFormDropBox.TabIndex = 3;
            this.searchFormDropBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(385, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search by Genre";
            // 
            // searchFormBackButton
            // 
            this.searchFormBackButton.Location = new System.Drawing.Point(600, 222);
            this.searchFormBackButton.Name = "searchFormBackButton";
            this.searchFormBackButton.Size = new System.Drawing.Size(102, 32);
            this.searchFormBackButton.TabIndex = 7;
            this.searchFormBackButton.Text = "Back";
            this.searchFormBackButton.UseVisualStyleBackColor = true;
            this.searchFormBackButton.Click += new System.EventHandler(this.searchFormBackButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 266);
            this.ControlBox = false;
            this.Controls.Add(this.searchFormBackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchFormDropBox);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.searchFormLabel1);
            this.Controls.Add(this.searchFormTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchFormLabel1;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.ComboBox searchFormDropBox;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox searchFormTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchFormBackButton;
    }
}