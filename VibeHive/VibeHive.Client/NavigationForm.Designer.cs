namespace VibeHive.Client
{
    partial class NavigationForm
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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            Mod3AddEventBtn = new Button();
            Mod3BookTicketBtn = new Button();
            Mod3RegUserBtn = new Button();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(721, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 71);
            textBox1.TabIndex = 0;
            textBox1.Text = "VIBEHIVE";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(724, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 498);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Playlist Builder";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(Mod3AddEventBtn);
            groupBox2.Controls.Add(Mod3BookTicketBtn);
            groupBox2.Controls.Add(Mod3RegUserBtn);
            groupBox2.Location = new Point(1269, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 498);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Event Ticketing";
            // 
            // Mod3AddEventBtn
            // 
            Mod3AddEventBtn.Location = new Point(59, 245);
            Mod3AddEventBtn.Name = "Mod3AddEventBtn";
            Mod3AddEventBtn.Size = new Size(358, 65);
            Mod3AddEventBtn.TabIndex = 2;
            Mod3AddEventBtn.Text = "Add Events";
            Mod3AddEventBtn.UseVisualStyleBackColor = true;
            // 
            // Mod3BookTicketBtn
            // 
            Mod3BookTicketBtn.Location = new Point(59, 154);
            Mod3BookTicketBtn.Name = "Mod3BookTicketBtn";
            Mod3BookTicketBtn.Size = new Size(358, 65);
            Mod3BookTicketBtn.TabIndex = 1;
            Mod3BookTicketBtn.Text = "Book Tickets";
            Mod3BookTicketBtn.UseVisualStyleBackColor = true;
            Mod3BookTicketBtn.Click += this.Mod3BookTicketBtn_Click;
            // 
            // Mod3RegUserBtn
            // 
            Mod3RegUserBtn.Location = new Point(59, 62);
            Mod3RegUserBtn.Name = "Mod3RegUserBtn";
            Mod3RegUserBtn.Size = new Size(358, 65);
            Mod3RegUserBtn.TabIndex = 0;
            Mod3RegUserBtn.Text = "Register Account / Login";
            Mod3RegUserBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Location = new Point(168, 230);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 498);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Music Rentals";
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 797);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "NavigationForm";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button Mod3AddEventBtn;
        private Button Mod3BookTicketBtn;
        private Button Mod3RegUserBtn;
    }
}