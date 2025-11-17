namespace VibeHive.Client
{
    partial class EventForm
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
            groupBox1 = new GroupBox();
            EventGenre = new TextBox();
            EventName = new TextBox();
            NavReturnBtn = new Button();
            EventVenue = new TextBox();
            EventDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EventTicketsNum = new NumericUpDown();
            AddEventBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EventTicketsNum).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(AddEventBtn);
            groupBox1.Controls.Add(EventTicketsNum);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(EventDate);
            groupBox1.Controls.Add(EventVenue);
            groupBox1.Controls.Add(EventGenre);
            groupBox1.Controls.Add(EventName);
            groupBox1.Location = new Point(494, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(862, 577);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Music Event";
            // 
            // EventGenre
            // 
            EventGenre.Location = new Point(273, 134);
            EventGenre.Name = "EventGenre";
            EventGenre.Size = new Size(550, 31);
            EventGenre.TabIndex = 1;
            // 
            // EventName
            // 
            EventName.Location = new Point(273, 72);
            EventName.Name = "EventName";
            EventName.Size = new Size(550, 31);
            EventName.TabIndex = 0;
            // 
            // NavReturnBtn
            // 
            NavReturnBtn.Location = new Point(31, 718);
            NavReturnBtn.Name = "NavReturnBtn";
            NavReturnBtn.Size = new Size(267, 65);
            NavReturnBtn.TabIndex = 1;
            NavReturnBtn.Text = "Back to Menu";
            NavReturnBtn.UseVisualStyleBackColor = true;
            NavReturnBtn.Click += NavReturnBtn_Click;
            // 
            // EventVenue
            // 
            EventVenue.Location = new Point(273, 267);
            EventVenue.Name = "EventVenue";
            EventVenue.Size = new Size(550, 31);
            EventVenue.TabIndex = 2;
            // 
            // EventDate
            // 
            EventDate.Location = new Point(273, 203);
            EventDate.Name = "EventDate";
            EventDate.Size = new Size(550, 31);
            EventDate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 140);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 6;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 209);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 7;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 273);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 8;
            label4.Text = "Venue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 340);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 9;
            label5.Text = "Available Tickets";
            // 
            // EventTicketsNum
            // 
            EventTicketsNum.Location = new Point(273, 340);
            EventTicketsNum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            EventTicketsNum.Name = "EventTicketsNum";
            EventTicketsNum.Size = new Size(550, 31);
            EventTicketsNum.TabIndex = 10;
            EventTicketsNum.TextAlign = HorizontalAlignment.Center;
            // 
            // AddEventBtn
            // 
            AddEventBtn.Location = new Point(294, 477);
            AddEventBtn.Name = "AddEventBtn";
            AddEventBtn.Size = new Size(282, 61);
            AddEventBtn.TabIndex = 11;
            AddEventBtn.Text = "Add Event";
            AddEventBtn.UseVisualStyleBackColor = true;
            AddEventBtn.Click += AddEventBtn_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 804);
            Controls.Add(NavReturnBtn);
            Controls.Add(groupBox1);
            Name = "EventForm";
            Text = "EventForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EventTicketsNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button NavReturnBtn;
        private TextBox EventGenre;
        private TextBox EventName;
        private TextBox EventVenue;
        private DateTimePicker EventDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown EventTicketsNum;
        private Button AddEventBtn;
    }
}