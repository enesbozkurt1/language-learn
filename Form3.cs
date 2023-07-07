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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=dbLogin.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ad = txt_kullaniciadi.Text;
            string parola = txt_sifre.Text;
            cmd = new OleDbCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM Login WHERE kullanici='" + ad + "' AND sifre='" + parola + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu kullanıcı adı kullanılıyor başka kullanıcı adı seçiniz.");
            }
            else
            {
                dr.Close();
                cmd.CommandText = "insert into Login (kullanici,sifre) values(@ad, @sifre)";
                cmd.Parameters.AddWithValue("@ad",ad);
                cmd.Parameters.AddWithValue("@sifre", parola);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
            }
            baglanti.Close();
        }
    }
}
