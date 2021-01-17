
namespace SomeGames
{
    partial class Korona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Korona));
            this.sonVakaLabel = new System.Windows.Forms.Label();
            this.vakaLabel = new System.Windows.Forms.Label();
            this.olumTextLabel = new System.Windows.Forms.Label();
            this.olumLabel = new System.Windows.Forms.Label();
            this.sonOlumLabel = new System.Windows.Forms.Label();
            this.turkeyLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sonVakaLabel
            // 
            this.sonVakaLabel.AutoSize = true;
            this.sonVakaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonVakaLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.sonVakaLabel.Location = new System.Drawing.Point(43, 189);
            this.sonVakaLabel.Name = "sonVakaLabel";
            this.sonVakaLabel.Size = new System.Drawing.Size(91, 24);
            this.sonVakaLabel.TabIndex = 1;
            this.sonVakaLabel.Text = "Son Vaka";
            // 
            // vakaLabel
            // 
            this.vakaLabel.AutoSize = true;
            this.vakaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vakaLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.vakaLabel.Location = new System.Drawing.Point(43, 130);
            this.vakaLabel.Name = "vakaLabel";
            this.vakaLabel.Size = new System.Drawing.Size(121, 24);
            this.vakaLabel.TabIndex = 2;
            this.vakaLabel.Text = "Toplam Vaka";
            // 
            // olumTextLabel
            // 
            this.olumTextLabel.AutoSize = true;
            this.olumTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olumTextLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.olumTextLabel.Location = new System.Drawing.Point(359, 130);
            this.olumTextLabel.Name = "olumTextLabel";
            this.olumTextLabel.Size = new System.Drawing.Size(71, 24);
            this.olumTextLabel.TabIndex = 4;
            this.olumTextLabel.Text = "Ölüm : ";
            // 
            // olumLabel
            // 
            this.olumLabel.AutoSize = true;
            this.olumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olumLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.olumLabel.Location = new System.Drawing.Point(421, 130);
            this.olumLabel.Name = "olumLabel";
            this.olumLabel.Size = new System.Drawing.Size(125, 24);
            this.olumLabel.TabIndex = 5;
            this.olumLabel.Text = "Toplam Ölüm";
            // 
            // sonOlumLabel
            // 
            this.sonOlumLabel.AutoSize = true;
            this.sonOlumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonOlumLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.sonOlumLabel.Location = new System.Drawing.Point(359, 189);
            this.sonOlumLabel.Name = "sonOlumLabel";
            this.sonOlumLabel.Size = new System.Drawing.Size(95, 24);
            this.sonOlumLabel.TabIndex = 6;
            this.sonOlumLabel.Text = "Son Ölüm";
            // 
            // turkeyLabel
            // 
            this.turkeyLabel.AutoSize = true;
            this.turkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turkeyLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.turkeyLabel.Location = new System.Drawing.Point(251, 45);
            this.turkeyLabel.Name = "turkeyLabel";
            this.turkeyLabel.Size = new System.Drawing.Size(104, 31);
            this.turkeyLabel.TabIndex = 7;
            this.turkeyLabel.Text = "Türkiye";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(12, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Veriler \"https://news.google.com\" sitesinden alınmıştır.";
            // 
            // Korona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(616, 372);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.turkeyLabel);
            this.Controls.Add(this.sonOlumLabel);
            this.Controls.Add(this.olumLabel);
            this.Controls.Add(this.olumTextLabel);
            this.Controls.Add(this.vakaLabel);
            this.Controls.Add(this.sonVakaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Korona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sonVakaLabel;
        private System.Windows.Forms.Label vakaLabel;
        private System.Windows.Forms.Label olumTextLabel;
        private System.Windows.Forms.Label olumLabel;
        private System.Windows.Forms.Label sonOlumLabel;
        private System.Windows.Forms.Label turkeyLabel;
        private System.Windows.Forms.Label label10;
    }
}