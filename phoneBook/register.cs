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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = true;
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            this.textBox8.ResetText();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter an ID");
                return;
            }
            this.toolStripButton1.Enabled = true;
            MessageBox.Show("Changes Saved");
            this.toolStripButton2.Enabled = false;
            string p;
            string fn = "C:\\Users\\student\\Documents\\phoneBook\\";
            // First Name
            p = fn + this.textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.textBox2.Text, Encoding.UTF8);
            //Last Name
            p = fn + this.textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.textBox3.Text, Encoding.UTF8);
            //Telephone
            p = fn + this.textBox1.Text + "_tele.txt";
            System.IO.File.WriteAllText(p, this.textBox4.Text, Encoding.UTF8);
            //Cellphone
            p = fn + this.textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.textBox5.Text, Encoding.UTF8);
            //Email
            p = fn + this.textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.textBox6.Text, Encoding.UTF8);
            //Address
            p = fn + this.textBox1.Text + "_address.txt";
            System.IO.File.WriteAllText(p, this.textBox7.Text, Encoding.UTF8);
            //Comment
            p = fn + this.textBox1.Text + "_comment.txt";
            System.IO.File.WriteAllText(p, this.textBox8.Text, Encoding.UTF8);



        }
    }
}
