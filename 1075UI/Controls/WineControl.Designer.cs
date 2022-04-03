
namespace _1075UI
{
    partial class WineControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.winePictureBox = new System.Windows.Forms.PictureBox();
            this.wineNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // winePictureBox
            // 
            this.winePictureBox.Image = global::_1075UI.Properties.Resources.fred_test;
            this.winePictureBox.Location = new System.Drawing.Point(54, 3);
            this.winePictureBox.Name = "winePictureBox";
            this.winePictureBox.Size = new System.Drawing.Size(71, 220);
            this.winePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winePictureBox.TabIndex = 0;
            this.winePictureBox.TabStop = false;
            // 
            // wineNameLabel
            // 
            this.wineNameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wineNameLabel.ForeColor = System.Drawing.Color.Black;
            this.wineNameLabel.Location = new System.Drawing.Point(0, 226);
            this.wineNameLabel.Name = "wineNameLabel";
            this.wineNameLabel.Size = new System.Drawing.Size(178, 23);
            this.wineNameLabel.TabIndex = 1;
            this.wineNameLabel.Text = "WineName";
            this.wineNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wineNameLabel);
            this.Controls.Add(this.winePictureBox);
            this.Name = "WineControl";
            this.Size = new System.Drawing.Size(178, 260);
            ((System.ComponentModel.ISupportInitialize)(this.winePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox winePictureBox;
        private System.Windows.Forms.Label wineNameLabel;
    }
}
