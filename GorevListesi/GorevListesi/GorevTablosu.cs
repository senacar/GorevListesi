using GorevListesi.controller;
using GorevListesi.enumeration;
using GorevListesi.Model;
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
    public partial class GorevTablosu : Form
    {
        Controller controller = new Controller();

        public GorevTablosu()
        {
            InitializeComponent();
        }

        public void updateDGV()
        {

            dataGridView1.DataSource = controller.tumGorevleriGetir();
        }



        public void GorevTablosu_Load(object sender, EventArgs e)
        {
            updateDGV();
        }


        private void btn_gunc_Click(object sender, EventArgs e)
        {



        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public int ID;

        public int SelectedRowIndex;

        public Gorev gorev;
        public void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowIndex = dataGridView1.CurrentRow.Index;
            GuncellemePaneli guncpanel = new GuncellemePaneli("guncelle");
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ID = id;

            //lastSelectedRowIndex = e.RowIndex;
            gorev = controller.gorevGetir(id);

            guncpanel.txt_isim.Text = gorev.Gorevsahibi;
            guncpanel.richtxt_gorev.Text = gorev.gorev;
            guncpanel.txt_musteri.Text = gorev.musteri;
            guncpanel.dt_planlanan.Value = gorev.PlanlananBitis;
            guncpanel.dt_gercekbitis.Value = gorev.GercekBitis;

            guncpanel.Show();
            dataGridView1.CurrentCell = dataGridView1[0, SelectedRowIndex];

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            bool aktiflik = Convert.ToBoolean(row.Cells["GorevAktiflik"].Value);

            if (!aktiflik)
            {
                row.DefaultCellStyle.BackColor = Color.Crimson;
            }

        }

        private void btn_gorevekle_Click(object sender, EventArgs e)
        {
            GuncellemePaneli gp = new GuncellemePaneli("ekle");
            gp.Show();

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text=="")
            {
                this.updateDGV();
            }
            DataTable dt = controller.searchbox(txt_search.Text);
            dataGridView1.DataSource = dt;

        }


    }
}

       

