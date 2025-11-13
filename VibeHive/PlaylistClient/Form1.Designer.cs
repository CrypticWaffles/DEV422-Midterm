namespace PlaylistClient
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
            this.btn_listPlaylists = new System.Windows.Forms.Button();
            this.lbx_playlists = new System.Windows.Forms.ListBox();
            this.btn_createPlaylist = new System.Windows.Forms.Button();
            this.txt_playlistTitle = new System.Windows.Forms.TextBox();
            this.btn_addSong = new System.Windows.Forms.Button();
            this.txt_songTitle = new System.Windows.Forms.TextBox();
            this.txt_songArtist = new System.Windows.Forms.TextBox();
            this.txt_songGenre = new System.Windows.Forms.TextBox();
            this.txt_songDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_listPlaylists
            // 
            this.btn_listPlaylists.Location = new System.Drawing.Point(12, 12);
            this.btn_listPlaylists.Name = "btn_listPlaylists";
            this.btn_listPlaylists.Size = new System.Drawing.Size(119, 23);
            this.btn_listPlaylists.TabIndex = 0;
            this.btn_listPlaylists.Text = "List Playlists";
            this.btn_listPlaylists.UseVisualStyleBackColor = true;
            this.btn_listPlaylists.Click += new System.EventHandler(this.btn_listPlaylists_Click);
            // 
            // lbx_playlists
            // 
            this.lbx_playlists.FormattingEnabled = true;
            this.lbx_playlists.ItemHeight = 20;
            this.lbx_playlists.Location = new System.Drawing.Point(13, 42);
            this.lbx_playlists.Name = "lbx_playlists";
            this.lbx_playlists.Size = new System.Drawing.Size(269, 204);
            this.lbx_playlists.TabIndex = 1;
            // 
            // btn_createPlaylist
            // 
            this.btn_createPlaylist.Location = new System.Drawing.Point(318, 74);
            this.btn_createPlaylist.Name = "btn_createPlaylist";
            this.btn_createPlaylist.Size = new System.Drawing.Size(121, 22);
            this.btn_createPlaylist.TabIndex = 2;
            this.btn_createPlaylist.Text = "Create Playlist";
            this.btn_createPlaylist.UseVisualStyleBackColor = true;
            this.btn_createPlaylist.Click += new System.EventHandler(this.btn_createPlaylist_Click);
            // 
            // txt_playlistTitle
            // 
            this.txt_playlistTitle.Location = new System.Drawing.Point(318, 42);
            this.txt_playlistTitle.Name = "txt_playlistTitle";
            this.txt_playlistTitle.Size = new System.Drawing.Size(200, 26);
            this.txt_playlistTitle.TabIndex = 3;
            this.txt_playlistTitle.Text = "Title";
            // 
            // btn_addSong
            // 
            this.btn_addSong.Location = new System.Drawing.Point(318, 244);
            this.btn_addSong.Name = "btn_addSong";
            this.btn_addSong.Size = new System.Drawing.Size(106, 23);
            this.btn_addSong.TabIndex = 4;
            this.btn_addSong.Text = "Add Song";
            this.btn_addSong.UseVisualStyleBackColor = true;
            this.btn_addSong.Click += new System.EventHandler(this.btn_addSong_Click);
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(318, 116);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(200, 26);
            this.txt_songTitle.TabIndex = 5;
            this.txt_songTitle.Text = "Title";
            // 
            // txt_songArtist
            // 
            this.txt_songArtist.Location = new System.Drawing.Point(318, 148);
            this.txt_songArtist.Name = "txt_songArtist";
            this.txt_songArtist.Size = new System.Drawing.Size(200, 26);
            this.txt_songArtist.TabIndex = 6;
            this.txt_songArtist.Text = "Artist";
            // 
            // txt_songGenre
            // 
            this.txt_songGenre.Location = new System.Drawing.Point(318, 180);
            this.txt_songGenre.Name = "txt_songGenre";
            this.txt_songGenre.Size = new System.Drawing.Size(200, 26);
            this.txt_songGenre.TabIndex = 7;
            this.txt_songGenre.Text = "Genre";
            // 
            // txt_songDuration
            // 
            this.txt_songDuration.Location = new System.Drawing.Point(318, 212);
            this.txt_songDuration.Name = "txt_songDuration";
            this.txt_songDuration.Size = new System.Drawing.Size(200, 26);
            this.txt_songDuration.TabIndex = 8;
            this.txt_songDuration.Text = "Duration (00:00:00)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 667);
            this.Controls.Add(this.txt_songDuration);
            this.Controls.Add(this.txt_songGenre);
            this.Controls.Add(this.txt_songArtist);
            this.Controls.Add(this.txt_songTitle);
            this.Controls.Add(this.btn_addSong);
            this.Controls.Add(this.txt_playlistTitle);
            this.Controls.Add(this.btn_createPlaylist);
            this.Controls.Add(this.lbx_playlists);
            this.Controls.Add(this.btn_listPlaylists);
            this.Name = "Form1";
            this.Text = "Playlist Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listPlaylists;
        private System.Windows.Forms.ListBox lbx_playlists;
        private System.Windows.Forms.Button btn_createPlaylist;
        private System.Windows.Forms.TextBox txt_playlistTitle;
        private System.Windows.Forms.Button btn_addSong;
        private System.Windows.Forms.TextBox txt_songTitle;
        private System.Windows.Forms.TextBox txt_songArtist;
        private System.Windows.Forms.TextBox txt_songGenre;
        private System.Windows.Forms.TextBox txt_songDuration;
    }
}

