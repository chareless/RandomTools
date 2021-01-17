
namespace SomeGames
{
    partial class Aritmetik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aritmetik));
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.sonucTextBox = new System.Windows.Forms.TextBox();
            this.islemTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.BackColor = System.Drawing.Color.Firebrick;
            this.hesaplaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesaplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.hesaplaButton.ForeColor = System.Drawing.Color.Gold;
            this.hesaplaButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hesaplaButton.Location = new System.Drawing.Point(35, 77);
            this.hesaplaButton.Margin = new System.Windows.Forms.Padding(2);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(172, 46);
            this.hesaplaButton.TabIndex = 1;
            this.hesaplaButton.Text = "HESAPLA";
            this.hesaplaButton.UseVisualStyleBackColor = false;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // sonucTextBox
            // 
            this.sonucTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucTextBox.Location = new System.Drawing.Point(35, 139);
            this.sonucTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sonucTextBox.Name = "sonucTextBox";
            this.sonucTextBox.ReadOnly = true;
            this.sonucTextBox.Size = new System.Drawing.Size(172, 22);
            this.sonucTextBox.TabIndex = 2;
            // 
            // islemTextBox
            // 
            this.islemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemTextBox.Location = new System.Drawing.Point(35, 34);
            this.islemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.islemTextBox.Name = "islemTextBox";
            this.islemTextBox.Size = new System.Drawing.Size(172, 22);
            this.islemTextBox.TabIndex = 0;
            this.islemTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.islemTextBox_KeyPress);
            // 
            // Aritmetik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(240, 208);
            this.Controls.Add(this.hesaplaButton);
            this.Controls.Add(this.sonucTextBox);
            this.Controls.Add(this.islemTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Aritmetik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aritmetik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplaButton;
        private System.Windows.Forms.TextBox sonucTextBox;
        private System.Windows.Forms.TextBox islemTextBox;
    }
}