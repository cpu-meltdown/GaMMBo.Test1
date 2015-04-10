namespace GaMMBo.Test
{
    partial class Form1
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
            this.GammboDBDataSet = new GaMMBo.Test.GammboDBDataSet();
            this.musicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicTableAdapter = new GaMMBo.Test.GammboDBDataSetTableAdapters.MusicTableAdapter();
            this.tableAdapterManager = new GaMMBo.Test.GammboDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.GammboDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GammboDBDataSet
            // 
            this.GammboDBDataSet.DataSetName = "GammboDBDataSet";
            this.GammboDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musicBindingSource
            // 
            this.musicBindingSource.DataMember = "Music";
            this.musicBindingSource.DataSource = this.GammboDBDataSet;
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
            this.tableAdapterManager.UpdateOrder = GaMMBo.Test.GammboDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 309);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GammboDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GammboDBDataSet GammboDBDataSet;
        private System.Windows.Forms.BindingSource musicBindingSource;
        private GammboDBDataSetTableAdapters.MusicTableAdapter musicTableAdapter;
        private GammboDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;



    }
}

