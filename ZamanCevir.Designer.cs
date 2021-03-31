
namespace SomeGames
{
    partial class ZamanCevir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZamanCevir));
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.birimLabel = new System.Windows.Forms.Label();
            this.zamanLabel = new System.Windows.Forms.Label();
            this.zamanTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saniyeLabel = new System.Windows.Forms.Label();
            this.dakikaLabel = new System.Windows.Forms.Label();
            this.saatLabel = new System.Windows.Forms.Label();
            this.günLabel = new System.Windows.Forms.Label();
            this.ayLabel = new System.Windows.Forms.Label();
            this.yılLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.BackColor = System.Drawing.Color.Firebrick;
            this.hesaplaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesaplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaButton.ForeColor = System.Drawing.Color.Gold;
            this.hesaplaButton.Location = new System.Drawing.Point(67, 150);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(98, 35);
            this.hesaplaButton.TabIndex = 3;
            this.hesaplaButton.Text = "Hesapla";
            this.hesaplaButton.UseVisualStyleBackColor = false;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.BackColor = System.Drawing.Color.Firebrick;
            this.temizleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.ForeColor = System.Drawing.Color.Gold;
            this.temizleButton.Location = new System.Drawing.Point(251, 150);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(98, 35);
            this.temizleButton.TabIndex = 4;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // birimLabel
            // 
            this.birimLabel.AutoSize = true;
            this.birimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.birimLabel.Location = new System.Drawing.Point(65, 96);
            this.birimLabel.Name = "birimLabel";
            this.birimLabel.Size = new System.Drawing.Size(105, 20);
            this.birimLabel.TabIndex = 14;
            this.birimLabel.Text = "Zaman Birimi:";
            // 
            // zamanLabel
            // 
            this.zamanLabel.AutoSize = true;
            this.zamanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.zamanLabel.Location = new System.Drawing.Point(65, 56);
            this.zamanLabel.Name = "zamanLabel";
            this.zamanLabel.Size = new System.Drawing.Size(63, 20);
            this.zamanLabel.TabIndex = 13;
            this.zamanLabel.Text = "Zaman:";
            // 
            // zamanTextBox
            // 
            this.zamanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanTextBox.Location = new System.Drawing.Point(199, 56);
            this.zamanTextBox.Name = "zamanTextBox";
            this.zamanTextBox.Size = new System.Drawing.Size(98, 26);
            this.zamanTextBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Saniye",
            "Dakika",
            "Saat",
            "Gün",
            "Ay",
            "Yıl"});
            this.comboBox1.Location = new System.Drawing.Point(199, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // saniyeLabel
            // 
            this.saniyeLabel.AutoSize = true;
            this.saniyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniyeLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.saniyeLabel.Location = new System.Drawing.Point(63, 221);
            this.saniyeLabel.Name = "saniyeLabel";
            this.saniyeLabel.Size = new System.Drawing.Size(57, 20);
            this.saniyeLabel.TabIndex = 21;
            this.saniyeLabel.Text = "Saniye";
            // 
            // dakikaLabel
            // 
            this.dakikaLabel.AutoSize = true;
            this.dakikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakikaLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.dakikaLabel.Location = new System.Drawing.Point(63, 256);
            this.dakikaLabel.Name = "dakikaLabel";
            this.dakikaLabel.Size = new System.Drawing.Size(58, 20);
            this.dakikaLabel.TabIndex = 22;
            this.dakikaLabel.Text = "Dakika";
            // 
            // saatLabel
            // 
            this.saatLabel.AutoSize = true;
            this.saatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.saatLabel.Location = new System.Drawing.Point(63, 290);
            this.saatLabel.Name = "saatLabel";
            this.saatLabel.Size = new System.Drawing.Size(43, 20);
            this.saatLabel.TabIndex = 23;
            this.saatLabel.Text = "Saat";
            // 
            // günLabel
            // 
            this.günLabel.AutoSize = true;
            this.günLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.günLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.günLabel.Location = new System.Drawing.Point(309, 221);
            this.günLabel.Name = "günLabel";
            this.günLabel.Size = new System.Drawing.Size(40, 20);
            this.günLabel.TabIndex = 24;
            this.günLabel.Text = "Gün";
            // 
            // ayLabel
            // 
            this.ayLabel.AutoSize = true;
            this.ayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ayLabel.Location = new System.Drawing.Point(309, 256);
            this.ayLabel.Name = "ayLabel";
            this.ayLabel.Size = new System.Drawing.Size(27, 20);
            this.ayLabel.TabIndex = 25;
            this.ayLabel.Text = "Ay";
            // 
            // yılLabel
            // 
            this.yılLabel.AutoSize = true;
            this.yılLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yılLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.yılLabel.Location = new System.Drawing.Point(309, 290);
            this.yılLabel.Name = "yılLabel";
            this.yılLabel.Size = new System.Drawing.Size(26, 20);
            this.yılLabel.TabIndex = 26;
            this.yılLabel.Text = "Yıl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(12, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "1 ay 30 gün, 1 yıl 365 gün üzerinden hesaplanmaktadır.";
            // 
            // ZamanCevir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(475, 374);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yılLabel);
            this.Controls.Add(this.ayLabel);
            this.Controls.Add(this.günLabel);
            this.Controls.Add(this.saatLabel);
            this.Controls.Add(this.dakikaLabel);
            this.Controls.Add(this.saniyeLabel);
            this.Controls.Add(this.hesaplaButton);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.birimLabel);
            this.Controls.Add(this.zamanLabel);
            this.Controls.Add(this.zamanTextBox);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZamanCevir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaman Çevirici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Label birimLabel;
        private System.Windows.Forms.Label zamanLabel;
        private System.Windows.Forms.TextBox zamanTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label saniyeLabel;
        private System.Windows.Forms.Label dakikaLabel;
        private System.Windows.Forms.Label saatLabel;
        private System.Windows.Forms.Label günLabel;
        private System.Windows.Forms.Label ayLabel;
        private System.Windows.Forms.Label yılLabel;
        private System.Windows.Forms.Label label10;
    }
}