
namespace SomeGames
{
    partial class Kilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kilo));
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.erkekRadioButton = new System.Windows.Forms.RadioButton();
            this.kadinRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kiloTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.idealLabel = new System.Windows.Forms.Label();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.hataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.BackColor = System.Drawing.Color.Firebrick;
            this.hesaplaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesaplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaButton.ForeColor = System.Drawing.Color.Gold;
            this.hesaplaButton.Location = new System.Drawing.Point(308, 125);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(111, 32);
            this.hesaplaButton.TabIndex = 0;
            this.hesaplaButton.Text = "HESAPLA";
            this.hesaplaButton.UseVisualStyleBackColor = false;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cinsiyet :";
            // 
            // boyTextBox
            // 
            this.boyTextBox.BackColor = System.Drawing.Color.DimGray;
            this.boyTextBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.boyTextBox.Location = new System.Drawing.Point(285, 32);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(50, 20);
            this.boyTextBox.TabIndex = 2;
            this.boyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // erkekRadioButton
            // 
            this.erkekRadioButton.AutoSize = true;
            this.erkekRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkekRadioButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.erkekRadioButton.Location = new System.Drawing.Point(114, 32);
            this.erkekRadioButton.Name = "erkekRadioButton";
            this.erkekRadioButton.Size = new System.Drawing.Size(68, 24);
            this.erkekRadioButton.TabIndex = 3;
            this.erkekRadioButton.TabStop = true;
            this.erkekRadioButton.Text = "Erkek";
            this.erkekRadioButton.UseVisualStyleBackColor = true;
            // 
            // kadinRadioButton
            // 
            this.kadinRadioButton.AutoSize = true;
            this.kadinRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadinRadioButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.kadinRadioButton.Location = new System.Drawing.Point(114, 66);
            this.kadinRadioButton.Name = "kadinRadioButton";
            this.kadinRadioButton.Size = new System.Drawing.Size(67, 24);
            this.kadinRadioButton.TabIndex = 5;
            this.kadinRadioButton.TabStop = true;
            this.kadinRadioButton.Text = "Kadın";
            this.kadinRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(235, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Boy :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(235, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kilo :";
            // 
            // kiloTextBox
            // 
            this.kiloTextBox.BackColor = System.Drawing.Color.DimGray;
            this.kiloTextBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.kiloTextBox.Location = new System.Drawing.Point(285, 70);
            this.kiloTextBox.Name = "kiloTextBox";
            this.kiloTextBox.Size = new System.Drawing.Size(50, 20);
            this.kiloTextBox.TabIndex = 7;
            this.kiloTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(341, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "cm (Örn. 180)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Location = new System.Drawing.Point(341, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "kg (Örn. 64,6)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(27, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vücut Kitle İndeksi (BMI) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(27, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "İdeal Kilo :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(27, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sonuç :";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bmiLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.bmiLabel.Location = new System.Drawing.Point(224, 200);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(0, 20);
            this.bmiLabel.TabIndex = 14;
            // 
            // idealLabel
            // 
            this.idealLabel.AutoSize = true;
            this.idealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idealLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.idealLabel.Location = new System.Drawing.Point(114, 232);
            this.idealLabel.Name = "idealLabel";
            this.idealLabel.Size = new System.Drawing.Size(0, 20);
            this.idealLabel.TabIndex = 15;
            // 
            // sonucLabel
            // 
            this.sonucLabel.AutoSize = true;
            this.sonucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sonucLabel.Location = new System.Drawing.Point(96, 262);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Size = new System.Drawing.Size(0, 20);
            this.sonucLabel.TabIndex = 16;
            // 
            // hataLabel
            // 
            this.hataLabel.AutoSize = true;
            this.hataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hataLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hataLabel.Location = new System.Drawing.Point(27, 130);
            this.hataLabel.Name = "hataLabel";
            this.hataLabel.Size = new System.Drawing.Size(0, 20);
            this.hataLabel.TabIndex = 17;
            // 
            // Kilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(475, 304);
            this.Controls.Add(this.hataLabel);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.idealLabel);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kiloTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kadinRadioButton);
            this.Controls.Add(this.erkekRadioButton);
            this.Controls.Add(this.boyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İdeal Kilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boyTextBox;
        private System.Windows.Forms.RadioButton erkekRadioButton;
        private System.Windows.Forms.RadioButton kadinRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kiloTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Label idealLabel;
        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.Label hataLabel;
    }
}