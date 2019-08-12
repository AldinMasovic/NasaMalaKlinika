using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Kartoteka
    {
        List<Karton> pok;

        public Kartoteka()
        {
            pok = new List<Karton>();
        }

        public Kartoteka(List<Karton> pok, int duzina)
        {
            this.pok = pok;

        }
        public void DodajKarton(ref Karton x)
        {
            
            if (postojiLiKarton(x.Jmbg)) return;
            //treba pronaci karton ako postoji i samo ga dodijeliti
            pok.Add(x);//ili ga samo povezi
            
        }
        public bool postojiLiKarton(int jmbg)
        {
            for(int i = 0; i < pok.Count; i++)
            {
                if (pok[i].Jmbg == jmbg) return true;
            }
            return false;
        }
        public void IspisiSveKartone()
        {
            for(int i = 0; i < pok.Count; i++)
            {
                pok[i].IspisiSve();
            }
        }
        public  Karton DajKarton(int jmbg)
        {
            for(int i = 0; i < pok.Count; i++)
            {
                if (pok[i].Jmbg == jmbg) return  pok[i];
            }
            return null;
        }
        public int duzina() { return pok.Count; }
        public Karton Najposjeceniji()
        {
            int max = 0, index = 0;
            for(int i = 0; i < pok.Count; i++)
            {
                if (pok[i].Broj_dolazaka > max) { max = pok[i].Broj_dolazaka;index = i; }
            }
            return pok[index];
        }
        //dodaj metodu koja vraća karton obavezno!!!!
    }
}
