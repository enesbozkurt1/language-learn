using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaffuzGelistirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnanasayfa.Height;
            panelLeft.Top = btnanasayfa.Top;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnkayit.Height;
            panelLeft.Top = btnkayit.Top;
            Form3 git = new Form3();
            git.Show();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            panelLeft.Top = btngiris.Top;
            panelLeft.Height = btngiris.Height;
            Form2 git = new Form2();
            git.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com/enesbozkurth/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/5511200293");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
