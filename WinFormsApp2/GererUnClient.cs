using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class GererUnClient : Form
    {
        CompteC compte = new CompteC();
        string query;
        OleDbConnection dbConnection = new OleDbConnection (@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\hergy\Documents\ompte.accdb");
        public GererUnClient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtnom.Text = Update.SelectedRows[0].Cells[0].Value.ToString();
            txtN.Text = Update.SelectedRows[0].Cells[1].Value.ToString();
            txtP.Text = Update.SelectedRows[0].Cells[2].Value.ToString();
            txtS.SelectedItem = Update.SelectedRows[0].Cells[3].Value.ToString();
            txtA.Text = Update.SelectedRows[0].Cells[4].Value.ToString();
            txtC.Text = Update.SelectedRows[0].Cells[5].Value.ToString();
            txtV.Text = Update.SelectedRows[0].Cells[6].Value.ToString();
            txtT.Text = Update.SelectedRows[0].Cells[7].Value.ToString();
             
            //
            //
        }

        private void GererUnClient_Load(object sender, EventArgs e)
        {

            query = "select * from client";
            var ds = compte.populate(query);
            Update.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Delete from Client where ID = "+ txtnom.Text + ";";
                compte.delete(query);
                query = "select * from client";
                var ds = compte.populate(query);
                Update.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
