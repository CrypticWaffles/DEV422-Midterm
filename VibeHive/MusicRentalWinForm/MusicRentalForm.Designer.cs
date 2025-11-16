namespace MusicRentalClient
{
    partial class MusicRentalForm
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
            this.listBox_MusicRental = new System.Windows.Forms.ListBox();
            this.groupBox_AddAlbum = new System.Windows.Forms.GroupBox();
            this.button_ListAlbums = new System.Windows.Forms.Button();
            this.button_AddAlbum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdd_Year = new System.Windows.Forms.TextBox();
            this.txtAdd_Genre = new System.Windows.Forms.TextBox();
            this.txtAdd_Artist = new System.Windows.Forms.TextBox();
            this.txtAdd_Title = new System.Windows.Forms.TextBox();
            this.groupBox_RentAlbum = new System.Windows.Forms.GroupBox();
            this.button_RentAlbum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRent_UserID = new System.Windows.Forms.TextBox();
            this.txtRent_AlbumID = new System.Windows.Forms.TextBox();
            this.groupBox_ReturnAlbum = new System.Windows.Forms.GroupBox();
            this.button_ReturnAlbum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReturn_RentalID = new System.Windows.Forms.TextBox();
            this.button_ListRentals = new System.Windows.Forms.Button();
            this.groupBox_AddAlbum.SuspendLayout();
            this.groupBox_RentAlbum.SuspendLayout();
            this.groupBox_ReturnAlbum.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_MusicRental
            // 
            this.listBox_MusicRental.FormattingEnabled = true;
            this.listBox_MusicRental.Location = new System.Drawing.Point(256, 12);
            this.listBox_MusicRental.Name = "listBox_MusicRental";
            this.listBox_MusicRental.Size = new System.Drawing.Size(604, 316);
            this.listBox_MusicRental.TabIndex = 0;
            // 
            // groupBox_AddAlbum
            // 
            this.groupBox_AddAlbum.Controls.Add(this.button_AddAlbum);
            this.groupBox_AddAlbum.Controls.Add(this.label4);
            this.groupBox_AddAlbum.Controls.Add(this.label3);
            this.groupBox_AddAlbum.Controls.Add(this.label2);
            this.groupBox_AddAlbum.Controls.Add(this.label1);
            this.groupBox_AddAlbum.Controls.Add(this.txtAdd_Year);
            this.groupBox_AddAlbum.Controls.Add(this.txtAdd_Genre);
            this.groupBox_AddAlbum.Controls.Add(this.txtAdd_Artist);
            this.groupBox_AddAlbum.Controls.Add(this.txtAdd_Title);
            this.groupBox_AddAlbum.Location = new System.Drawing.Point(18, 10);
            this.groupBox_AddAlbum.Name = "groupBox_AddAlbum";
            this.groupBox_AddAlbum.Size = new System.Drawing.Size(232, 162);
            this.groupBox_AddAlbum.TabIndex = 1;
            this.groupBox_AddAlbum.TabStop = false;
            this.groupBox_AddAlbum.Text = "Add Album";
            // 
            // button_ListAlbums
            // 
            this.button_ListAlbums.Location = new System.Drawing.Point(256, 334);
            this.button_ListAlbums.Name = "button_ListAlbums";
            this.button_ListAlbums.Size = new System.Drawing.Size(142, 23);
            this.button_ListAlbums.TabIndex = 9;
            this.button_ListAlbums.Text = "List Avaliable Albums";
            this.button_ListAlbums.UseVisualStyleBackColor = true;
            this.button_ListAlbums.Click += new System.EventHandler(this.button_ListAlbums_Click);
            // 
            // button_AddAlbum
            // 
            this.button_AddAlbum.Location = new System.Drawing.Point(10, 128);
            this.button_AddAlbum.Name = "button_AddAlbum";
            this.button_AddAlbum.Size = new System.Drawing.Size(75, 23);
            this.button_AddAlbum.TabIndex = 8;
            this.button_AddAlbum.Text = "Add Album";
            this.button_AddAlbum.UseVisualStyleBackColor = true;
            this.button_AddAlbum.Click += new System.EventHandler(this.button_AddAlbum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Artist:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Album Tile:";
            // 
            // txtAdd_Year
            // 
            this.txtAdd_Year.Location = new System.Drawing.Point(68, 102);
            this.txtAdd_Year.Name = "txtAdd_Year";
            this.txtAdd_Year.Size = new System.Drawing.Size(50, 20);
            this.txtAdd_Year.TabIndex = 3;
            // 
            // txtAdd_Genre
            // 
            this.txtAdd_Genre.Location = new System.Drawing.Point(68, 75);
            this.txtAdd_Genre.Name = "txtAdd_Genre";
            this.txtAdd_Genre.Size = new System.Drawing.Size(100, 20);
            this.txtAdd_Genre.TabIndex = 2;
            // 
            // txtAdd_Artist
            // 
            this.txtAdd_Artist.Location = new System.Drawing.Point(68, 48);
            this.txtAdd_Artist.Name = "txtAdd_Artist";
            this.txtAdd_Artist.Size = new System.Drawing.Size(150, 20);
            this.txtAdd_Artist.TabIndex = 1;
            // 
            // txtAdd_Title
            // 
            this.txtAdd_Title.Location = new System.Drawing.Point(68, 21);
            this.txtAdd_Title.Name = "txtAdd_Title";
            this.txtAdd_Title.Size = new System.Drawing.Size(150, 20);
            this.txtAdd_Title.TabIndex = 0;
            // 
            // groupBox_RentAlbum
            // 
            this.groupBox_RentAlbum.Controls.Add(this.button_RentAlbum);
            this.groupBox_RentAlbum.Controls.Add(this.label5);
            this.groupBox_RentAlbum.Controls.Add(this.label6);
            this.groupBox_RentAlbum.Controls.Add(this.txtRent_UserID);
            this.groupBox_RentAlbum.Controls.Add(this.txtRent_AlbumID);
            this.groupBox_RentAlbum.Location = new System.Drawing.Point(18, 178);
            this.groupBox_RentAlbum.Name = "groupBox_RentAlbum";
            this.groupBox_RentAlbum.Size = new System.Drawing.Size(232, 103);
            this.groupBox_RentAlbum.TabIndex = 3;
            this.groupBox_RentAlbum.TabStop = false;
            this.groupBox_RentAlbum.Text = "Rent Album";
            // 
            // button_RentAlbum
            // 
            this.button_RentAlbum.Location = new System.Drawing.Point(10, 71);
            this.button_RentAlbum.Name = "button_RentAlbum";
            this.button_RentAlbum.Size = new System.Drawing.Size(75, 23);
            this.button_RentAlbum.TabIndex = 0;
            this.button_RentAlbum.Text = "Rent Album";
            this.button_RentAlbum.UseVisualStyleBackColor = true;
            this.button_RentAlbum.Click += new System.EventHandler(this.button_RentAlbum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Album ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "User ID:";
            // 
            // txtRent_UserID
            // 
            this.txtRent_UserID.Location = new System.Drawing.Point(68, 19);
            this.txtRent_UserID.Name = "txtRent_UserID";
            this.txtRent_UserID.Size = new System.Drawing.Size(100, 20);
            this.txtRent_UserID.TabIndex = 8;
            // 
            // txtRent_AlbumID
            // 
            this.txtRent_AlbumID.Location = new System.Drawing.Point(68, 45);
            this.txtRent_AlbumID.Name = "txtRent_AlbumID";
            this.txtRent_AlbumID.Size = new System.Drawing.Size(100, 20);
            this.txtRent_AlbumID.TabIndex = 9;
            // 
            // groupBox_ReturnAlbum
            // 
            this.groupBox_ReturnAlbum.Controls.Add(this.button_ReturnAlbum);
            this.groupBox_ReturnAlbum.Controls.Add(this.label7);
            this.groupBox_ReturnAlbum.Controls.Add(this.txtReturn_RentalID);
            this.groupBox_ReturnAlbum.Location = new System.Drawing.Point(17, 287);
            this.groupBox_ReturnAlbum.Name = "groupBox_ReturnAlbum";
            this.groupBox_ReturnAlbum.Size = new System.Drawing.Size(233, 75);
            this.groupBox_ReturnAlbum.TabIndex = 4;
            this.groupBox_ReturnAlbum.TabStop = false;
            this.groupBox_ReturnAlbum.Text = "Return Album";
            // 
            // button_ReturnAlbum
            // 
            this.button_ReturnAlbum.Location = new System.Drawing.Point(11, 41);
            this.button_ReturnAlbum.Name = "button_ReturnAlbum";
            this.button_ReturnAlbum.Size = new System.Drawing.Size(113, 23);
            this.button_ReturnAlbum.TabIndex = 14;
            this.button_ReturnAlbum.Text = "Return Album";
            this.button_ReturnAlbum.UseVisualStyleBackColor = true;
            this.button_ReturnAlbum.Click += new System.EventHandler(this.button_ReturnAlbum_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rental ID:";
            // 
            // txtReturn_RentalID
            // 
            this.txtReturn_RentalID.Location = new System.Drawing.Point(69, 15);
            this.txtReturn_RentalID.Name = "txtReturn_RentalID";
            this.txtReturn_RentalID.Size = new System.Drawing.Size(100, 20);
            this.txtReturn_RentalID.TabIndex = 12;
            // 
            // button_ListRentals
            // 
            this.button_ListRentals.Location = new System.Drawing.Point(404, 334);
            this.button_ListRentals.Name = "button_ListRentals";
            this.button_ListRentals.Size = new System.Drawing.Size(142, 23);
            this.button_ListRentals.TabIndex = 15;
            this.button_ListRentals.Text = "List Active Rentals";
            this.button_ListRentals.UseVisualStyleBackColor = true;
            this.button_ListRentals.Click += new System.EventHandler(this.button_ListRentals_Click);
            // 
            // MusicRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 374);
            this.Controls.Add(this.button_ListAlbums);
            this.Controls.Add(this.button_ListRentals);
            this.Controls.Add(this.groupBox_ReturnAlbum);
            this.Controls.Add(this.groupBox_RentAlbum);
            this.Controls.Add(this.groupBox_AddAlbum);
            this.Controls.Add(this.listBox_MusicRental);
            this.Name = "MusicRentalForm";
            this.Text = "MusicRentalForm";
            this.groupBox_AddAlbum.ResumeLayout(false);
            this.groupBox_AddAlbum.PerformLayout();
            this.groupBox_RentAlbum.ResumeLayout(false);
            this.groupBox_RentAlbum.PerformLayout();
            this.groupBox_ReturnAlbum.ResumeLayout(false);
            this.groupBox_ReturnAlbum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_MusicRental;
        private System.Windows.Forms.GroupBox groupBox_AddAlbum;
        private System.Windows.Forms.GroupBox groupBox_RentAlbum;
        private System.Windows.Forms.GroupBox groupBox_ReturnAlbum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd_Year;
        private System.Windows.Forms.TextBox txtAdd_Genre;
        private System.Windows.Forms.TextBox txtAdd_Artist;
        private System.Windows.Forms.TextBox txtAdd_Title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRent_UserID;
        private System.Windows.Forms.TextBox txtRent_AlbumID;
        private System.Windows.Forms.Button button_AddAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReturn_RentalID;
        private System.Windows.Forms.Button button_RentAlbum;
        private System.Windows.Forms.Button button_ReturnAlbum;
        private System.Windows.Forms.Button button_ListAlbums;
        private System.Windows.Forms.Button button_ListRentals;
    }
}

