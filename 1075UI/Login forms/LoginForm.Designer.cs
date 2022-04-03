
namespace _1075UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.brightPanel = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.forgetButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.woodPanel = new System.Windows.Forms.Panel();
            this.strekovLogo = new System.Windows.Forms.PictureBox();
            this.brightPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.woodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strekovLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // brightPanel
            // 
            this.brightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.brightPanel.Controls.Add(this.registerButton);
            this.brightPanel.Controls.Add(this.forgetButton);
            this.brightPanel.Controls.Add(this.loginButton);
            this.brightPanel.Controls.Add(this.passwordPanel);
            this.brightPanel.Controls.Add(this.usernamePanel);
            this.brightPanel.Controls.Add(this.loginLabel);
            this.brightPanel.Controls.Add(this.closeButton);
            this.brightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brightPanel.Location = new System.Drawing.Point(300, 0);
            this.brightPanel.Name = "brightPanel";
            this.brightPanel.Size = new System.Drawing.Size(450, 530);
            this.brightPanel.TabIndex = 1;
            this.brightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.brightPanel_MouseDown);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.Control;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.registerButton.Location = new System.Drawing.Point(169, 304);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(62, 25);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // forgetButton
            // 
            this.forgetButton.BackColor = System.Drawing.SystemColors.Control;
            this.forgetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.forgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forgetButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.forgetButton.Location = new System.Drawing.Point(169, 322);
            this.forgetButton.Name = "forgetButton";
            this.forgetButton.Size = new System.Drawing.Size(113, 25);
            this.forgetButton.TabIndex = 7;
            this.forgetButton.Text = "Forgot password?";
            this.forgetButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.BurlyWood;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(15, 310);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(148, 35);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.SystemColors.Control;
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Controls.Add(this.passwordPictureBox);
            this.passwordPanel.Location = new System.Drawing.Point(0, 236);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(450, 42);
            this.passwordPanel.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.BurlyWood;
            this.passwordTextBox.Location = new System.Drawing.Point(55, 11);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(392, 24);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.White;
            this.usernamePanel.Controls.Add(this.usernameTextBox);
            this.usernamePanel.Controls.Add(this.userPictureBox);
            this.usernamePanel.Location = new System.Drawing.Point(0, 188);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(450, 42);
            this.usernamePanel.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.BurlyWood;
            this.usernameTextBox.Location = new System.Drawing.Point(55, 11);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(392, 24);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Click += new System.EventHandler(this.usernameTextBox_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.loginLabel.Location = new System.Drawing.Point(22, 127);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(303, 33);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Log into your account";
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.closeButton.Location = new System.Drawing.Point(407, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.Image = global::_1075UI.Properties.Resources.pw;
            this.passwordPictureBox.Location = new System.Drawing.Point(15, 11);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(24, 24);
            this.passwordPictureBox.TabIndex = 2;
            this.passwordPictureBox.TabStop = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::_1075UI.Properties.Resources.user1;
            this.userPictureBox.Location = new System.Drawing.Point(15, 11);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(24, 24);
            this.userPictureBox.TabIndex = 1;
            this.userPictureBox.TabStop = false;
            // 
            // woodPanel
            // 
            this.woodPanel.BackColor = System.Drawing.Color.Transparent;
            this.woodPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("woodPanel.BackgroundImage")));
            this.woodPanel.Controls.Add(this.strekovLogo);
            this.woodPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.woodPanel.Location = new System.Drawing.Point(0, 0);
            this.woodPanel.Name = "woodPanel";
            this.woodPanel.Size = new System.Drawing.Size(300, 530);
            this.woodPanel.TabIndex = 0;
            this.woodPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.woodPanel_MouseDown);
            // 
            // strekovLogo
            // 
            this.strekovLogo.Image = global::_1075UI.Properties.Resources.strekov1075logo;
            this.strekovLogo.Location = new System.Drawing.Point(75, 40);
            this.strekovLogo.Name = "strekovLogo";
            this.strekovLogo.Size = new System.Drawing.Size(150, 120);
            this.strekovLogo.TabIndex = 0;
            this.strekovLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.brightPanel);
            this.Controls.Add(this.woodPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.brightPanel.ResumeLayout(false);
            this.brightPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.woodPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.strekovLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel woodPanel;
        private System.Windows.Forms.PictureBox strekovLogo;
        private System.Windows.Forms.Panel brightPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button forgetButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registerButton;
    }
}