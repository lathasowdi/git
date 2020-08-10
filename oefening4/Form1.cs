using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<User> gebruikers = new BindingList<User>();
            cboefening4 .DisplayMember = "Voornaam";
            cboefening4 .ValueMember = "Achternaam";
            gebruikers.Add(new User("Ken", "Field"));
            gebruikers.Add(new User("Jan", "Janssens"));
            gebruikers.Add(new User("Geert", "Hoste"));
                cboefening4.DataSource = gebruikers;
        }
        private void butoefening4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboefening4.SelectedValue.ToString());
        }
    }
        public class User
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public User(string vn, string an)
        {
            Voornaam = vn;
            Achternaam = an;
        }
    }










}


