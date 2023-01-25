namespace WinForm_orai
{
    partial class Statisztika
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
            this.richTextBox_stat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_stat
            // 
            this.richTextBox_stat.Location = new System.Drawing.Point(137, 54);
            this.richTextBox_stat.Name = "richTextBox_stat";
            this.richTextBox_stat.Size = new System.Drawing.Size(486, 260);
            this.richTextBox_stat.TabIndex = 0;
            this.richTextBox_stat.Text = "";
            // 
            // Statisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_stat);
            this.Name = "Statisztika";
            this.Text = "Statisztika";
            this.Load += new System.EventHandler(this.Statisztika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_stat;
    }
}