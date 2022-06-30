namespace SomeGames
{
    partial class KuraÇek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuraÇek));
            this.katilimciRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kisiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sonucRichTextBox = new System.Windows.Forms.RichTextBox();
            this.kuraButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // katilimciRichTextBox
            // 
            this.katilimciRichTextBox.Location = new System.Drawing.Point(9, 28);
            this.katilimciRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.katilimciRichTextBox.Name = "katilimciRichTextBox";
            this.katilimciRichTextBox.Size = new System.Drawing.Size(459, 217);
            this.katilimciRichTextBox.TabIndex = 0;
            this.katilimciRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Her satırda ayrı bir katılımcı olacak şekilde yazın\r\n";
            // 
            // kisiTextBox
            // 
            this.kisiTextBox.Location = new System.Drawing.Point(128, 261);
            this.kisiTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kisiTextBox.Name = "kisiTextBox";
            this.kisiTextBox.Size = new System.Drawing.Size(76, 20);
            this.kisiTextBox.TabIndex = 2;
            this.kisiTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(9, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kazanacak Kişi Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(215, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sonuçlar :";
            // 
            // sonucRichTextBox
            // 
            this.sonucRichTextBox.Location = new System.Drawing.Point(274, 258);
            this.sonucRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sonucRichTextBox.Name = "sonucRichTextBox";
            this.sonucRichTextBox.Size = new System.Drawing.Size(194, 128);
            this.sonucRichTextBox.TabIndex = 5;
            this.sonucRichTextBox.Text = "";
            // 
            // kuraButton
            // 
            this.kuraButton.BackColor = System.Drawing.Color.Firebrick;
            this.kuraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.kuraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuraButton.ForeColor = System.Drawing.Color.Gold;
            this.kuraButton.Location = new System.Drawing.Point(128, 297);
            this.kuraButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kuraButton.Name = "kuraButton";
            this.kuraButton.Size = new System.Drawing.Size(75, 27);
            this.kuraButton.TabIndex = 6;
            this.kuraButton.Text = "Kura Çek";
            this.kuraButton.UseVisualStyleBackColor = false;
            this.kuraButton.Click += new System.EventHandler(this.kuraButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.BackColor = System.Drawing.Color.Firebrick;
            this.temizleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.temizleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizleButton.ForeColor = System.Drawing.Color.Gold;
            this.temizleButton.Location = new System.Drawing.Point(128, 349);
            this.temizleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(75, 27);
            this.temizleButton.TabIndex = 7;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // KuraÇek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(490, 406);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.kuraButton);
            this.Controls.Add(this.sonucRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kisiTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.katilimciRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "KuraÇek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kura Çek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox katilimciRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kisiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox sonucRichTextBox;
        private System.Windows.Forms.Button kuraButton;
        private System.Windows.Forms.Button temizleButton;
    }
}