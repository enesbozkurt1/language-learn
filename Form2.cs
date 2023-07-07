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

namespace TelaffuzGelistirici
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=dbLogin.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            con.Open();
            string ad = txt_kullaniciadi.Text;
            string parola = txt_sifre.Text;
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login WHERE kullanici='" + ad + "' AND sifre='" + parola + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form4 git = new Form4();
                git.Show();
            }
            else
            {
                label3.Text = " Kullanıcı Adı veya Şifre Hatalı!!!";
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
