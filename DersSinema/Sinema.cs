using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DersSinema
{
    public class Sinema
    {
        int ToplamKoltukSayisi { get; set; }
        int BosKoltukSayisi { get; set; }
        double Bakiye;
        string SalonNo;

        const double Tam = 15;
        const double Indirimli = 10;

        public Sinema(string SalonNo, int KoltukSayisi)
        {

            this.SalonNo = SalonNo;
            this.ToplamKoltukSayisi = KoltukSayisi;
            this.Bakiye = 0;
            this.BosKoltukSayisi = this.ToplamKoltukSayisi;


        }

        public void BiletSat(bool durum)
        {
            this.BosKoltukSayisi--;
            if (durum == true)
            {
                this.Bakiye += Indirimli;
            }
            else
            {
                this.Bakiye += Tam;
            }
        }


        public void Biletİptal(bool durum)
        {
            this.BosKoltukSayisi--;
            if (durum == true)
            {
                this.Bakiye -= Indirimli;
            }
            else
            {
                this.Bakiye -= Tam;
            }

        }
        public int BosKoltukOgren()
        {
            return this.BosKoltukSayisi;

        }
        public double BakiyeOgren()
        {
            return this.Bakiye;
        }

        
    }
}
