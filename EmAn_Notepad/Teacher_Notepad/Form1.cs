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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "EmAn's Notepad";

            this.newToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
            this.fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            this.fontWithColorToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.G;
            this.regularFontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.colorBoxToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift|Keys.C;
            this.wordwrappeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            this.findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            

            this.wordwrappeToolStripMenuItem.Checked = false;
            this.textBox1.WordWrap = false;

            this.BackColor = Color.FloralWhite;

            this.textBox1.BackColor = Color.FloralWhite;

            this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            this.WindowState = FormWindowState.Maximized;

            this.textBox1.ScrollBars = ScrollBars.Both;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.textBox1.Text = " ";
            }
            else
            {
                saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
                DialogResult dr = this.saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string sd = saveFileDialog1.FileName;
                    sd += ".txt";
                    File.WriteAllText(sd, this.textBox1.Text);
                    this.textBox1.Text = "";
                }
                
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Select();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Develpor: ***MISHAL-E-EMAN***");
        }

        private void fontWithColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }

        }

        private void regularFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = false;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void colorBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.colorDialog1.Color;
            }
        }

        private void wordwrappeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.wordwrappeToolStripMenuItem.Checked = true;
           // this.textBox1.WordWrap = true;
            if (wordwrappeToolStripMenuItem.Checked == true)
            {
                wordwrappeToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;
            }
            else
            {
                wordwrappeToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace_Form rp = new Replace_Form(this);
            rp.Show();
          
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find_Form ff = new Find_Form(this);
            ff.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string od = openFileDialog1.FileName;
                this.textBox1.Text=File.ReadAllText(od);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string sd = saveFileDialog1.FileName;
                sd +=".txt";
                File.WriteAllText(sd, this.textBox1.Text);
            }
        }

        private void Form1_DockChanged(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        }
        
    }
