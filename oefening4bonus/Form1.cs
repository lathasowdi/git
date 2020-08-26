using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening4bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<user> userLijst = new List<user>();
        //public int selectedIndex=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            userLijst.Add(new user("Latha", "sowdi"));
            userLijst.Add(new user("Atchaya", "Saravana"));
            userLijst.Add(new user("Bhavana", "kumar"));
            userLijst.Add(new user("Vishnu", "Preye"));
            VulLijst();
        }
        public void VulLijst()
        {
            cb1.Items.Clear();
            foreach (var item in userLijst)
            {
                cb1.Items.Add(item.Voornaam);
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            user geselecteerdeUser = userLijst[cb1.SelectedIndex];
            tb1.Visible = true;
            tb2.Visible = true;
            tb1.Text = geselecteerdeUser.Voornaam;
            tb2.Text = geselecteerdeUser.Achternaam;
            //selectedIndex = cb1.SelectedIndex;
        }
       
        //private void tb1_Leave(object sender, EventArgs e)
        //{
        //    userLijst[cb1.SelectedIndex].Voornaam = tb1.Text;
        //    //VulLijst();
        //    //cb1.ResetText();
        //}

        //private void tb2_Leave(object sender, EventArgs e)
        //{
        //    userLijst[cb1.SelectedIndex].Achternaam = tb2.Text;
        //    //VulLijst();
        //}
    }
}
