using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    class CompteC
    {
        protected OleDbConnection getcon()
        {
            OleDbConnection dbConnection = new OleDbConnection();
            dbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hergy\Desktop\project.accdb";
            return dbConnection;

        }
        public void insert(string donnee)
        {
            OleDbConnection Con = getcon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = donnee;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("ADDED SUCCESS");
            Con.Close();
        }
        // DISPLAY DATA
        public DataSet populate(string query)
        {
            OleDbConnection Con = getcon();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            OleDbDataAdapter data = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;

        }

        // DELETE ACCOUNT 
        public void delete(string query)
        {
            OleDbConnection Con = getcon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("DELETE SUCCESSEFULL");
            Con.Close();
        }

        public void Update(string query)
        {
            OleDbConnection Con = getcon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Con.Open();
            Cmd.CommandText = query;
            Cmd.ExecuteNonQuery();
            MessageBox.Show("UPDADe SUCCEFULlY");
        }
    }
}

