using System;
using System.Drawing;
using System.Windows.Forms;
namespace Example_43
{
    public partial class MainForm : Form
    {
        Color originlColor;
        Size originalSize;
        int incrementPercent = 5;
        public MainForm()
        {
            InitializeComponent();
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
        private void originalColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = originlColor;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            originlColor = this.BackColor;
            originalSize = this.Size;
        }
        private void originalSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = originalSize;
        }
        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void biggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size currentSize = this.Size;
            int newWidth = (int)(currentSize.Width * (1 + incrementPercent / 100.0));
            int newHeight = (int)(currentSize.Height * (1 + incrementPercent / 100.0));
            if (newWidth >= 2 * originalSize.Width || (newHeight >= 2 * originalSize.Height))
                return;
            this.Size = new Size(newWidth, newHeight);
        }
        private void smallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size currentSize = this.Size;
            int newWidth = (int)(currentSize.Width * (1 - incrementPercent / 100.0));
            int newHeight = (int)(currentSize.Height * (1 - incrementPercent / 100.0));
            if (newWidth <= 0.5 * originalSize.Width || (newHeight <= 0.5 * originalSize.Height))
                return;
            this.Size = new Size(newWidth, newHeight);
        }
        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}