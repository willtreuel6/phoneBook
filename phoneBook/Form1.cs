using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.MdiParent = this;
            a.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton3_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton4_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton5_Click(sender, e);
            }
        }
    }
}
