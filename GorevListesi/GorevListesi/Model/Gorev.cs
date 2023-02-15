using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevListesi.Model
{
    public class Gorev
    {
        public int gorevID { get; set; }
        public string Gorevsahibi { get; set; }
        public string gorev { get; set; }
        public string musteri { get; set; }
        public DateTime PlanlananBitis { get; set; }
        public DateTime GercekBitis { get; set; }
        public bool GorevAktiflik { get; set; }

    }
}
