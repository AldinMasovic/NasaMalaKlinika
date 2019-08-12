using Klinika.Osoblje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
     class Pacijent:  Osoba, IIspisiIme
    {
        Karton karton;
        string ime;
        string prezime;
        DateTime datum_rodjenja;
        int jmbg;
        Spol spol;
        string adresa;
        Bracnostanje bracno_stanje;
        DateTime datum_prijema;

        public Pacijent(string ime, string prezime, DateTime datum, int jmbg,Spol spol,string adresa,
            Bracnostanje bracnostanje,DateTime datumprijema):base(ime,prezime,jmbg)
        {
            karton = null;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datum_rodjenja = datum;
            this.spol = spol;
            this.adresa = adresa;
            this.bracno_stanje = bracnostanje;
            this.datum_prijema = datumprijema;
        }

        public string Ime1 { get => ime; set => ime = value; }
        public string Prezime1 { get => prezime; set => prezime = value; }
        public int Jmbg { get => jmbg; set => jmbg = value; }
        internal Karton Karton { get => karton; set => karton = value; }
        //sortiraj preglede
        public void ispisiIme()
        {
            Console.WriteLine(ime);
        }
    }

        
    }
