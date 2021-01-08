
namespace SomeGames
{
    partial class Ip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ip));
            this.ipInfoLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipInfoLabel
            // 
            this.ipInfoLabel.AutoSize = true;
            this.ipInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipInfoLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ipInfoLabel.Location = new System.Drawing.Point(39, 41);
            this.ipInfoLabel.Name = "ipInfoLabel";
            this.ipInfoLabel.Size = new System.Drawing.Size(41, 24);
            this.ipInfoLabel.TabIndex = 0;
            this.ipInfoLabel.Text = "IP : ";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipLabel.Location = new System.Drawing.Point(104, 41);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(25, 24);
            this.ipLabel.TabIndex = 1;
            this.ipLabel.Text = "ip";
            this.ipLabel.Click += new System.EventHandler(this.ipLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Veriler \"https://www.ipnedir.com\" sitesinden alınmıştır.";
            // 
            // Ip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(319, 136);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ipInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ip Adresim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipInfoLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label label10;
    }
}