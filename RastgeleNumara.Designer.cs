namespace SomeGames
{
    partial class RastgeleNumara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RastgeleNumara));
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uretButton = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(71, 62);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.xTextBox.MaxLength = 10;
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(62, 20);
            this.xTextBox.TabIndex = 0;
            this.xTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Değer aralığını girin [x,y)";
            // 
            // uretButton
            // 
            this.uretButton.BackColor = System.Drawing.Color.Firebrick;
            this.uretButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.uretButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uretButton.ForeColor = System.Drawing.Color.Gold;
            this.uretButton.Location = new System.Drawing.Point(71, 132);
            this.uretButton.Margin = new System.Windows.Forms.Padding(2);
            this.uretButton.Name = "uretButton";
            this.uretButton.Size = new System.Drawing.Size(131, 35);
            this.uretButton.TabIndex = 2;
            this.uretButton.Text = "Rastgele Üret";
            this.uretButton.UseVisualStyleBackColor = false;
            this.uretButton.Click += new System.EventHandler(this.uretButton_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(141, 62);
            this.yTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(62, 20);
            this.yTextBox.TabIndex = 1;
            this.yTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // RastgeleNumara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(268, 209);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.uretButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xTextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RastgeleNumara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastgele Numara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uretButton;
        private System.Windows.Forms.TextBox yTextBox;
    }
}