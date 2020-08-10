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
            listoefening1.Items.Add(Mijntext.Text);
            Mijntext.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
