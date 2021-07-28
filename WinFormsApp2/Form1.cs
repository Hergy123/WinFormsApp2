using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            GererUnClient unClient = new GererUnClient();
            unClient.Show();

        }

       



        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void client(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            GererUnCompte gererUn = new GererUnCompte();
            gererUn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compte compte = new Compte();
            compte.Show();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GererUnCompte gererUn = new GererUnCompte();
            gererUn.Show();
        }
    }
}
