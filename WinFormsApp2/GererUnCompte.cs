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
    public partial class GererUnCompte : Form
    {
        
        public GererUnCompte()
        {
            InitializeComponent();
        }
        DB db = new DB();
        string mquery;

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                mquery = "update compte set numero= '" + txtNumero.Text + "', client = '" + txtCl.Text + "' , libelle= '" + txtL.Text + "', Date='" + txtD.Text + "' solde='" + txtS.Text + "', type de compte='" + txtCo.Text + "' where ID=" + txtNameId + ";";
                db.Updatedata(mquery);
                mquery = "select * from compte ";
                var ds = db.populate(mquery);
                Update.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
           
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GererUnCompte_Load(object sender, EventArgs e)
        {
            mquery = "select * from Compte ";
            var ds = db.populate(mquery);
            Update.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Update_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                 mquery = "Delete from compte where ID = "+txtNameId.Text+";";
                db.delete(mquery);
                mquery = "select * from compte";
                var ds = db.populate(mquery);
                Update.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear() {
            txtNameId.Text = "";

            txtNumero.Text = "";
            txtD.Text = "";
            txtCl.Text = "";
            txtCo.SelectedIndex = -1;
            txtS.Text = "";
            txtL.Text = "";

        }

        private void txtNameId_TextChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        { 

        }

        private void Update_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
            //dataGridView.Columns[0].Name = "ID";

           txtNameId.Text = Update.SelectedRows[0].Cells[0].Value.ToString();
            txtNumero.Text = Update.SelectedRows[0].Cells[1].Value.ToString();
            txtCl.Text     = Update.SelectedRows[0].Cells[2].Value.ToString();
            txtL.Text      = Update.SelectedRows[0].Cells[3].Value.ToString();
            txtD.Text      = Update.SelectedRows[0].Cells[4].Value.ToString();
            txtS.Text      = Update.SelectedRows[0].Cells[5].Value.ToString();
            txtCo.Text     = Update.SelectedRows[0].Cells[6].Value.ToString();
            

            

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Compte c = new Compte();
            c.Show();
        }
    }
}
