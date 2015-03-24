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
            this.components = new System.ComponentModel.Container();
            this.categoriesDataSet1 = new GaMMBo.Test.CategoriesDataSet1();
            this.musicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicTableAdapter = new GaMMBo.Test.CategoriesDataSet1TableAdapters.MusicTableAdapter();
            this.tableAdapterManager = new GaMMBo.Test.CategoriesDataSet1TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesDataSet1
            // 
            this.categoriesDataSet1.DataSetName = "CategoriesDataSet1";
            this.categoriesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musicBindingSource
            // 
            this.musicBindingSource.DataMember = "Music";
            this.musicBindingSource.DataSource = this.categoriesDataSet1;
            // 
            // musicTableAdapter
            // 
            this.musicTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MoviesTableAdapter = null;
            this.tableAdapterManager.MusicTableAdapter = this.musicTableAdapter;
            this.tableAdapterManager.UpdateOrder = GaMMBo.Test.CategoriesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 135);
            this.button1.TabIndex = 0;
            this.button1.Text = "Top 10";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 135);
            this.button2.TabIndex = 1;
            this.button2.Text = "Recommended";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 129);
            this.button3.TabIndex = 2;
            this.button3.Text = "Recent releases";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 129);
            this.button4.TabIndex = 3;
            this.button4.Text = "Best Fit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(499, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 392);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SearchForm";
            this.Text = "Search ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CategoriesDataSet1 categoriesDataSet1;
        private System.Windows.Forms.BindingSource musicBindingSource;
        private CategoriesDataSet1TableAdapters.MusicTableAdapter musicTableAdapter;
        private CategoriesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;



    }
}

