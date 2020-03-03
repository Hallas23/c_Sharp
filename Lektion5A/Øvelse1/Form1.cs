using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Øvelse1
{
    public partial class Form1 : Form
    {
        StatusStrip dynamicStatusStrip = new StatusStrip();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ole";
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            toolStripStatusLabel1.Text = "Removed";

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            toolStripStatusLabel1.Text = "Removed";
        }
    }
}
