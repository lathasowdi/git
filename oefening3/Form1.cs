using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> Namen = new List<string>();
        public  void Form1_Load(object sender, EventArgs e)
        {
          
            Namen.Add("Latha");
           Namen.Add("Bhavana");
            Namen.Add("Atchaya");
            Namen.Add("kumar");
            Namen.Add("Saravana");
            foreach (var item in Namen )
            {
                lisoefening3.Items.Add(item);
            }
        }

        private void butoefening3_Click(object sender, EventArgs e)
        {
            foreach (var item in Namen)
            {
                    if (!Regex.IsMatch(item, @texoefening3.Text))
                        lisoefening3.Items.Remove(item);
            }
        }
    }
}
