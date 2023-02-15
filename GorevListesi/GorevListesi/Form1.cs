using GorevListesi.controller;
using GorevListesi.enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorevListesi
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            controller = new Controller();
            LoginStatus result = controller.authentication(txt_kulad.Text, txt_sifre.Text);
            
            if(result!=null && result==LoginStatus.basarili)
            {
                GorevTablosu gorevtablosu = new GorevTablosu();
                gorevtablosu.Show();
                this.Hide();
            }
            else if(result!=null && result==LoginStatus.basarisiz)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Eksik parametre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
