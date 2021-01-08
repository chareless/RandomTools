
namespace SomeGames
{
    partial class GeriSayım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeriSayım));
            this.sifirlaButton = new System.Windows.Forms.Button();
            this.durdurButton = new System.Windows.Forms.Button();
            this.baslaButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zamanTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sifirlaButton
            // 
            this.sifirlaButton.BackColor = System.Drawing.Color.Firebrick;
            this.sifirlaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sifirlaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifirlaButton.ForeColor = System.Drawing.Color.Gold;
            this.sifirlaButton.Location = new System.Drawing.Point(199, 62);
            this.sifirlaButton.Margin = new System.Windows.Forms.Padding(2);
            this.sifirlaButton.Name = "sifirlaButton";
            this.sifirlaButton.Size = new System.Drawing.Size(81, 30);
            this.sifirlaButton.TabIndex = 6;
            this.sifirlaButton.Text = "SIFIRLA";
            this.sifirlaButton.UseVisualStyleBackColor = false;
            this.sifirlaButton.Click += new System.EventHandler(this.sifirlaButton_Click);
            // 
            // durdurButton
            // 
            this.durdurButton.BackColor = System.Drawing.Color.Firebrick;
            this.durdurButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.durdurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durdurButton.ForeColor = System.Drawing.Color.Gold;
            this.durdurButton.Location = new System.Drawing.Point(113, 62);
            this.durdurButton.Margin = new System.Windows.Forms.Padding(2);
            this.durdurButton.Name = "durdurButton";
            this.durdurButton.Size = new System.Drawing.Size(81, 30);
            this.durdurButton.TabIndex = 5;
            this.durdurButton.Text = "DURDUR";
            this.durdurButton.UseVisualStyleBackColor = false;
            this.durdurButton.Click += new System.EventHandler(this.durdurButton_Click);
            // 
            // baslaButton
            // 
            this.baslaButton.BackColor = System.Drawing.Color.Firebrick;
            this.baslaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.baslaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslaButton.ForeColor = System.Drawing.Color.Gold;
            this.baslaButton.Location = new System.Drawing.Point(28, 62);
            this.baslaButton.Margin = new System.Windows.Forms.Padding(2);
            this.baslaButton.Name = "baslaButton";
            this.baslaButton.Size = new System.Drawing.Size(81, 30);
            this.baslaButton.TabIndex = 4;
            this.baslaButton.Text = "BAŞLA";
            this.baslaButton.UseVisualStyleBackColor = false;
            this.baslaButton.Click += new System.EventHandler(this.baslaButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zamanTextBox
            // 
            this.zamanTextBox.BackColor = System.Drawing.Color.DimGray;
            this.zamanTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zamanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanTextBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.zamanTextBox.Location = new System.Drawing.Point(28, 12);
            this.zamanTextBox.Name = "zamanTextBox";
            this.zamanTextBox.Size = new System.Drawing.Size(100, 31);
            this.zamanTextBox.TabIndex = 8;
            this.zamanTextBox.Text = "0:0:0";
            // 
            // GeriSayım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(309, 111);
            this.Controls.Add(this.zamanTextBox);
            this.Controls.Add(this.sifirlaButton);
            this.Controls.Add(this.durdurButton);
            this.Controls.Add(this.baslaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeriSayım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geri Sayım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sifirlaButton;
        private System.Windows.Forms.Button durdurButton;
        private System.Windows.Forms.Button baslaButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox zamanTextBox;
    }
}