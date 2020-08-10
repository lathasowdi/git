using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboefening2 .Items.Add("Latha");
            cboefening2 .Items.Add("Bhavana");
            cboefening2 .Items.Add("Atchaya");
            cboefening2 .Items.Add("kumar");
            cboefening2 .Items.Add("Saravana");
        }

        private void cboefening2_SelectedIndexChanged(object sender, EventArgs e)
        {
                MessageBox.Show(cboefening2 .SelectedIndex.ToString());
            laboefening1 .Text = cboefening2.SelectedItem.ToString();
        }

        private void butoefening2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboefening2.SelectedItem.ToString());
            cboefening2 .Items.RemoveAt(cboefening2.SelectedIndex);
        }
    }
}
