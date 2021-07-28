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
    public partial class Client : Form
    {
        CompteC compte = new CompteC();
        string donnee;
        public Client()
        {
            InitializeComponent();
        }
        

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
               donnee= "insert into client values("+1+",'" + txtNom.Text + "', '" + txtPrenom.Text + "', '" + txtSexe.SelectedItem.ToString() + "', '" + txtAdress.Text + "' , '" +txtCode.Text + "' ,  '"+txtVille.Text+"' , '"+txtTele.Text+"')";
               compte.insert(donnee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
