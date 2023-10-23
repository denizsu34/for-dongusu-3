using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngusu_3__1681
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            int sayi = Convert.ToInt32(txtSayi.Text);
            for(int i = 0; i < sayi; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
