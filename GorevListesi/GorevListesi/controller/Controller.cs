using GorevListesi.dao;
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

namespace GorevListesi.controller
{
    public class Controller
    {
        repository repository;
        public Controller()
        {
            repository = new repository();
        }

        public List<User> getLoginTable()
        {
            return repository.getLoginTable();
        }

        public LoginStatus authentication(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return repository.authentication(kullaniciAdi, sifre);
            }
            return LoginStatus.eksikParametre;
        }

        public List<Gorev> tumGorevleriGetir()
        {
            return repository.tumGorevleriGetir();
        }

        public LoginStatus gorevGuncelle(Gorev gorev)
        {
            return repository.gorevGuncelle(gorev);
        }

        public Gorev gorevGetir(int id)
        {
            return repository.gorevGetir(id);
        }

        public LoginStatus gorevEkle(Gorev gorev)
        {

            if(!string.IsNullOrEmpty(gorev.Gorevsahibi)&& !string.IsNullOrEmpty(gorev.gorev) && !string.IsNullOrEmpty(gorev.musteri)&& !string.IsNullOrEmpty(gorev.PlanlananBitis.ToString()))
                {
                return repository.gorevEkle(gorev);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }

        }

        public LoginStatus gorevAktiflikGuncelle(int id, bool aktiflik)
        {
            return repository.gorevAktiflikGuncelle(id, aktiflik);
        }

        public DataTable searchbox(string search)
        {
            return repository.searchbox(search);
        }


    }
}
