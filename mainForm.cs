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

namespace Notatnik
{
    public partial class mainForm : Form
    {
        private const string MyFilter = "Plik Tekstowy|*.txt|Skrypty|*.bat|Wszystkie Pliki|*.*";

        private string myFileName = "";

        public string MyFileName
        {
            get { return myFileName; }
            set
            {
                myFileName = value;
                SetFilename();
            }
        }

        private bool textEdited = false;
        public bool TextEdited
        {
            get { return textEdited; }
            set
            {
                textEdited = value;
                SetFilename();
            }
        }

        private void SetFilename()
        {
            if(MyFileName == "")
            {
                this.Text = "Nowy Plik";
            }
            else
            {
                this.Text = Path.GetFileName(MyFileName);
            }

            if(textEdited == true)
            {
                this.Text += " *";
            }
        }

        public mainForm()
        {
            InitializeComponent();
            SetFilename();
        }

        private void richTextBoxField_TextChanged(object sender, EventArgs e)
        {
            TextEdited = true;
        }

        private void konfiuracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konfiguracja sc = new Konfiguracja();
            sc.EditorBackColor = richTextBoxField.BackColor;
            sc.EditorFont = richTextBoxField.Font;
            sc.ForeColor = richTextBoxField.ForeColor;
            if (sc.ShowDialog() == DialogResult.OK)
            {
                richTextBoxField.BackColor = sc.EditorBackColor;
                richTextBoxField.ForeColor = sc.EditorForeColor;
                richTextBoxField.Font = sc.EditorFont;
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TextEdited == true)
            {
                DialogResult result = MessageBox.Show("Save changes?", "File Changed!", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    zapiszJakoToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if(result == DialogResult.No)
                {
                richTextBoxField.Text = "";
                MyFileName = "";
                TextEdited = false;
                }
            }

        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MyFileName == "")
            {
                zapiszJakoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(MyFileName, richTextBoxField.Text);
                TextEdited = false;
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sc = new SaveFileDialog();
            sc.Filter = MyFilter;
            if (sc.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sc.FileName, richTextBoxField.Text);
                MyFileName = sc.FileName;
                TextEdited = false;
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextEdited == true)
            {
                DialogResult result = MessageBox.Show("Save changes?", "File Changed!", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    zapiszJakoToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }


        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextEdited == true)
            {
                DialogResult result = MessageBox.Show("Save changes?", "File Changed!", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    zapiszJakoToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }

            OpenFileDialog sc = new OpenFileDialog();
            sc.Filter = MyFilter;
            if (sc.ShowDialog() == DialogResult.OK)
            {
                MyFileName = sc.FileName;
                TextEdited = false;
                File.ReadAllText(sc.FileName);
            }

        }
    }
}
