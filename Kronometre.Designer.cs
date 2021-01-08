namespace SomeGames
{
    partial class Kronometre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kronometre));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.baslaButton = new System.Windows.Forms.Button();
            this.durdurButton = new System.Windows.Forms.Button();
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.zamanLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // baslaButton
            // 
            this.baslaButton.BackColor = System.Drawing.Color.Firebrick;
            this.baslaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.baslaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslaButton.ForeColor = System.Drawing.Color.Gold;
            this.baslaButton.Location = new System.Drawing.Point(27, 10);
            this.baslaButton.Margin = new System.Windows.Forms.Padding(2);
            this.baslaButton.Name = "baslaButton";
            this.baslaButton.Size = new System.Drawing.Size(81, 30);
            this.baslaButton.TabIndex = 0;
            this.baslaButton.Text = "BAŞLA";
            this.baslaButton.UseVisualStyleBackColor = false;
            this.baslaButton.Click += new System.EventHandler(this.baslaButton_Click);
            // 
            // durdurButton
            // 
            this.durdurButton.BackColor = System.Drawing.Color.Firebrick;
            this.durdurButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.durdurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durdurButton.ForeColor = System.Drawing.Color.Gold;
            this.durdurButton.Location = new System.Drawing.Point(112, 10);
            this.durdurButton.Margin = new System.Windows.Forms.Padding(2);
            this.durdurButton.Name = "durdurButton";
            this.durdurButton.Size = new System.Drawing.Size(81, 30);
            this.durdurButton.TabIndex = 1;
            this.durdurButton.Text = "DURDUR";
            this.durdurButton.UseVisualStyleBackColor = false;
            this.durdurButton.Click += new System.EventHandler(this.durdurButton_Click);
            // 
            // sifirlaButton
            // 
            this.sifirlaButton.BackColor = System.Drawing.Color.Firebrick;
            this.sifirlaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sifirlaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifirlaButton.ForeColor = System.Drawing.Color.Gold;
            this.sifirlaButton.Location = new System.Drawing.Point(198, 10);
            this.sifirlaButton.Margin = new System.Windows.Forms.Padding(2);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(81, 30);
            this.sifirlaButton.TabIndex = 2;
            this.sifirlaButton.Text = "SIFIRLA";
            this.sifirlaButton.UseVisualStyleBackColor = false;
            this.sifirlaButton.Click += new System.EventHandler(this.sifirlaButton_Click);
            // 
            // zamanLabel
            // 
            this.zamanLabel.AutoSize = true;
            this.zamanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.zamanLabel.Location = new System.Drawing.Point(25, 60);
            this.zamanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zamanLabel.Name = "zamanLabel";
            this.zamanLabel.Size = new System.Drawing.Size(75, 31);
            this.zamanLabel.TabIndex = 3;
            this.zamanLabel.Text = "0:0:0";
            // 
            // Kronometre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(313, 102);
            this.Controls.Add(this.zamanLabel);
            this.Controls.Add(this.sifirlaButton);
            this.Controls.Add(this.durdurButton);
            this.Controls.Add(this.baslaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Kronometre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kronometre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button baslaButton;
        private System.Windows.Forms.Button durdurButton;
        private System.Windows.Forms.Button sifirlaButton;
        private System.Windows.Forms.Label zamanLabel;
    }
}