using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teacher_Notepad
{
    public partial class Replace_Form : Form
    {
        Form1 f1;
        public Replace_Form(Form1 ff1)
        {
            f1 = ff1;
           // Form1 f1;
           // Replace_Form rp=new Replace_Form();
            //rp.Show(Form1);
            InitializeComponent();
        }

        private void Replace_Form_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Replace:";
            this.label2.Text = "To:";

            this.button1.Text = "REPLACE";
            this.button2.Text = "CLEAR";

            this.BackColor = Color.FloralWhite;

            this.StartPosition = FormStartPosition.Manual;
           // Form1 f1 = new Form1();
           // this.textBox3.Text = f1.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";


        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            f1.textBox1.Text = f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
           MessageBox.Show("Replaced " + this.textBox1.Text + " to " + this.textBox2.Text);
            this.Close();

           // replaceWord = this.textBox2.Text;
           // this.Close();

     
            //this.textBox1.Text = this.textBox1.Text.Replace(this.textBox2.Text, this.textBox3.Text);
        }
     /*   public void replaceForm()
        {
            Replace_Form rp = new Replace_Form();
            rp.ShowDialog();
            String replaceWord = rp.replaceWord;

            if (this.textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Replace(textBox1.Text, replaceWord);
                MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Nothing to replace", "Done", MessageBoxButtons.OK);
        }*/
    }
}
