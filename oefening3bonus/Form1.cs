using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening3bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> naamLijst = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            naamLijst.Add("An");
            naamLijst.Add("Bart");
            naamLijst.Add("Cedric");
            naamLijst.Add("Dieter");
            naamLijst.Add("Evert");
            naamLijst.Add("filip");
            naamLijst.Add("Gert");
            naamLijst.Add("Henk");
            foreach (var item in naamLijst)
            {
                lb1.Items.Add(item);
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            foreach (var item in naamLijst)
            {
                if (item.ToLower().Contains(tb1.Text.ToLower()))
                {
                    lb1.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            foreach (var item in naamLijst)
            {
                if (item.ToLower().Contains(tb1.Text.ToLower()))
                {
                    lb1.Items.Add(item);
                }
            }


        }


    }
}
