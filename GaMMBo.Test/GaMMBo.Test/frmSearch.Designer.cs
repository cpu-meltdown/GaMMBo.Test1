namespace GaMMBo.Test
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
            this.SuspendLayout();
            // 
            // searchFormTextBox
            // 
            this.searchFormTextBox.Location = new System.Drawing.Point(116, 19);
            this.searchFormTextBox.Name = "searchFormTextBox";
            this.searchFormTextBox.Size = new System.Drawing.Size(157, 20);
            this.searchFormTextBox.TabIndex = 0;
            // 
            // searchFormLabel1
            // 
            this.searchFormLabel1.AutoSize = true;
            this.searchFormLabel1.Location = new System.Drawing.Point(12, 22);
            this.searchFormLabel1.Name = "searchFormLabel1";
            this.searchFormLabel1.Size = new System.Drawing.Size(89, 13);
            this.searchFormLabel1.TabIndex = 1;
            this.searchFormLabel1.Text = "Search by Name ";
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(327, 16);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(75, 23);
            this.searchByNameButton.TabIndex = 2;
            this.searchByNameButton.Text = "GO";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 369);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.searchFormLabel1);
            this.Controls.Add(this.searchFormTextBox);
            this.Name = "SearchForm";
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchFormTextBox;
        private System.Windows.Forms.Label searchFormLabel1;
        private System.Windows.Forms.Button searchByNameButton;
    }
}