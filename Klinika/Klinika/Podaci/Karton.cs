using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    sealed class Karton
    {
        string ime;
        string prezime;
        DateTime datum_rodjenja;
        int jmbg;
        Spol spol;
        string adresa;
        Bracnostanje bracno_stanje;
        DateTime datum_prijema;
        List<string> misljenja;
        List<string> potpisi;
        List<string> ordinacije;
        List<string> terapije;
        List<Pregled> pregledi;
        List<Pregled> pregledano;
        double dug;
        int broj_dolazaka;
        int racun;
        int rate;
        //int brojac;
        List<DateTime> datumi;
        string aktivne;
        string pasivne;
        List<Prva_pomoc> hitne;

        public Karton(string ime, string prezime, DateTime datum, int jmbg, Spol musko, string adresa, Bracnostanje bracno_stanje, DateTime datumprijema
            ,string bolesti,string alergije,string bolesti1,string alergije1)
        {
            hitne = new List<Prva_pomoc>();
            terapije = new List<string>();
            pregledano = new List<Pregled>();
            rate = 0;
            aktivne = bolesti + " Alergije: " + alergije;
            pasivne = bolesti1 + "Alergije: " + alergije1;
            broj_dolazaka = 0;
            racun = 0;
            dug = 0;
            this.ime = ime;
            this.prezime = prezime;
            datum_rodjenja = datum;
            this.jmbg = jmbg;
            this.spol = musko;
            this.adresa = adresa;
            this.bracno_stanje = bracno_stanje;
            datum_prijema = datumprijema;
            misljenja = new List<string>();
            potpisi = new List<string>();
            ordinacije = new List<string>();
            pregledi = new List<Pregled>();
            datumi = new List<DateTime>();
        }
        public void DodajHitniPregled(Prva_pomoc l)
        {
            hitne.Add(l);
        }
        public void IspisiHitnepreglede()
        {
            for(int i = 0; i < hitne.Count; i++)
            {
                Console.WriteLine("Opis: {0}",hitne[i].Opis);
                Console.WriteLine("Razlog: {0}",hitne[i].Razlog);
                Console.WriteLine("Datum: {0}",hitne[i].Datum);
            }
        }
        public Karton() { }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Jmbg { get => jmbg; set => jmbg = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public double Dug { get => dug; set => dug = value; }
        public int Broj_dolazaka { get => broj_dolazaka; set => broj_dolazaka = value; }
        public int Broj_dolazaka1 { get => broj_dolazaka; set => broj_dolazaka = value; }
        public int Racun { get => racun; set => racun = value; }
        public int Rate { get => rate; set => rate = value; }

        public void MisljenjeDoktora(string misljenje,string terapija,string potpis,string ordinacija,DateTime datum)
        {
            misljenja.Add(misljenje);potpisi.Add(potpis);ordinacije.Add(ordinacija);terapije.Add(terapija);
            datumi.Add(datum);
        }
        public void Ispisi_misljenja_doktora()
        {
            Console.WriteLine();
            for(int i = 0; i < misljenja.Count; i++)
            {
                Console.WriteLine("Ordinacija: {0}", ordinacije[i]);
                Console.WriteLine("Misljenje: {0}", misljenja[i]);
                Console.WriteLine("Terapija: {0}", terapije[i]);
                Console.WriteLine("Datum: {0}", datumi[i]);
                Console.WriteLine("Potpis: {0}", potpisi[i]);
                Console.WriteLine();
            }
        }
        public void SortirajPreglede()
        {
            pregledi.Sort(delegate (Pregled x, Pregled y)
            {
                if (x.Broj_u_redu <= y.Broj_u_redu) return 0;
                else return 1;
            });
        }
        public void Ispisi()
        {
            Console.WriteLine("Ime: {0}", this.Ime);
            Console.WriteLine("Prezime: {0}", this.Prezime);
            Console.WriteLine("Godina rodjenja: {0}", datum_rodjenja);
            Console.WriteLine("JMBG: {0}", this.Jmbg);
            string s;if ((int)spol==1) s = "Musko"; else s = "Zensko";
            Console.WriteLine("Spol: {0}",s );
            Console.WriteLine("Adresa: {0}", this.Adresa);
            if ((int)bracno_stanje == 1) s = "Slobodan"; else if ((int)bracno_stanje == 2) s = "Razveden"; else s = "U braku";
            Console.WriteLine("Bracno stanje: {0}", s);
            Console.WriteLine("Datum prijema: {0}", datum_prijema);
            Ispisi_misljenja_doktora();
        }
        public void DodajPregled(Pregled l) { pregledi.Add(l); }
        public bool Postoji_Li_Pregled(string naziv)
        {
            for(int i = 0; i < pregledi.Count; i++)
            {
                if (pregledi[i].Preglede == naziv) return true;
            }
            return false;
        }
        public  Pregled DajPregled(string naziv)
        {
            for (int i = 0; i < pregledi.Count; i++)
            {
                if (pregledi[i].Preglede == naziv) return pregledi[i];
            }
            return null;
        }
        public void IspisiPreglede()
        {
            if (pregledi.Count == 0) Console.WriteLine("Nema zakazanih pregleda.");
            for (int i = 0; i < pregledi.Count; i++)
            {
                Console.WriteLine("{0}. pregled je: {1}, a vi ste {2}. u redu cekanja",
                    i + 1, pregledi[i].Preglede, pregledi[i].Broj_u_redu);
            }
            Console.WriteLine();
        }
        public void IspisiPregledeZaRacun()
        {
            for(int i = 0; i < pregledano.Count; i++)
            {
                Console.WriteLine("Pregled: {0} - cijena: {1}", pregledano[i].Preglede, pregledano[i].Cijena);
            }
            if (broj_dolazaka > 3)
            {
                Console.WriteLine("Ukupno za gotovinsko placanje: {0}", racun - 0.1 * racun);
                Console.WriteLine("Ukupno za placanje na 3 rate: {0}", racun);
            }
            else
            {
                Console.WriteLine("Ukupno za gotovinsko placanje: {0}", racun);
                Console.WriteLine("Ukupno za placanje na 3 rate: {0}", racun+0.15*racun);
            }
            Console.WriteLine();
            if (dug != 0) Console.WriteLine("Podsjecamo vas na dug od: {0}", dug);
            Console.WriteLine();
            for (int i = 0; i < pregledano.Count; i++)
            {
                pregledano.Remove(pregledano[i]);
                i--;
            }
            
        }
        public void IspisiSve()
        {
            this.Ispisi();
            this.IspisiPreglede();
            this.IspisiHitnepreglede();
            this.IspisiPregledeZaRacun();
            this.Ispisi_misljenja_doktora();

        }
        public void IzbrisiPregled(string s)
        {
            for(int i = 0; i < pregledi.Count; i++)
            {
                if (pregledi[i].Preglede == s)
                {
                    pregledano.Add(pregledi[i]);
                    pregledi.Remove(pregledi[i]);
                    break;
                }
            }
        }
    }
}
