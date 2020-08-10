using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefen1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void lblMijnLabel_Click(object sender, EventArgs e)
        {

        }

        private void cbLeerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbLeerlingen.SelectedIndex.ToString());
            lblMijnLabel.Text = cbLeerlingen.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLeerlingen.Items.Add("Latha");
            cbLeerlingen.Items.Add("Bhavana");
            cbLeerlingen.Items.Add("Atchaya");
            cbLeerlingen.Items.Add("kumar");
            cbLeerlingen.Items.Add("Saravana");
            foreach(var item in cbLeerlingen.Items)
            {
                lbLeerlingen.Items.Add(item);
            }
        }

        private void lbLeerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLeerlingen_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbLeerlingen.Items.Add(Mijntext.Text);
            buttoevoe .Enabled = false;
            Mijntext.Enabled = false;
        }

        private void Mijntext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
