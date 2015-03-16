namespace GaMMBo.Test
{
    partial class MusicForm
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
            this.musicFormBackButton = new System.Windows.Forms.Button();
            this.musicYear = new System.Windows.Forms.Label();
            this.musicArtist = new System.Windows.Forms.Label();
            this.musicAlbum = new System.Windows.Forms.Label();
            this.musicArtistDisplay = new System.Windows.Forms.TextBox();
            this.musicAlbumDisplay = new System.Windows.Forms.TextBox();
            this.musicYearDisplay = new System.Windows.Forms.TextBox();
            this.musicPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPicture)).BeginInit();
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
            // musicFormBackButton
            // 
            this.musicFormBackButton.Location = new System.Drawing.Point(484, 525);
            this.musicFormBackButton.Name = "musicFormBackButton";
            this.musicFormBackButton.Size = new System.Drawing.Size(75, 23);
            this.musicFormBackButton.TabIndex = 2;
            this.musicFormBackButton.Text = "Back";
            this.musicFormBackButton.UseVisualStyleBackColor = true;
            this.musicFormBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // musicYear
            // 
            this.musicYear.AutoSize = true;
            this.musicYear.Location = new System.Drawing.Point(392, 431);
            this.musicYear.Name = "musicYear";
            this.musicYear.Size = new System.Drawing.Size(29, 13);
            this.musicYear.TabIndex = 3;
            this.musicYear.Text = "Year";
            // 
            // musicArtist
            // 
            this.musicArtist.AutoSize = true;
            this.musicArtist.Location = new System.Drawing.Point(12, 431);
            this.musicArtist.Name = "musicArtist";
            this.musicArtist.Size = new System.Drawing.Size(30, 13);
            this.musicArtist.TabIndex = 4;
            this.musicArtist.Text = "Artist";
            // 
            // musicAlbum
            // 
            this.musicAlbum.AutoSize = true;
            this.musicAlbum.Location = new System.Drawing.Point(191, 431);
            this.musicAlbum.Name = "musicAlbum";
            this.musicAlbum.Size = new System.Drawing.Size(36, 13);
            this.musicAlbum.TabIndex = 5;
            this.musicAlbum.Text = "Album";
            // 
            // musicArtistDisplay
            // 
            this.musicArtistDisplay.Location = new System.Drawing.Point(67, 424);
            this.musicArtistDisplay.Name = "musicArtistDisplay";
            this.musicArtistDisplay.Size = new System.Drawing.Size(100, 20);
            this.musicArtistDisplay.TabIndex = 6;
            // 
            // musicAlbumDisplay
            // 
            this.musicAlbumDisplay.Location = new System.Drawing.Point(246, 424);
            this.musicAlbumDisplay.Name = "musicAlbumDisplay";
            this.musicAlbumDisplay.Size = new System.Drawing.Size(100, 20);
            this.musicAlbumDisplay.TabIndex = 7;
            // 
            // musicYearDisplay
            // 
            this.musicYearDisplay.Location = new System.Drawing.Point(444, 424);
            this.musicYearDisplay.Name = "musicYearDisplay";
            this.musicYearDisplay.Size = new System.Drawing.Size(100, 20);
            this.musicYearDisplay.TabIndex = 8;
            // 
            // musicPicture
            // 
            this.musicPicture.Location = new System.Drawing.Point(194, 90);
            this.musicPicture.Name = "musicPicture";
            this.musicPicture.Size = new System.Drawing.Size(227, 221);
            this.musicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.musicPicture.TabIndex = 9;
            this.musicPicture.TabStop = false;
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 599);
            this.Controls.Add(this.musicPicture);
            this.Controls.Add(this.musicYearDisplay);
            this.Controls.Add(this.musicAlbumDisplay);
            this.Controls.Add(this.musicArtistDisplay);
            this.Controls.Add(this.musicAlbum);
            this.Controls.Add(this.musicArtist);
            this.Controls.Add(this.musicYear);
            this.Controls.Add(this.musicFormBackButton);
            this.Name = "MusicForm";
            this.Text = "Music Recommendations";
            this.Load += new System.EventHandler(this.musicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CategoriesDataSet1 categoriesDataSet1;
        private System.Windows.Forms.BindingSource musicBindingSource;
        private CategoriesDataSet1TableAdapters.MusicTableAdapter musicTableAdapter;
        private CategoriesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button musicFormBackButton;
        private System.Windows.Forms.Label musicYear;
        private System.Windows.Forms.Label musicArtist;
        private System.Windows.Forms.Label musicAlbum;
        private System.Windows.Forms.TextBox musicArtistDisplay;
        private System.Windows.Forms.TextBox musicAlbumDisplay;
        private System.Windows.Forms.TextBox musicYearDisplay;
        private System.Windows.Forms.PictureBox musicPicture;
    }
}