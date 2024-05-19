using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.unite_uygulama_5
{
    public partial class fd : Form
    {
        public fd()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2)
 {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTelefon.Text +" \r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 12;//Adet fiyatı 12 lira. 
                    txtBilgi.Text += string.Format("Çorba ", nCorba.Value * 12) ;
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += string.Format("Toplam ",hesap);
            }



        }
    }
       
}
