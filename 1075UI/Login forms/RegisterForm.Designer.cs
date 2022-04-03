
namespace _1075UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.brightPanel = new System.Windows.Forms.Panel();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.confirmPanel = new System.Windows.Forms.Panel();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.woodPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.strekovLogo = new System.Windows.Forms.PictureBox();
            this.brightPanel.SuspendLayout();
            this.confirmPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.woodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strekovLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // brightPanel
            // 
            this.brightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.brightPanel.Controls.Add(this.confirmLabel);
            this.brightPanel.Controls.Add(this.passwordLabel);
            this.brightPanel.Controls.Add(this.usernameLabel);
            this.brightPanel.Controls.Add(this.confirmPanel);
            this.brightPanel.Controls.Add(this.passwordPanel);
            this.brightPanel.Controls.Add(this.registerButton);
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
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.confirmLabel.Location = new System.Drawing.Point(12, 325);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(148, 18);
            this.confirmLabel.TabIndex = 9;
            this.confirmLabel.Text = "Confirm password*";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.passwordLabel.Location = new System.Drawing.Point(12, 250);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 18);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password*";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.usernameLabel.Location = new System.Drawing.Point(12, 175);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(88, 18);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username*";
            // 
            // confirmPanel
            // 
            this.confirmPanel.BackColor = System.Drawing.Color.White;
            this.confirmPanel.Controls.Add(this.confirmTextBox);
            this.confirmPanel.Controls.Add(this.pictureBox3);
            this.confirmPanel.Location = new System.Drawing.Point(0, 350);
            this.confirmPanel.Name = "confirmPanel";
            this.confirmPanel.Size = new System.Drawing.Size(450, 42);
            this.confirmPanel.TabIndex = 5;
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.BackColor = System.Drawing.Color.White;
            this.confirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmTextBox.ForeColor = System.Drawing.Color.BurlyWood;
            this.confirmTextBox.Location = new System.Drawing.Point(55, 11);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(392, 24);
            this.confirmTextBox.TabIndex = 4;
            this.confirmTextBox.UseSystemPasswordChar = true;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Controls.Add(this.pictureBox2);
            this.passwordPanel.Location = new System.Drawing.Point(0, 275);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(450, 42);
            this.passwordPanel.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.BurlyWood;
            this.passwordTextBox.Location = new System.Drawing.Point(55, 11);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(392, 24);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.BurlyWood;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(15, 403);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(148, 35);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.White;
            this.usernamePanel.Controls.Add(this.usernameTextBox);
            this.usernamePanel.Controls.Add(this.pictureBox1);
            this.usernamePanel.Location = new System.Drawing.Point(0, 200);
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
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.loginLabel.Location = new System.Drawing.Point(22, 127);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(119, 33);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Register";
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_1075UI.Properties.Resources.pw;
            this.pictureBox3.Location = new System.Drawing.Point(15, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_1075UI.Properties.Resources.pw;
            this.pictureBox2.Location = new System.Drawing.Point(15, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_1075UI.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // woodPanel
            // 
            this.woodPanel.BackColor = System.Drawing.Color.Transparent;
            this.woodPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("woodPanel.BackgroundImage")));
            this.woodPanel.Controls.Add(this.button1);
            this.woodPanel.Controls.Add(this.strekovLogo);
            this.woodPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.woodPanel.Location = new System.Drawing.Point(0, 0);
            this.woodPanel.Name = "woodPanel";
            this.woodPanel.Size = new System.Drawing.Size(300, 530);
            this.woodPanel.TabIndex = 0;
            this.woodPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.woodPanel_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.brightPanel);
            this.Controls.Add(this.woodPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.brightPanel.ResumeLayout(false);
            this.brightPanel.PerformLayout();
            this.confirmPanel.ResumeLayout(false);
            this.confirmPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel confirmPanel;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button button1;
    }
}