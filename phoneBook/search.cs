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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox9.Text == "")
            {
                MessageBox.Show("Must Enter an ID");
                return;
            }
            string p;
            string fn = "C:\\Users\\student\\Documents\\phoneBook\\";
            string id = this.textBox9.Text;
            //ID
            this.textBox1.Text = id;
            //First Name
            p = fn + id + "_fn.txt";
            if (System.IO.File.Exists(p) == true)
            {
                this.textBox2.Text = System.IO.File.ReadAllText(p, Encoding.UTF8);
            }
            else
            {
                this.textBox2.Text = "N/A";
            }
            //Last Name
            p = fn + id + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                this.textBox3.Text = System.IO.File.ReadAllText(p, Encoding.UTF8);
            }
            else
            {
                this.textBox3.Text = "N/A";
            }
            //Telephone
            p = fn + id + "_tele.txt";
            if (System.IO.File.Exists(p) == true)
            {
                this.textBox4.Text = System.IO.File.ReadAllText(p, Encoding.UTF8);
            }
            else
            {
                this.textBox4.Text = "N/A";
            }
            //Cellphone
            p = fn + id + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                this.textBox5.Text = System.IO.File.ReadAllText(p, Encoding.UTF8);
            }
            else
            {
                this.textBox5.Text = "N/A";
            }
            //Email
            p = fn + id + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                this.textBox6.Text = System.IO.File.ReadAllText(p, Encoding.UTF8);
            }
            else
            {
                this.textBox6.Text = "N/A";
            }
            //Address
            p = fn + id + "_address.txt";
            if (System.IO.File.Exists(p) == true)
            {
                this.textBox7.Text = System.IO.File.ReadAllText(p, Encoding.UTF8);
            }
            else
            {
                this.textBox7.Text = "N/A";
            }
            //Comment
            p = fn + id + "_comment.txt";
            if (System.IO.File.Exists(p) == true)
            {
                this.textBox8.Text = System.IO.File.ReadAllText(p, Encoding.UTF8);
            }
            else
            {
                this.textBox8.Text = "N/A";
            }
        }
    }
}
