namespace WorkoutTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogIn = new Label();
            btnLogIn = new Button();
            btnRegister = new Button();
            lblPassword = new Label();
            lblEmail = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // lblLogIn
            // 
            lblLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogIn.Font = new Font("Segoe UI", 29F);
            lblLogIn.Location = new Point(22, 19);
            lblLogIn.Margin = new Padding(6, 0, 6, 0);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(366, 132);
            lblLogIn.TabIndex = 0;
            lblLogIn.Text = "Logga In";
            lblLogIn.Click += label1_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogIn.Location = new Point(22, 764);
            btnLogIn.Margin = new Padding(6, 6, 6, 6);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(1209, 79);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "Logga In";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.Location = new Point(22, 855);
            btnRegister.Margin = new Padding(6, 6, 6, 6);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(1209, 79);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Registrera";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPassword.Font = new Font("Segoe UI", 20F);
            lblPassword.Location = new Point(22, 433);
            lblPassword.Margin = new Padding(6, 0, 6, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(309, 92);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Lösenord";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.Font = new Font("Segoe UI", 20F);
            lblEmail.Location = new Point(22, 201);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(188, 98);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-post";
            lblEmail.Click += label2_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(22, 305);
            tbEmail.Margin = new Padding(6, 6, 6, 6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(329, 39);
            tbEmail.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(22, 531);
            tbPassword.Margin = new Padding(6, 6, 6, 6);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(329, 39);
            tbPassword.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 960);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(lblLogIn);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogIn;
        private Button btnLogIn;
        private Button btnRegister;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox tbEmail;
        private TextBox tbPassword;
    }
}
