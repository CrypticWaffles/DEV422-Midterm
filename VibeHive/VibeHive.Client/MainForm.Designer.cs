using System.Drawing;
using System.Windows.Forms;
namespace VibeHive.Client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblEvents = new Label();
            dgvEvents = new DataGridView();
            btnLoadEvents = new Button();
            grpBooking = new GroupBox();
            lblBookingStatus = new Label();
            btnBookTicket = new Button();
            txtUserId = new TextBox();
            lblUserId = new Label();
            txtEventId = new TextBox();
            lblEventId = new Label();
            lblTickets = new Label();
            txtMyUserId = new TextBox();
            btnLoadTickets = new Button();
            dgvTickets = new DataGridView();
            NavReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            grpBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.Location = new Point(15, 26);
            lblEvents.Margin = new Padding(4, 0, 4, 0);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(151, 25);
            lblEvents.TabIndex = 0;
            lblEvents.Text = "Upcoming Events";
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(15, 71);
            dgvEvents.Margin = new Padding(4);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(516, 548);
            dgvEvents.TabIndex = 1;
            dgvEvents.SelectionChanged += dgvEvents_SelectionChanged;
            // 
            // btnLoadEvents
            // 
            btnLoadEvents.Location = new Point(178, 21);
            btnLoadEvents.Margin = new Padding(4);
            btnLoadEvents.Name = "btnLoadEvents";
            btnLoadEvents.Size = new Size(118, 36);
            btnLoadEvents.TabIndex = 2;
            btnLoadEvents.Text = "Load Events";
            btnLoadEvents.UseVisualStyleBackColor = true;
            btnLoadEvents.Click += btnLoadEvents_Click;
            // 
            // grpBooking
            // 
            grpBooking.Controls.Add(lblBookingStatus);
            grpBooking.Controls.Add(btnBookTicket);
            grpBooking.Controls.Add(txtUserId);
            grpBooking.Controls.Add(lblUserId);
            grpBooking.Controls.Add(txtEventId);
            grpBooking.Controls.Add(lblEventId);
            grpBooking.Location = new Point(649, 71);
            grpBooking.Margin = new Padding(4);
            grpBooking.Name = "grpBooking";
            grpBooking.Padding = new Padding(4);
            grpBooking.Size = new Size(530, 548);
            grpBooking.TabIndex = 3;
            grpBooking.TabStop = false;
            grpBooking.Text = "Book Ticket";
            // 
            // lblBookingStatus
            // 
            lblBookingStatus.AutoSize = true;
            lblBookingStatus.ForeColor = Color.Green;
            lblBookingStatus.Location = new Point(25, 339);
            lblBookingStatus.Margin = new Padding(4, 0, 4, 0);
            lblBookingStatus.Name = "lblBookingStatus";
            lblBookingStatus.Size = new Size(0, 25);
            lblBookingStatus.TabIndex = 5;
            // 
            // btnBookTicket
            // 
            btnBookTicket.Location = new Point(190, 225);
            btnBookTicket.Margin = new Padding(4);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(118, 36);
            btnBookTicket.TabIndex = 4;
            btnBookTicket.Text = "Book Ticket";
            btnBookTicket.UseVisualStyleBackColor = true;
            btnBookTicket.Click += btnBookTicket_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(169, 119);
            txtUserId.Margin = new Padding(4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(155, 31);
            txtUserId.TabIndex = 3;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(25, 128);
            lblUserId.Margin = new Padding(4, 0, 4, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(72, 25);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "User Id:";
            // 
            // txtEventId
            // 
            txtEventId.Location = new Point(169, 50);
            txtEventId.Margin = new Padding(4);
            txtEventId.Name = "txtEventId";
            txtEventId.ReadOnly = true;
            txtEventId.Size = new Size(155, 31);
            txtEventId.TabIndex = 1;
            // 
            // lblEventId
            // 
            lblEventId.AutoSize = true;
            lblEventId.Location = new Point(25, 50);
            lblEventId.Margin = new Padding(4, 0, 4, 0);
            lblEventId.Name = "lblEventId";
            lblEventId.Size = new Size(131, 25);
            lblEventId.TabIndex = 0;
            lblEventId.Text = "Select Event Id:";
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(1280, 39);
            lblTickets.Margin = new Padding(4, 0, 4, 0);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(95, 25);
            lblTickets.TabIndex = 4;
            lblTickets.Text = "My Tickets";
            // 
            // txtMyUserId
            // 
            txtMyUserId.Location = new Point(1398, 35);
            txtMyUserId.Margin = new Padding(4);
            txtMyUserId.Name = "txtMyUserId";
            txtMyUserId.Size = new Size(155, 31);
            txtMyUserId.TabIndex = 5;
            // 
            // btnLoadTickets
            // 
            btnLoadTickets.Location = new Point(1579, 34);
            btnLoadTickets.Margin = new Padding(4);
            btnLoadTickets.Name = "btnLoadTickets";
            btnLoadTickets.Size = new Size(164, 36);
            btnLoadTickets.TabIndex = 6;
            btnLoadTickets.Text = "Load My Tickets";
            btnLoadTickets.UseVisualStyleBackColor = true;
            btnLoadTickets.Click += btnLoadTickets_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(1280, 82);
            dgvTickets.Margin = new Padding(4);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.Size = new Size(508, 536);
            dgvTickets.TabIndex = 7;
            // 
            // NavReturnBtn
            // 
            NavReturnBtn.Location = new Point(26, 704);
            NavReturnBtn.Name = "NavReturnBtn";
            NavReturnBtn.Size = new Size(263, 60);
            NavReturnBtn.TabIndex = 8;
            NavReturnBtn.Text = "Back to Menu";
            NavReturnBtn.UseVisualStyleBackColor = true;
            NavReturnBtn.Click += NavReturnBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 782);
            Controls.Add(NavReturnBtn);
            Controls.Add(dgvTickets);
            Controls.Add(btnLoadTickets);
            Controls.Add(txtMyUserId);
            Controls.Add(lblTickets);
            Controls.Add(grpBooking);
            Controls.Add(btnLoadEvents);
            Controls.Add(dgvEvents);
            Controls.Add(lblEvents);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "VibeHive - Events & Tickets";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            grpBooking.ResumeLayout(false);
            grpBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblEvents;
        private DataGridView dgvEvents;
        private Button btnLoadEvents;
        private GroupBox grpBooking;
        private Label lblEventId;
        private TextBox txtEventId;
        private Label lblUserId;
        private TextBox txtUserId;
        private Button btnBookTicket;
        private Label lblBookingStatus;
        private Label lblTickets;
        private TextBox txtMyUserId;
        private Button btnLoadTickets;
        private DataGridView dgvTickets;
        private Button NavReturnBtn;
    }
}