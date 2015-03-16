namespace GaMMBo.Test
{
    partial class MoviesForm
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
            this.components = new System.ComponentModel.Container();
            this.categoriesDataSet1 = new GaMMBo.Test.CategoriesDataSet1();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new GaMMBo.Test.CategoriesDataSet1TableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new GaMMBo.Test.CategoriesDataSet1TableAdapters.TableAdapterManager();
            this.moviesFormBackButton = new System.Windows.Forms.Button();
            this.movieYearDisplayBox = new System.Windows.Forms.TextBox();
            this.movieNameDisplayBox = new System.Windows.Forms.TextBox();
            this.movieYearLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.moviePircutre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePircutre)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesDataSet1
            // 
            this.categoriesDataSet1.DataSetName = "CategoriesDataSet1";
            this.categoriesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.categoriesDataSet1;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.MusicTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GaMMBo.Test.CategoriesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moviesFormBackButton
            // 
            this.moviesFormBackButton.Location = new System.Drawing.Point(443, 519);
            this.moviesFormBackButton.Name = "moviesFormBackButton";
            this.moviesFormBackButton.Size = new System.Drawing.Size(75, 23);
            this.moviesFormBackButton.TabIndex = 2;
            this.moviesFormBackButton.Text = "Back";
            this.moviesFormBackButton.UseVisualStyleBackColor = true;
            this.moviesFormBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // movieYearDisplayBox
            // 
            this.movieYearDisplayBox.Location = new System.Drawing.Point(370, 328);
            this.movieYearDisplayBox.Name = "movieYearDisplayBox";
            this.movieYearDisplayBox.Size = new System.Drawing.Size(100, 20);
            this.movieYearDisplayBox.TabIndex = 3;
            // 
            // movieNameDisplayBox
            // 
            this.movieNameDisplayBox.Location = new System.Drawing.Point(99, 328);
            this.movieNameDisplayBox.Name = "movieNameDisplayBox";
            this.movieNameDisplayBox.Size = new System.Drawing.Size(100, 20);
            this.movieNameDisplayBox.TabIndex = 4;
            // 
            // movieYearLabel
            // 
            this.movieYearLabel.AutoSize = true;
            this.movieYearLabel.Location = new System.Drawing.Point(290, 331);
            this.movieYearLabel.Name = "movieYearLabel";
            this.movieYearLabel.Size = new System.Drawing.Size(29, 13);
            this.movieYearLabel.TabIndex = 5;
            this.movieYearLabel.Text = "Year";
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Location = new System.Drawing.Point(30, 331);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(35, 13);
            this.movieNameLabel.TabIndex = 6;
            this.movieNameLabel.Text = "Name";
            // 
            // moviePircutre
            // 
            this.moviePircutre.Location = new System.Drawing.Point(171, 41);
            this.moviePircutre.Name = "moviePircutre";
            this.moviePircutre.Size = new System.Drawing.Size(235, 264);
            this.moviePircutre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePircutre.TabIndex = 7;
            this.moviePircutre.TabStop = false;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 568);
            this.Controls.Add(this.moviePircutre);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.movieYearLabel);
            this.Controls.Add(this.movieNameDisplayBox);
            this.Controls.Add(this.movieYearDisplayBox);
            this.Controls.Add(this.moviesFormBackButton);
            this.Name = "MoviesForm";
            this.Text = "Movies Database";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePircutre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CategoriesDataSet1 categoriesDataSet1;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private CategoriesDataSet1TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private CategoriesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button moviesFormBackButton;
        private System.Windows.Forms.TextBox movieYearDisplayBox;
        private System.Windows.Forms.TextBox movieNameDisplayBox;
        private System.Windows.Forms.Label movieYearLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.PictureBox moviePircutre;
    }
}