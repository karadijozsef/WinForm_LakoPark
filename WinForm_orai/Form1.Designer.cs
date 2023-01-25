namespace WinForm_orai
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_stat = new System.Windows.Forms.Button();
            this.Mentes = new System.Windows.Forms.Button();
            this.button_bal = new System.Windows.Forms.Button();
            this.button_jobb = new System.Windows.Forms.Button();
            this.panel_utcak = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_stat
            // 
            this.button_stat.Location = new System.Drawing.Point(53, 247);
            this.button_stat.Name = "button_stat";
            this.button_stat.Size = new System.Drawing.Size(111, 42);
            this.button_stat.TabIndex = 1;
            this.button_stat.Text = "Statisztika";
            this.button_stat.UseVisualStyleBackColor = true;
            this.button_stat.Click += new System.EventHandler(this.button_stat_Click);
            // 
            // Mentes
            // 
            this.Mentes.Location = new System.Drawing.Point(53, 328);
            this.Mentes.Name = "Mentes";
            this.Mentes.Size = new System.Drawing.Size(111, 42);
            this.Mentes.TabIndex = 2;
            this.Mentes.Text = "Mentés";
            this.Mentes.UseVisualStyleBackColor = true;
            // 
            // button_bal
            // 
            this.button_bal.Location = new System.Drawing.Point(373, 346);
            this.button_bal.Name = "button_bal";
            this.button_bal.Size = new System.Drawing.Size(103, 41);
            this.button_bal.TabIndex = 3;
            this.button_bal.Text = "button1";
            this.button_bal.UseVisualStyleBackColor = true;
            // 
            // button_jobb
            // 
            this.button_jobb.Location = new System.Drawing.Point(531, 346);
            this.button_jobb.Name = "button_jobb";
            this.button_jobb.Size = new System.Drawing.Size(103, 41);
            this.button_jobb.TabIndex = 4;
            this.button_jobb.Text = "button3";
            this.button_jobb.UseVisualStyleBackColor = true;
            // 
            // panel_utcak
            // 
            this.panel_utcak.Location = new System.Drawing.Point(260, 44);
            this.panel_utcak.Name = "panel_utcak";
            this.panel_utcak.Size = new System.Drawing.Size(474, 245);
            this.panel_utcak.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_utcak);
            this.Controls.Add(this.button_jobb);
            this.Controls.Add(this.button_bal);
            this.Controls.Add(this.Mentes);
            this.Controls.Add(this.button_stat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_stat;
        private System.Windows.Forms.Button Mentes;
        private System.Windows.Forms.Button button_bal;
        private System.Windows.Forms.Button button_jobb;
        private System.Windows.Forms.Panel panel_utcak;
    }
}

