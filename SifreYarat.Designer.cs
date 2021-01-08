namespace SomeGames
{
    partial class SifreYarat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreYarat));
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.olusturButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.uzunlukTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(27, 57);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.ReadOnly = true;
            this.sifreTextBox.Size = new System.Drawing.Size(238, 20);
            this.sifreTextBox.TabIndex = 9;
            // 
            // olusturButton
            // 
            this.olusturButton.BackColor = System.Drawing.Color.Firebrick;
            this.olusturButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.olusturButton.ForeColor = System.Drawing.Color.Gold;
            this.olusturButton.Location = new System.Drawing.Point(79, 99);
            this.olusturButton.Name = "olusturButton";
            this.olusturButton.Size = new System.Drawing.Size(127, 36);
            this.olusturButton.TabIndex = 6;
            this.olusturButton.Text = "Oluştur";
            this.olusturButton.UseVisualStyleBackColor = false;
            this.olusturButton.Click += new System.EventHandler(this.olusturButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(52, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Büyük Harf";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(52, 193);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Küçük Harf";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(151, 157);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Rakam";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(151, 193);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(105, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Diğer Karakterler";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // uzunlukTextBox
            // 
            this.uzunlukTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uzunlukTextBox.Location = new System.Drawing.Point(172, 15);
            this.uzunlukTextBox.Name = "uzunlukTextBox";
            this.uzunlukTextBox.Size = new System.Drawing.Size(93, 22);
            this.uzunlukTextBox.TabIndex = 0;
            this.uzunlukTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifre Uzunluğu : ";
            // 
            // SifreYarat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(289, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uzunlukTextBox);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.olusturButton);
            this.Controls.Add(this.sifreTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SifreYarat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastgele Şifre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button olusturButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox uzunlukTextBox;
        private System.Windows.Forms.Label label1;
    }
}