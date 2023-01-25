using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinForm_orai
{
    public partial class Statisztika : Form
    {
        public Statisztika()
        {
            InitializeComponent();
        }

        private void Statisztika_Load(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
                FileInfo legutolso = directory.GetFiles("statisztika_*.txt").OrderByDescending(f => f.LastWriteTime).First();
                richTextBox_stat.Text = File.ReadAllText(legutolso.Name);
                richTextBox_stat.Select(0, 0);
            }
            catch (IOException ex)
            {
                richTextBox_stat.Text = "Statisztika fájl nem jeleníthető meg!";
                throw;
            }
        }

        private void Form_Statisztika_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
