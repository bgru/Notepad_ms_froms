using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Konfiguracja : Form
    {
        public Color EditorBackColor {
            get { return labelTestText.BackColor; } 
            set { labelTestText.BackColor = value; }
        }
        public Color EditorForeColor { 
            get { return labelTestText.ForeColor; }
            set { labelTestText.ForeColor = value; }
        }
        public Font EditorFont {
            get { return labelTestText.Font; }
            set { labelTestText.Font = value;  }
        }

        public Konfiguracja()
        {
            InitializeComponent();
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog sc = new ColorDialog();
            if(sc.ShowDialog() == DialogResult.OK)
            {
                EditorBackColor = sc.Color;
                labelTestText.BackColor = sc.Color;
            }
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog sc = new ColorDialog();
            if (sc.ShowDialog() == DialogResult.OK)
            {
                EditorForeColor = sc.Color;
                labelTestText.ForeColor = sc.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog sc = new FontDialog();
            if(sc.ShowDialog() == DialogResult.OK)
            {
                EditorFont = sc.Font;
                labelTestText.Font = sc.Font;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Konfiguracja_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
