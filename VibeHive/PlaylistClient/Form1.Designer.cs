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
            this.btn_getRankings = new System.Windows.Forms.Button();
            this.btn_voteSong = new System.Windows.Forms.Button();
            this.lbx_songRankings = new System.Windows.Forms.ListBox();
            this.btn_createUser = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.cbx_currentUser = new System.Windows.Forms.ComboBox();
            this.btn_invite = new System.Windows.Forms.Button();
            this.lbx_users = new System.Windows.Forms.ListBox();
            this.btn_getUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_listPlaylists
            // 
            this.btn_listPlaylists.Location = new System.Drawing.Point(13, 347);
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
            this.lbx_playlists.Location = new System.Drawing.Point(13, 137);
            this.lbx_playlists.Name = "lbx_playlists";
            this.lbx_playlists.Size = new System.Drawing.Size(269, 204);
            this.lbx_playlists.TabIndex = 1;
            // 
            // btn_createPlaylist
            // 
            this.btn_createPlaylist.Location = new System.Drawing.Point(288, 169);
            this.btn_createPlaylist.Name = "btn_createPlaylist";
            this.btn_createPlaylist.Size = new System.Drawing.Size(121, 22);
            this.btn_createPlaylist.TabIndex = 2;
            this.btn_createPlaylist.Text = "Create Playlist";
            this.btn_createPlaylist.UseVisualStyleBackColor = true;
            this.btn_createPlaylist.Click += new System.EventHandler(this.btn_createPlaylist_Click);
            // 
            // txt_playlistTitle
            // 
            this.txt_playlistTitle.Location = new System.Drawing.Point(288, 137);
            this.txt_playlistTitle.Name = "txt_playlistTitle";
            this.txt_playlistTitle.Size = new System.Drawing.Size(200, 26);
            this.txt_playlistTitle.TabIndex = 3;
            this.txt_playlistTitle.Text = "Title";
            // 
            // btn_addSong
            // 
            this.btn_addSong.Location = new System.Drawing.Point(288, 325);
            this.btn_addSong.Name = "btn_addSong";
            this.btn_addSong.Size = new System.Drawing.Size(106, 23);
            this.btn_addSong.TabIndex = 4;
            this.btn_addSong.Text = "Add Song";
            this.btn_addSong.UseVisualStyleBackColor = true;
            this.btn_addSong.Click += new System.EventHandler(this.btn_addSong_Click);
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(288, 197);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(200, 26);
            this.txt_songTitle.TabIndex = 5;
            this.txt_songTitle.Text = "Title";
            // 
            // txt_songArtist
            // 
            this.txt_songArtist.Location = new System.Drawing.Point(288, 229);
            this.txt_songArtist.Name = "txt_songArtist";
            this.txt_songArtist.Size = new System.Drawing.Size(200, 26);
            this.txt_songArtist.TabIndex = 6;
            this.txt_songArtist.Text = "Artist";
            // 
            // txt_songGenre
            // 
            this.txt_songGenre.Location = new System.Drawing.Point(288, 261);
            this.txt_songGenre.Name = "txt_songGenre";
            this.txt_songGenre.Size = new System.Drawing.Size(200, 26);
            this.txt_songGenre.TabIndex = 7;
            this.txt_songGenre.Text = "Genre";
            // 
            // txt_songDuration
            // 
            this.txt_songDuration.Location = new System.Drawing.Point(288, 293);
            this.txt_songDuration.Name = "txt_songDuration";
            this.txt_songDuration.Size = new System.Drawing.Size(200, 26);
            this.txt_songDuration.TabIndex = 8;
            this.txt_songDuration.Text = "Duration (00:00:00)";
            // 
            // btn_getRankings
            // 
            this.btn_getRankings.Location = new System.Drawing.Point(13, 621);
            this.btn_getRankings.Name = "btn_getRankings";
            this.btn_getRankings.Size = new System.Drawing.Size(172, 23);
            this.btn_getRankings.TabIndex = 10;
            this.btn_getRankings.Text = "Get Song rankings";
            this.btn_getRankings.UseVisualStyleBackColor = true;
            this.btn_getRankings.Click += new System.EventHandler(this.btn_getRankings_Click);
            // 
            // btn_voteSong
            // 
            this.btn_voteSong.Location = new System.Drawing.Point(413, 621);
            this.btn_voteSong.Name = "btn_voteSong";
            this.btn_voteSong.Size = new System.Drawing.Size(75, 23);
            this.btn_voteSong.TabIndex = 11;
            this.btn_voteSong.Text = "Vote";
            this.btn_voteSong.UseVisualStyleBackColor = true;
            this.btn_voteSong.Click += new System.EventHandler(this.btn_voteSong_Click);
            // 
            // lbx_songRankings
            // 
            this.lbx_songRankings.FormattingEnabled = true;
            this.lbx_songRankings.ItemHeight = 20;
            this.lbx_songRankings.Location = new System.Drawing.Point(13, 411);
            this.lbx_songRankings.Name = "lbx_songRankings";
            this.lbx_songRankings.Size = new System.Drawing.Size(475, 204);
            this.lbx_songRankings.TabIndex = 12;
            // 
            // btn_createUser
            // 
            this.btn_createUser.Location = new System.Drawing.Point(12, 78);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(113, 23);
            this.btn_createUser.TabIndex = 13;
            this.btn_createUser.Text = "Create User";
            this.btn_createUser.UseVisualStyleBackColor = true;
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 46);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(200, 26);
            this.txt_username.TabIndex = 14;
            this.txt_username.Text = "Username";
            // 
            // cbx_currentUser
            // 
            this.cbx_currentUser.FormattingEnabled = true;
            this.cbx_currentUser.Location = new System.Drawing.Point(12, 12);
            this.cbx_currentUser.Name = "cbx_currentUser";
            this.cbx_currentUser.Size = new System.Drawing.Size(200, 28);
            this.cbx_currentUser.TabIndex = 15;
            // 
            // btn_invite
            // 
            this.btn_invite.Location = new System.Drawing.Point(688, 347);
            this.btn_invite.Name = "btn_invite";
            this.btn_invite.Size = new System.Drawing.Size(114, 23);
            this.btn_invite.TabIndex = 16;
            this.btn_invite.Text = "Invite User";
            this.btn_invite.UseVisualStyleBackColor = true;
            this.btn_invite.Click += new System.EventHandler(this.btn_invite_Click);
            // 
            // lbx_users
            // 
            this.lbx_users.FormattingEnabled = true;
            this.lbx_users.ItemHeight = 20;
            this.lbx_users.Location = new System.Drawing.Point(532, 137);
            this.lbx_users.Name = "lbx_users";
            this.lbx_users.Size = new System.Drawing.Size(270, 204);
            this.lbx_users.TabIndex = 17;
            // 
            // btn_getUsers
            // 
            this.btn_getUsers.Location = new System.Drawing.Point(532, 347);
            this.btn_getUsers.Name = "btn_getUsers";
            this.btn_getUsers.Size = new System.Drawing.Size(95, 23);
            this.btn_getUsers.TabIndex = 18;
            this.btn_getUsers.Text = "Get Users";
            this.btn_getUsers.UseVisualStyleBackColor = true;
            this.btn_getUsers.Click += new System.EventHandler(this.btn_getUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 663);
            this.Controls.Add(this.btn_getUsers);
            this.Controls.Add(this.lbx_users);
            this.Controls.Add(this.btn_invite);
            this.Controls.Add(this.cbx_currentUser);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_createUser);
            this.Controls.Add(this.lbx_songRankings);
            this.Controls.Add(this.btn_voteSong);
            this.Controls.Add(this.btn_getRankings);
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
        private System.Windows.Forms.Button btn_getRankings;
        private System.Windows.Forms.Button btn_voteSong;
        private System.Windows.Forms.ListBox lbx_songRankings;
        private System.Windows.Forms.Button btn_createUser;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.ComboBox cbx_currentUser;
        private System.Windows.Forms.Button btn_invite;
        private System.Windows.Forms.ListBox lbx_users;
        private System.Windows.Forms.Button btn_getUsers;
    }
}

