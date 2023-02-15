using GorevListesi.enumeration;
using GorevListesi.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorevListesi.dao
{
    public class repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<User> userList;
        List<Gorev> gorevList;
        private object dataGridView1;

        public repository()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-NBMHRPL0\SQLEXPRESS01;Initial Catalog=reminder;User ID=sa; password=123");
        }
       
        public List<User> getLoginTable()
        {
            List<User> userList = new List<User>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from login", con);
            dr = cmd.ExecuteReader();
            

            while(dr.Read())
            {
                User user = new User();
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.emailAdres = dr["emailAdres"].ToString();
                userList.Add(user);
            }
            con.Close();

            return userList;
        }

        public LoginStatus authentication(string kullaniciAdi, string sifre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count (*) from login where kullaniciAdi=@kulad and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();

            if(returnvalue==1)
            {
                return LoginStatus.basarili;
            }
            return LoginStatus.basarisiz;
        }

        public List<Gorev> tumGorevleriGetir()
        {
            gorevList = new List<Gorev>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Gorev", con);
            dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                Gorev gorev = new Gorev();
                gorev.gorevID = int.Parse(dr["GorevID"].ToString());
                gorev.Gorevsahibi = dr["GorevSahibi"].ToString();
                gorev.gorev = dr["gorev"].ToString();
                gorev.musteri = dr["musteri"].ToString();
                gorev.PlanlananBitis = DateTime.Parse(dr["PlanlananBitis"].ToString());
                gorev.GercekBitis = DateTime.Parse(dr["GercekBitis"].ToString());
                gorev.GorevAktiflik = bool.Parse(dr["GorevAktiflik"].ToString());
                
                gorevList.Add(gorev);
            }
            con.Close();
            return gorevList;
        }

        public LoginStatus gorevGuncelle(Gorev gorev)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("gorevGuncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", gorev.gorevID);
            cmd.Parameters.AddWithValue("@GorevSahibi", gorev.Gorevsahibi);
            cmd.Parameters.AddWithValue("@gorev", gorev.gorev);
            cmd.Parameters.AddWithValue("@musteri", gorev.musteri);
            cmd.Parameters.AddWithValue("@PlanBitis", gorev.PlanlananBitis);
            cmd.Parameters.AddWithValue("@GercekBitis", gorev.GercekBitis);
            //cmd.Parameters.AddWithValue("@GorevAktifligi", gorev.GorevAktiflik);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            
            

            
            if (returnvalue==1)
            {
                return LoginStatus.basarili;
                
            }
            return LoginStatus.basarisiz;
               
           
        }

        public Gorev gorevGetir(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Gorev where GorevID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            dr = cmd.ExecuteReader();

            Gorev grv = new Gorev();
            if (dr.Read())
            {
               
                grv.gorevID = id;
                grv.Gorevsahibi = dr["GorevSahibi"].ToString();
                grv.gorev = dr["gorev"].ToString();
                grv.musteri = dr["musteri"].ToString();
                grv.PlanlananBitis = DateTime.Parse(dr["PlanlananBitis"].ToString());
                grv.GercekBitis = DateTime.Parse(dr["GercekBitis"].ToString());
              
            }
            con.Close();
            return grv;
            
            
        }

        public LoginStatus gorevEkle(Gorev gorev)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_gorevEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GorevSahibi", gorev.Gorevsahibi);
            cmd.Parameters.AddWithValue("@gorev", gorev.gorev);
            cmd.Parameters.AddWithValue("@musteri", gorev.musteri);
            cmd.Parameters.AddWithValue("@PlanBitis", gorev.PlanlananBitis);
            cmd.Parameters.AddWithValue("@GercekBitis", gorev.GercekBitis);
            //cmd.Parameters.AddWithValue("@GorevAktifligi", gorev.GorevAktiflik);
            returnvalue = cmd.ExecuteNonQuery();
            
            con.Close();

            if(returnvalue==1)
            {
                return LoginStatus.basarili;
            }
            return LoginStatus.basarisiz;
        }


        public LoginStatus gorevAktiflikGuncelle(int id, bool aktiflik)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Gorev set GorevAktiflik=@aktiflik where GorevID=@id", con);
            cmd.Parameters.AddWithValue("@aktiflik", aktiflik);
            cmd.Parameters.AddWithValue("@id", id);
            returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if(returnvalue==1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

        }

        public DataTable searchbox(string search)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@search", search);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        
        }

        //public void ProjeInsanlar(int id)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select from ProjeIlgilileri where GorevID=@id", con);
        //    cmd.Parameters.AddWithValue("@id", id);
        //    dr = cmd.ExecuteReader();
        //    con.Close();

        //}



    }
}
