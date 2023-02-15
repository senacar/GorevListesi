using GorevListesi.controller;
using GorevListesi.enumeration;
using GorevListesi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorevListesi
{
    public partial class GuncellemePaneli : Form
    {
        Controller controller = new Controller();
        GorevTablosu gt = new GorevTablosu();
        public object dataGridView1;


        public string _deneme;
        public GuncellemePaneli(string deneme)
        {
            _deneme = deneme;
            InitializeComponent();
        }

       
        private void btn_gorevgunc_Click(object sender, EventArgs e)
        {

            Gorev gorev = new Gorev();
            GorevTablosu gt = (GorevTablosu)Application.OpenForms["GorevTablosu"];
            gorev.gorevID = gt.ID;
            gorev.Gorevsahibi = txt_isim.Text;
            gorev.gorev = richtxt_gorev.Text;
            gorev.musteri = txt_musteri.Text;
            gorev.PlanlananBitis = dt_planlanan.Value;
            gorev.GercekBitis = dt_gercekbitis.Value;
            LoginStatus sonuc = controller.gorevGuncelle(gorev);


            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Görev güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(sonuc==LoginStatus.basarisiz)
            {
                MessageBox.Show("Görev güncellenirken bir hata oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Eksik parametre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            gt.updateDGV();
            DataGridView dgv = gt.dataGridView1;
            dgv.FirstDisplayedScrollingRowIndex = gt.SelectedRowIndex;
            this.Hide();


        }


        private void txt_gorevid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void GuncellemePaneli_Load(object sender, EventArgs e)
        {
            panel_liste.Visible = false;
            if (_deneme == "ekle")
            {
                btn_grvkapat.Enabled = false;
                btn_kaydet.Text = "Ekle";
            }

            else if (_deneme == "guncelle")
            {
                btn_kaydet.Text = "Güncelle";
            }

        }

       
       


        private void dt_gercekbitis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if(_deneme=="ekle")
            {
                Gorev gorev = new Gorev();
                gorev.Gorevsahibi = txt_isim.Text;
                gorev.gorev = richtxt_gorev.Text;
                gorev.musteri = txt_musteri.Text;
                gorev.PlanlananBitis = dt_planlanan.Value;
                gorev.GercekBitis = dt_gercekbitis.Value;

                LoginStatus sonuc = controller.gorevEkle(gorev);

                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Görev eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (sonuc == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Görev eklenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                GorevTablosu grvtbl = (GorevTablosu)Application.OpenForms["GorevTablosu"];
                grvtbl.updateDGV();
                DataGridView dgv = grvtbl.dataGridView1;
                dgv.FirstDisplayedScrollingRowIndex = grvtbl.SelectedRowIndex;
                this.Hide();
            }

            else if(_deneme=="guncelle")
            {
                Gorev gorev = new Gorev();
                GorevTablosu gt = (GorevTablosu)Application.OpenForms["GorevTablosu"];
                gorev.gorevID = gt.ID;
                gorev.Gorevsahibi = txt_isim.Text;
                gorev.gorev = richtxt_gorev.Text;
                gorev.musteri = txt_musteri.Text;
                gorev.PlanlananBitis = dt_planlanan.Value;
                gorev.GercekBitis = dt_gercekbitis.Value;
                LoginStatus sonuc = controller.gorevGuncelle(gorev);


                if (sonuc == LoginStatus.basarili)
                {
                    MessageBox.Show("Görev güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (sonuc == LoginStatus.basarisiz)
                {
                    MessageBox.Show("Görev güncellenirken bir hata oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Eksik parametre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                gt.updateDGV();
                DataGridView dgv = gt.dataGridView1;
                dgv.FirstDisplayedScrollingRowIndex = gt.SelectedRowIndex;
                this.Hide();
            }

        }

        private void btn_grvkapat_Click(object sender, EventArgs e)
        {
            GorevTablosu gorevt = (GorevTablosu)Application.OpenForms["GorevTablosu"];


            LoginStatus sonuc = controller.gorevAktiflikGuncelle(gorevt.ID, false);
            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Görev kapatıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Görev kapatılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gorevt.updateDGV();
            DataGridView dgv = gorevt.dataGridView1;
            dgv.FirstDisplayedScrollingRowIndex = gorevt.SelectedRowIndex;
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NBMHRPL0\SQLEXPRESS01;Initial Catalog=reminder;User ID=sa; password=123");
        SqlCommand cmd;
        SqlDataReader dr;
        public void addItemsListBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from login", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                listbox_kisiliste.Items.Add(dr["kullaniciAdi"].ToString());
            }
            con.Close();
        }

        private void panel_liste_Paint(object sender, PaintEventArgs e)
        {
            if (listbox_kisiliste.Items.Count == 0)
            {
                addItemsListBox();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel_liste.Visible = true;
        }

        private void listbox_kisiliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listbox_kisiliste.SelectedItem.ToString();
            listbox_secilenler.Items.Add(selectedItem);
            lbox_display.Items.Add(selectedItem);
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_liste.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listbox_secilenler_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbox_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

       

        
    }


