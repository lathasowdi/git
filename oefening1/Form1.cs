using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but1oefening1_Click(object sender, EventArgs e)
        {
            if (Mijntext.Text != "")
            {
                listoefening1.Items.Add(Mijntext.Text);
                Mijntext.Focus();
            }

            if (listoefening1.Items.Count>=5)
            {
                but1oefening1.Enabled = false;
                Mijntext.Enabled = false;
                Mijntext.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mijntext.Focus();
        }

        private void Mijntext_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                but1oefening1_Click(sender, e);
            }
        }
    }
}
