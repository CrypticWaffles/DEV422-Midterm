namespace VibeHive.Client
{
    partial class RegisterForm
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
            label4 = new Label();
            RegRoleInput = new ComboBox();
            RegPasswordInput = new TextBox();
            label3 = new Label();
            RegEmailInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RegNameInput = new TextBox();
            RegisterBtn = new Button();
            groupBox2 = new GroupBox();
            NavReturnBtn = new Button();
            LoginNameInput = new TextBox();
            LoginPassInput = new TextBox();
            LoginBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(RegRoleInput);
            groupBox1.Controls.Add(RegPasswordInput);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(RegEmailInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(RegNameInput);
            groupBox1.Controls.Add(RegisterBtn);
            groupBox1.Location = new Point(331, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 434);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 252);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 9;
            label4.Text = "Role";
            // 
            // RegRoleInput
            // 
            RegRoleInput.FormattingEnabled = true;
            RegRoleInput.Items.AddRange(new object[] { "User", "Admin", "Event Manager" });
            RegRoleInput.Location = new Point(192, 249);
            RegRoleInput.Name = "RegRoleInput";
            RegRoleInput.Size = new Size(280, 33);
            RegRoleInput.TabIndex = 8;
            // 
            // RegPasswordInput
            // 
            RegPasswordInput.Location = new Point(192, 184);
            RegPasswordInput.Name = "RegPasswordInput";
            RegPasswordInput.Size = new Size(280, 31);
            RegPasswordInput.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 190);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // RegEmailInput
            // 
            RegEmailInput.Location = new Point(192, 126);
            RegEmailInput.Name = "RegEmailInput";
            RegEmailInput.Size = new Size(280, 31);
            RegEmailInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 129);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 67);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // RegNameInput
            // 
            RegNameInput.Location = new Point(192, 64);
            RegNameInput.Name = "RegNameInput";
            RegNameInput.Size = new Size(280, 31);
            RegNameInput.TabIndex = 1;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(136, 366);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(250, 53);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(LoginBtn);
            groupBox2.Controls.Add(LoginPassInput);
            groupBox2.Controls.Add(LoginNameInput);
            groupBox2.Location = new Point(941, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(526, 434);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Login";
            // 
            // NavReturnBtn
            // 
            NavReturnBtn.Location = new Point(39, 727);
            NavReturnBtn.Name = "NavReturnBtn";
            NavReturnBtn.Size = new Size(250, 53);
            NavReturnBtn.TabIndex = 10;
            NavReturnBtn.Text = "Back to Menu";
            NavReturnBtn.UseVisualStyleBackColor = true;
            NavReturnBtn.Click += NavReturnBtn_Click;
            // 
            // LoginNameInput
            // 
            LoginNameInput.Location = new Point(215, 67);
            LoginNameInput.Name = "LoginNameInput";
            LoginNameInput.Size = new Size(255, 31);
            LoginNameInput.TabIndex = 0;
            // 
            // LoginPassInput
            // 
            LoginPassInput.Location = new Point(215, 129);
            LoginPassInput.Name = "LoginPassInput";
            LoginPassInput.Size = new Size(255, 31);
            LoginPassInput.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(139, 366);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(250, 53);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "Register";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 70);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 11;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 132);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 805);
            Controls.Add(NavReturnBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox RegNameInput;
        private Button RegisterBtn;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox RegEmailInput;
        private Label label2;
        private Label label3;
        private TextBox RegPasswordInput;
        private ComboBox RegRoleInput;
        private Label label4;
        private Button NavReturnBtn;
        private Label label6;
        private Label label5;
        private Button LoginBtn;
        private TextBox LoginPassInput;
        private TextBox LoginNameInput;
    }
}