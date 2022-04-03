
namespace _1075UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.formLoaderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.shipmentsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.winesButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.closeButton.Location = new System.Drawing.Point(911, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 25.25F);
            this.titleLabel.ForeColor = System.Drawing.Color.BurlyWood;
            this.titleLabel.Location = new System.Drawing.Point(215, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 40);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Dashboard";
            // 
            // formLoaderPanel
            // 
            this.formLoaderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formLoaderPanel.Location = new System.Drawing.Point(186, 71);
            this.formLoaderPanel.Name = "formLoaderPanel";
            this.formLoaderPanel.Size = new System.Drawing.Size(765, 506);
            this.formLoaderPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::_1075UI.Properties.Resources.background_slightblur;
            this.panel1.Controls.Add(this.navPanel);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.shipmentsButton);
            this.panel1.Controls.Add(this.inventoryButton);
            this.panel1.Controls.Add(this.winesButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.navPanel.Location = new System.Drawing.Point(0, 175);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(5, 100);
            this.navPanel.TabIndex = 2;
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.settingsButton.Image = global::_1075UI.Properties.Resources.settings;
            this.settingsButton.Location = new System.Drawing.Point(0, 535);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(186, 42);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.Leave += new System.EventHandler(this.settingsButton_Leave);
            // 
            // shipmentsButton
            // 
            this.shipmentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shipmentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.shipmentsButton.FlatAppearance.BorderSize = 0;
            this.shipmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shipmentsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shipmentsButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.shipmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("shipmentsButton.Image")));
            this.shipmentsButton.Location = new System.Drawing.Point(0, 270);
            this.shipmentsButton.Name = "shipmentsButton";
            this.shipmentsButton.Size = new System.Drawing.Size(186, 42);
            this.shipmentsButton.TabIndex = 1;
            this.shipmentsButton.Text = "Shipments";
            this.shipmentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.shipmentsButton.UseVisualStyleBackColor = true;
            this.shipmentsButton.Click += new System.EventHandler(this.shipmentsButton_Click);
            this.shipmentsButton.Leave += new System.EventHandler(this.shipmentsButton_Leave);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inventoryButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.inventoryButton.Image = global::_1075UI.Properties.Resources.inventory;
            this.inventoryButton.Location = new System.Drawing.Point(0, 228);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(186, 42);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            this.inventoryButton.Leave += new System.EventHandler(this.inventoryButton_Leave);
            // 
            // winesButton
            // 
            this.winesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.winesButton.FlatAppearance.BorderSize = 0;
            this.winesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winesButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.winesButton.Image = ((System.Drawing.Image)(resources.GetObject("winesButton.Image")));
            this.winesButton.Location = new System.Drawing.Point(0, 186);
            this.winesButton.Name = "winesButton";
            this.winesButton.Size = new System.Drawing.Size(186, 42);
            this.winesButton.TabIndex = 1;
            this.winesButton.Text = "Wines";
            this.winesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.winesButton.UseVisualStyleBackColor = true;
            this.winesButton.Click += new System.EventHandler(this.winesButton_Click);
            this.winesButton.Leave += new System.EventHandler(this.winesButton_Leave);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashboardButton.ForeColor = System.Drawing.Color.BurlyWood;
            this.dashboardButton.Image = global::_1075UI.Properties.Resources.home;
            this.dashboardButton.Location = new System.Drawing.Point(0, 144);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(186, 42);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            this.dashboardButton.Leave += new System.EventHandler(this.dashboardButton_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.usernameLabel.Location = new System.Drawing.Point(0, 92);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(186, 25);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "a";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::_1075UI.Properties.Resources.usermedium;
            this.pictureBox1.Location = new System.Drawing.Point(52, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.formLoaderPanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DashboardForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button shipmentsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button winesButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel formLoaderPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}