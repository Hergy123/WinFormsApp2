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
    public partial class Compte : Form
    {
        DB dB = new DB();
        string query;
        public Compte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into compte values("+1+",'" + txtNum.Text + "', '" + txtClient.Text + "', '" + txtLabel.Text + "' , '" + txtDate.Text + "' , '" + txtSolde.Text + "', '" + comtyCom.SelectedItem.ToString() + "')";
                dB.insert(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
