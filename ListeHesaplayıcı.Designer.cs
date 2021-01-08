namespace SomeGames
{
    partial class ListeHesaplayıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeHesaplayıcı));
            this.listView1 = new System.Windows.Forms.ListView();
            this.urunButton = new System.Windows.Forms.Button();
            this.urunTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.temizleButton = new System.Windows.Forms.Button();
            this.urunSilButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.adetTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // urunButton
            // 
            this.urunButton.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.urunButton, "urunButton");
            this.urunButton.ForeColor = System.Drawing.Color.Gold;
            this.urunButton.Name = "urunButton";
            this.urunButton.UseVisualStyleBackColor = false;
            this.urunButton.Click += new System.EventHandler(this.urunButton_Click);
            // 
            // urunTextBox
            // 
            resources.ApplyResources(this.urunTextBox, "urunTextBox");
            this.urunTextBox.Name = "urunTextBox";
            this.urunTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bosluk_giremez_KeyPress);
            // 
            // totalTextBox
            // 
            resources.ApplyResources(this.totalTextBox, "totalTextBox");
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Name = "label1";
            // 
            // fiyatTextBox
            // 
            resources.ApplyResources(this.fiyatTextBox, "fiyatTextBox");
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Name = "label3";
            // 
            // temizleButton
            // 
            this.temizleButton.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.temizleButton, "temizleButton");
            this.temizleButton.ForeColor = System.Drawing.Color.Gold;
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // urunSilButton
            // 
            this.urunSilButton.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.urunSilButton, "urunSilButton");
            this.urunSilButton.ForeColor = System.Drawing.Color.Gold;
            this.urunSilButton.Name = "urunSilButton";
            this.urunSilButton.UseVisualStyleBackColor = false;
            this.urunSilButton.Click += new System.EventHandler(this.urunSilButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Name = "label4";
            // 
            // adetTextBox
            // 
            resources.ApplyResources(this.adetTextBox, "adetTextBox");
            this.adetTextBox.Name = "adetTextBox";
            this.adetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // ListeHesaplayıcı
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adetTextBox);
            this.Controls.Add(this.urunSilButton);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.urunTextBox);
            this.Controls.Add(this.urunButton);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ListeHesaplayıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button urunButton;
        private System.Windows.Forms.TextBox urunTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button urunSilButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adetTextBox;
    }
}