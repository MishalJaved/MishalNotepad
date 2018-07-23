using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Teacher_Notepad
{
    public partial class Find_Form : Form
    {
        Form1 f1;
        public Find_Form(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();       
        }
     

        private void Find_Form_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Find";
            this.button1.Text = "OK";

            this.BackColor = Color.FloralWhite;

            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

       private void button1_Click(object sender, EventArgs e)
       {  
          /* Form1 f1 = new Form1();
            if (f1.textBox1.Text.Contains(this.textBox1.Text))
            {
                MessageBox.Show("Find" + this.textBox1.Text);
            }
            else
            {
                MessageBox.Show("Not Found");
            }*/
            {
               // Form1 f1 = new Form1();
                if (f1.textBox1.Text.Contains(this.textBox1.Text))
                {
                    MessageBox.Show("Find Successful ");
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
          
           
        }


       }
    }

    

    