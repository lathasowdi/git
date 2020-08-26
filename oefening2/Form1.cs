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
            //MessageBox.Show(cboefening2.SelectedItem.ToString());
            //cboefening2 .Items.RemoveAt(cboefening2.SelectedIndex);
            if (cboefening2.Items.Count <= 0)
            {
                MessageBox.Show("geen items meer om te deleten.");
            }
            else if (cboefening2.SelectedIndex < 0)
            {
                MessageBox.Show("Error geen item geselecteerd. Selecteer een item A.U.B.");
            }
            //if (cb1.SelectedIndex >= 0)
            else
            {
                MessageBox.Show($"{cboefening2.SelectedItem.ToString()} is verwijderd");
                cboefening2.Items.RemoveAt(cboefening2.SelectedIndex);
            }
            
            
        }
    }
}
