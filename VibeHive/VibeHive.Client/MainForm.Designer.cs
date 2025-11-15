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
            lblEventId = new Label();
            txtEventId = new TextBox();
            lblUserId = new Label();
            txtUserId = new TextBox();
            btnBookTicket = new Button();
            lblBookingStatus = new Label();
            lblTickets = new Label();
            txtMyUserId = new TextBox();
            btnLoadTickets = new Button();
            dgvTickets = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            grpBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            //
            // lblEvents
            //
            lblEvents.AutoSize = true;
            lblEvents.Location = new Point(12, 21);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(124, 20);
            lblEvents.TabIndex = 0;
            lblEvents.Text = "Upcoming Events";
            //
            // dgvEvents
            //
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Location = new Point(12, 57);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(413, 438);
            dgvEvents.TabIndex = 1;
            dgvEvents.SelectionChanged += dgvEvents_SelectionChanged;
            //
            // btnLoadEvents
            //
            btnLoadEvents.Location = new Point(142, 17);
            btnLoadEvents.Name = "btnLoadEvents";
            btnLoadEvents.Size = new Size(94, 29);
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
            grpBooking.Location = new Point(519, 57);
            grpBooking.Name = "grpBooking";
            grpBooking.Size = new Size(424, 438);
            grpBooking.TabIndex = 3;
            grpBooking.TabStop = false;
            grpBooking.Text = "Book Ticket";
            //
            // lblEventId
            //
            lblEventId.AutoSize = true;
            lblEventId.Location = new Point(20, 40);
            lblEventId.Name = "lblEventId";
            lblEventId.Size = new Size(109, 20);
            lblEventId.TabIndex = 0;
            lblEventId.Text = "Select Event Id:";
            //
            // txtEventId
            //
            txtEventId.Location = new Point(135, 40);
            txtEventId.Name = "txtEventId";
            txtEventId.ReadOnly = true;
            txtEventId.Size = new Size(125, 27);
            txtEventId.TabIndex = 1;
            //
            // lblUserId
            //
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(20, 102);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(58, 20);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "User Id:";
            //
            // txtUserId
            //
            txtUserId.Location = new Point(135, 95);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(125, 27);
            txtUserId.TabIndex = 3;
            //
            // btnBookTicket
            //
            btnBookTicket.Location = new Point(152, 180);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(94, 29);
            btnBookTicket.TabIndex = 4;
            btnBookTicket.Text = "Book Ticket";
            btnBookTicket.UseVisualStyleBackColor = true;
            btnBookTicket.Click += btnBookTicket_Click;
            //
            // lblBookingStatus
            //
            lblBookingStatus.AutoSize = true;
            lblBookingStatus.ForeColor = Color.Green;
            lblBookingStatus.Location = new Point(20, 271);
            lblBookingStatus.Name = "lblBookingStatus";
            lblBookingStatus.Size = new Size(0, 20);
            lblBookingStatus.TabIndex = 5;
            //
            // lblTickets
            //
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(1024, 31);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(78, 20);
            lblTickets.TabIndex = 4;
            lblTickets.Text = "My Tickets";
            //
            // txtMyUserId
            //
            txtMyUserId.Location = new Point(1118, 28);
            txtMyUserId.Name = "txtMyUserId";
            txtMyUserId.Size = new Size(125, 27);
            txtMyUserId.TabIndex = 5;
            //
            // btnLoadTickets
            //
            btnLoadTickets.Location = new Point(1263, 27);
            btnLoadTickets.Name = "btnLoadTickets";
            btnLoadTickets.Size = new Size(131, 29);
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
            dgvTickets.Location = new Point(1024, 66);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.Size = new Size(406, 429);
            dgvTickets.TabIndex = 7;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 626);
            Controls.Add(dgvTickets);
            Controls.Add(btnLoadTickets);
            Controls.Add(txtMyUserId);
            Controls.Add(lblTickets);
            Controls.Add(grpBooking);
            Controls.Add(btnLoadEvents);
            Controls.Add(dgvEvents);
            Controls.Add(lblEvents);
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
    }
}