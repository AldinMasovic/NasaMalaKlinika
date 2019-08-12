using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Ordinacija
    {
        string naziv;
        int cijena;
        Doktor doktor;
        Aparat aparat;
        List<Pacijent> pacijenti;
        int protok;
        int redcekanja;

        public string NazivOrdinacije { get => naziv; set => naziv = value; }
        internal Doktor Doktor { get => doktor; set => doktor = value; }
        internal Aparat Aparat { get => aparat; set => aparat = value; }
        public int Protok { get => protok; set => protok = value; }

        public Ordinacija()
        {
            cijena = 0; doktor = null;  aparat = null; pacijenti=new List<Pacijent>(); protok= 0;redcekanja = 0;
        }
        public void DodajDoktora(ref Doktor l) { doktor = l; }
        public void dodajAparat(ref Aparat l) { aparat = l; }
        public void dodajPacijenta(Pacijent l){
            protok++;
            redcekanja++;
            pacijenti.Add(l);//mozda da dodamo preko jmbg ili sam ga veæ alocirao vidjet æu
        }
        public void CijenaUsluga(int x) { cijena = x; }
        public int CijenaUsluga() { return cijena; }
        public void PregledanPacijent()
        {
            if (pacijenti.Count == 0)
            {
                Console.WriteLine("Nema pacijenata!");
                return;
            }
            string misljenje;
            Console.WriteLine("Vase misljenje: ");
            misljenje=Console.ReadLine();
            Console.WriteLine("Terapija: ");
            string terapija = Console.ReadLine();
            //Console.WriteLine("Datum: ");
            //string datum = Console.ReadLine();
            DateTime datum = new DateTime();
                bool datumIspravan = false;
                while (!datumIspravan)
                {
                    Console.WriteLine("Unesite datum pregleda pacijenta: dd/mm/yyyy");
                    string datum_rodjenja = Console.ReadLine();

                    datumIspravan = DateTime.TryParseExact(datum_rodjenja, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum);
                    if (!datumIspravan) Console.WriteLine("Neispravan unos");
                }
            pacijenti[0].Karton.MisljenjeDoktora(misljenje,terapija, Doktor.Ime +" "+ Doktor.Prezime, naziv,datum);
            pacijenti[0].Karton.Racun = pacijenti[0].Karton.Racun + cijena;
            pacijenti[0].Karton.IzbrisiPregled(this.naziv);
            pacijenti.Remove(pacijenti[0]);
            redcekanja--;
            for (int i = 0; i < pacijenti.Count; i++) pacijenti[i].Karton.DajPregled(this.naziv).Broj_u_redu--;
        }
        public int Broj_U_Redu() { return redcekanja; }
        public void IspisiSvePacijenteIzOrdinacije()
        {
            for (int i = 0; i < pacijenti.Count; i++) pacijenti[i].Karton.Ispisi();
        }
}
}
