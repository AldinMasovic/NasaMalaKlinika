using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    enum Spol { Musko = 1, Zensko };
    enum Bracnostanje { Slobodan = 1, Razveden, U_braku }
    class Program
    {
        
        static void Main(string[] args)
        {
            //podaci
            Doktor doktor_17580_1 = new Doktor("Ahmed", "Arap", 50, 2000, true);
            Doktor doktor_17580_2 = new Doktor("Suada", "Sljivo", 51, 2100, true);
            Doktor doktor_17580_3 = new Doktor("Jasmin", "Prezimenko", 52, 1800, true);
            Doktor doktor_17580_4 = new Doktor("Faruk", "Arapovic", 53, 1900, true);
            Doktor doktor_17580_5 = new Doktor("Bakir", "Izedbegovic", 54, 2500, true);
            Doktor doktor_17580_6 = new Doktor("Sebljia", "Izedbegovic", 55, 1920, true);
            Doktor doktor_17580_7 = new Doktor("Fahrduin", "Radoncic", 56, 2050, true);
            Doktor doktor_17580_8 = new Doktor("Milorad", "Dodik", 57, 2100, true);
            List<Doktor>doktori_17580_1 = new List<Doktor>();doktori_17580_1.Add(doktor_17580_1);doktori_17580_1.Add(doktor_17580_2);doktori_17580_1.Add(doktor_17580_3);doktori_17580_1.Add(doktor_17580_4);
            Aparat aparat_17580_1 = new Aparat("EKG", true);
            Aparat aparat_17580_2 = new Aparat("Guglaj", true);
            Aparat aparat_17580_3 = new Aparat("Guglaj opet", true);
            Aparat aparat_17580_4 = new Aparat("Nemam ideju", true);
            Aparat aparat_17580_5 = new Aparat("Ne znam", true);
            Aparat aparat_17580_6 = new Aparat("Valjda nije bitno", true);
            Aparat aparat_17580_7 = new Aparat("Testiranje", true);
            Aparat aparat_17580_8 = new Aparat("No idea", true);
            List<Ordinacija>ordinacije_17580_1 = new List<Ordinacija>();
            Ordinacija hirurgija_17580_1 = new Ordinacija();
            hirurgija_17580_1.dodajAparat(ref aparat_17580_1);hirurgija_17580_1.DodajDoktora(ref doktor_17580_1);hirurgija_17580_1.CijenaUsluga(100);
            hirurgija_17580_1.NazivOrdinacije = "Opsta medicina";
            ordinacije_17580_1.Add(hirurgija_17580_1);
            Ordinacija hirurgija_17580_2 = new Ordinacija();
            hirurgija_17580_2.dodajAparat(ref aparat_17580_2);hirurgija_17580_2.DodajDoktora(ref doktor_17580_2);hirurgija_17580_2.CijenaUsluga(80);
            hirurgija_17580_2.NazivOrdinacije = "Ortopedska medicina";
            Ordinacija hirurgija_17580_3 = new Ordinacija();
            hirurgija_17580_3.dodajAparat(ref aparat_17580_3); hirurgija_17580_3.DodajDoktora(ref doktor_17580_3); hirurgija_17580_3.CijenaUsluga(20);
            hirurgija_17580_3.NazivOrdinacije = "Kardiološka medicina";
            Ordinacija hirurgija_17580_4 = new Ordinacija();
            hirurgija_17580_4.DodajDoktora(ref doktor_17580_4); hirurgija_17580_4.CijenaUsluga(30);
            hirurgija_17580_4.NazivOrdinacije = "Dermatološka";
            Ordinacija hirurgija_17580_5 = new Ordinacija();
            hirurgija_17580_5.dodajAparat(ref aparat_17580_5); hirurgija_17580_5.DodajDoktora(ref doktor_17580_5); hirurgija_17580_5.CijenaUsluga(100);
            hirurgija_17580_5.NazivOrdinacije = "Internisticka medicina";
            //ordinacije_17580_1.Add(hirurgija_17580_5);
            Ordinacija hirurgija_17580_6 = new Ordinacija();
            hirurgija_17580_6.dodajAparat(ref aparat_17580_6); hirurgija_17580_6.DodajDoktora(ref doktor_17580_6); hirurgija_17580_6.CijenaUsluga(30);
            hirurgija_17580_6.NazivOrdinacije = "Otoriolaringologija";
            //ordinacije_17580_1.Add(hirurgija_17580_6);
            Ordinacija hirurgija_17580_7 = new Ordinacija();
            hirurgija_17580_7.dodajAparat(ref aparat_17580_7); hirurgija_17580_7.DodajDoktora(ref doktor_17580_7); hirurgija_17580_7.CijenaUsluga(40);
            hirurgija_17580_7.NazivOrdinacije = "Ortamoloska medicina";
            //ordinacije_17580_1.Add(hirurgija_17580_7);
            Ordinacija hirurgija_17580_8 = new Ordinacija();
            hirurgija_17580_8.dodajAparat(ref aparat_17580_8); hirurgija_17580_8.DodajDoktora(ref doktor_17580_8); hirurgija_17580_8.CijenaUsluga(60);
            hirurgija_17580_8.NazivOrdinacije = "Labaratorijska medicina";
            //ordinacije_17580_1.Add(hirurgija_17580_8);
            ordinacije_17580_1.Add(hirurgija_17580_2);ordinacije_17580_1.Add(hirurgija_17580_3);ordinacije_17580_1.Add(hirurgija_17580_4);
            ordinacije_17580_1.Add(hirurgija_17580_5); ordinacije_17580_1.Add(hirurgija_17580_6); ordinacije_17580_1.Add(hirurgija_17580_7);
            ordinacije_17580_1.Add(hirurgija_17580_8);
            //zavrsen unos podataka
            Kartoteka kartoteka = new Kartoteka();
            List<Pacijent> pacijenti = new List<Pacijent>();
            //funkcije
            int unosBroja()
            {
                //Console.WriteLine("Unesite broj: ");
                int x;
                string s;
                s = Console.ReadLine();
                bool uspjesno = Int32.TryParse(s, out x);
                return x;
            }
            void unosDatuma(ref DateTime date)
            {
                bool datumIspravan = false;
                while (!datumIspravan)
                {
                    Console.WriteLine("(dd/mm/yyyy):");
                    string datum_rodjenja = Console.ReadLine();
                    
                    datumIspravan = DateTime.TryParseExact(datum_rodjenja, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
                    if (!datumIspravan) Console.WriteLine("Neispravan unos");
                }
                return ;
            }
            int MenuHitniPregled()
            {
                Console.WriteLine("Je li bio hitni pregled: ");
                Console.WriteLine("1. Jeste: ");
                Console.WriteLine("2. Nije: ");
                return unosBroja();
            }
            int unosBracnoStanje()
            {
                int n=0;
                while(n<1 || n > 3) {
                    Console.WriteLine("1. Slobodan");
                    Console.WriteLine("2. Razveden");
                    Console.WriteLine("3. U braku");
                    n = unosBroja(); }
                return n;
            }
            int unosSpol()
            {
                int n = 0;
                while(n<1 || n > 2)
                {
                    Console.WriteLine("1. Musko");
                    Console.WriteLine("2. Zensko");
                    n = unosBroja();
                }
                return n;
            }
            int Menu()
            {
                
                Console.WriteLine("1. Registruj/Brisi pacijenta: ");
                Console.WriteLine("2. Prikazi raspored pregleda pacijenta: ");
                Console.WriteLine("3. Kreiraj karton pacijenta: ");
                Console.WriteLine("4. Pretraga kartona pacijenta: ");
                Console.WriteLine("5. Registruj novi pregled: ");
                Console.WriteLine("6. Analiza sadrzaja: ");
                Console.WriteLine("7. Naplata: ");
                Console.WriteLine("8. Ostalo: ");
                Console.WriteLine("0. Izlaz");
                return unosBroja();
            }
            int MenuOrdinacija()
            {
                Console.WriteLine("Gdje zelite zakazati pregled?");
                Console.WriteLine("{0}. Izlaz", 0);
                Console.WriteLine("1. Ljekarski pregled za vozacku dozvolu: ");
                Console.WriteLine("         Cijena usluge: {0}", ordinacije_17580_1[0].CijenaUsluga()+
                    ordinacije_17580_1[2].CijenaUsluga()+ ordinacije_17580_1[5].CijenaUsluga());
                Console.WriteLine("2. Ljekarski pregled za konkurs za posao: ");
                Console.WriteLine("         Cijena usluge: {0}", ordinacije_17580_1[0].CijenaUsluga()+
                    ordinacije_17580_1[6].CijenaUsluga());
                for (int i = 0; i < ordinacije_17580_1.Count; i++)
                {
                    if(ordinacije_17580_1[i].Aparat!=null)
                    if (!ordinacije_17580_1[i].Aparat.Ispravan) continue;
                    Console.WriteLine("{0}. {1}", i + 3, ordinacije_17580_1[i].NazivOrdinacije);
                    Console.WriteLine("         Cijena usluge: {0}",ordinacije_17580_1[i].CijenaUsluga());
                    if (!ordinacije_17580_1[i].Doktor.Prisutan) Console.WriteLine("Napomena: Doktor trenutno nije prisutan");

                }
                return unosBroja();
            }
            int MenuOstalo()
            {
                Console.WriteLine("1. Pacijent pregledan:");
                Console.WriteLine("2. Doktor mjenja prisustvo:");
                Console.WriteLine("3. Aparat u kvaru/popravljen:");
                Console.WriteLine("0. Izlaz");
                return unosBroja();
            }
            int MenuRegistrujBrisi()
            {
                Console.WriteLine("1. Registruj pacijenta");
                Console.WriteLine("2. Obrisi pacijenta:");
                Console.WriteLine("3. Izlaz:");
                return unosBroja();
            }
            int MenuAnaliza()
            {
                Console.WriteLine("1. Najposjeceniji doktor");
                Console.WriteLine("2. Doktor sa najvecom platom:");
                Console.WriteLine("3. Najvise posijeta od strane pacijenta:");
                Console.WriteLine("0. Izlaz:");
                return unosBroja();
            }
            Console.WriteLine("Dobro dosli! Odaberite jednu od opcija: ");
            bool istina = false;
            int izbor = Menu();
            if (izbor != 0) istina = true;
            while (istina)
            {
                switch (izbor)
                {
                    case 0:
                        istina = false;
                        break;
                    case 1:
                        //unos pacijenta funkcija
                        int registracija = MenuRegistrujBrisi();
                        if (registracija == 1)
                        {
                            string s1, s2;
                            int id1;
                            Console.WriteLine("Unesite ime pacijenta:");
                            s1 = Console.ReadLine();
                            Console.WriteLine("Unesite prezime pacijenta:");
                            s2 = Console.ReadLine();
                            Console.WriteLine("Unesite JMBG pacijenta:");
                            id1 = unosBroja();
                            bool postoji = false;
                            for(int i = 0; i < pacijenti.Count; i++) if (pacijenti[i].Jmbg == id1)
                                {
                                    Console.WriteLine("Pacijent je vec registrovan");postoji = true;break;
                                }
                            if (postoji) break;
                            DateTime datum_rodjenja = new DateTime();
                            Console.Write("Unesite datum rodjenja pacijenta ");
                            unosDatuma(ref datum_rodjenja);
                            Console.WriteLine("Unesite spol pacijenta: ");
                            Spol spol = (Spol)unosSpol();
                            Console.WriteLine("Unesite adresu pacijenta: ");
                            string adresa = Console.ReadLine();
                            Console.WriteLine("Unesite bracno stanje pacijenta: ");
                            Bracnostanje bracno = (Bracnostanje)unosBracnoStanje();
                            Console.Write("Unesite datum prijema pacijenta ");
                            DateTime datum_prijema = new DateTime();
                            unosDatuma(ref datum_rodjenja);
                            Pacijent pacijent = new Pacijent(s1, s2, datum_rodjenja,id1,spol,adresa,bracno,datum_prijema);
                            if (kartoteka.postojiLiKarton(id1))
                            {
                                pacijent.Karton = kartoteka.DajKarton(id1);
                                int hitni = MenuHitniPregled();
                                if (hitni == 1)
                                {
                                    Console.WriteLine("Opis: ");
                                    string opis = Console.ReadLine();
                                    Console.WriteLine("Razlog: ");
                                    string razlog = Console.ReadLine();
                                    Console.WriteLine("Datum: ");
                                    string datum = Console.ReadLine();
                                    Prva_pomoc prva = new Prva_pomoc(opis, razlog, datum);
                                    pacijent.Karton.DodajHitniPregled(prva);

                                }
                                else break;
                            }
                            else
                            {
                                Console.WriteLine("Pacijent ne posjeduje karton u bazi podataka");
                                Console.WriteLine();
                            }
                            Console.WriteLine("Uspjesno registrovan pacijent");
                            Console.WriteLine();
                            pacijenti.Add(pacijent);
                        }
                        else if (registracija == 2)
                        {
                            Console.WriteLine("Unesite JMBG pacijenta:");
                            int id1 = unosBroja();
                            int i;
                            for (i = 0; i < pacijenti.Count; i++)
                            {
                                if (pacijenti[i].Jmbg == id1) { pacijenti.Remove(pacijenti[i]); break; }
                            }
                            if (i != pacijenti.Count) Console.WriteLine("Pacijent nije u bazi");

                        }
                        else break;
                        break;
                    case 2:
                        Console.WriteLine("Unesite JMBG pacijenta");
                        int id = unosBroja();
                        if (kartoteka.postojiLiKarton(id))
                        {
                            kartoteka.DajKarton(id).IspisiPreglede();
                            Karton privmreno = kartoteka.DajKarton(id);
                            for (int i = 0; i < ordinacije_17580_1.Count; i++)
                            {
                                if (!ordinacije_17580_1[i].Doktor.Prisutan && privmreno.Postoji_Li_Pregled(
                                    ordinacije_17580_1[i].NazivOrdinacije))
                                {
                                    Console.WriteLine("Napomena: Doktor {0} {1} iz ordinacije {3} nije prisutan",
                                        ordinacije_17580_1[i].Doktor.Ime, ordinacije_17580_1[i].Doktor.Prezime, ordinacije_17580_1[i].NazivOrdinacije);
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Pacijent sa unesenim JMBG-om ne postoji u bazi podataka");
                        }
                        break;
                    case 3:
                        {
                            string ss1, ss2;
                            int ids1;
                            Console.WriteLine("Unesite ime pacijenta:");
                            ss1 = Console.ReadLine();
                            Console.WriteLine("Unesite prezime pacijenta:");
                            ss2 = Console.ReadLine();
                            Console.WriteLine("Unesite JMBG pacijenta:");
                            ids1 = unosBroja();
                            Console.Write("Unesite datum rodjenja pacijenta ");
                            DateTime datetime = new DateTime();
                            unosDatuma(ref datetime);
                            Console.WriteLine("Unesite spol pacijenta: ");
                            Spol spol = (Spol)unosSpol();
                            Console.WriteLine("Unesite adresu pacijenta: ");
                            string adresa = Console.ReadLine();
                            Console.WriteLine("Unesite bracno stanje pacijenta: ");
                            Bracnostanje bracnostanje =(Bracnostanje) unosBracnoStanje();
                            Console.Write("Unesite datum prijema pacijenta ");
                            DateTime datumprijema = new DateTime();
                            unosDatuma(ref datumprijema);
                            Console.WriteLine("Unesite aktivne bolesti pacijenta: ");
                            string bolesti = Console.ReadLine();
                            Console.WriteLine("Unesite aktivne alergije pacijenta: ");
                            string alergije = Console.ReadLine();
                            Console.WriteLine("Unesite neaktivne bolesti pacijenta: ");
                            string bolesti1 = Console.ReadLine();
                            Console.WriteLine("Unesite neaktivne bolesti pacijenta: ");
                            string alergije1 = Console.ReadLine();
                            if (kartoteka.postojiLiKarton(ids1)) { Console.WriteLine("Karton vec postoji"); break; }
                            Karton kartoncic = new Karton(ss1, ss2, datetime, ids1, spol, adresa, bracnostanje, datumprijema,
                                bolesti,alergije,bolesti1,alergije1);
                            int hitni = MenuHitniPregled();
                            if (hitni == 1)
                            {
                                Console.WriteLine("Opis: ");
                                string opis = Console.ReadLine();
                                Console.WriteLine("Razlog: ");
                                string razlog = Console.ReadLine();
                                Console.WriteLine("Datum: ");
                                string datum = Console.ReadLine();
                                Prva_pomoc prva = new Prva_pomoc(opis, razlog, datum);
                                kartoncic.DodajHitniPregled(prva);

                            }
                            kartoteka.DodajKarton(ref kartoncic);
                            for (int i = 0; i < pacijenti.Count; i++)
                            {
                                if (pacijenti[i].Jmbg == ids1) { pacijenti[i].Karton = kartoncic; break; }
                            }
                        }
                        break;
                    case 4:

                        Console.WriteLine("Unesite JMBG pacijenta: ");
                        int unosjmbg = unosBroja();
                        if (kartoteka.postojiLiKarton(unosjmbg))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Izvolite vas karton :D");
                            kartoteka.DajKarton(unosjmbg).IspisiSve();
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Karton ne postoji u bazi podataka");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Unesite JMBG pacijenta:");
                        int ll = unosBroja();
                        for (int i = 0; i < pacijenti.Count; i++)
                        {
                            if (pacijenti[i].Jmbg == ll)
                            {
                                if (!kartoteka.postojiLiKarton(ll)) { Console.WriteLine("Pacijent ne posjeduje karton u bazi podataka"); break; }
                                while (true)
                                {
                                    int j = MenuOrdinacija();
                                    if (j == 0) break;
                                    if (j == 1)
                                    {
                                        ordinacije_17580_1[0].dodajPacijenta(pacijenti[i]);
                                        ordinacije_17580_1[2].dodajPacijenta(pacijenti[i]);
                                        ordinacije_17580_1[5].dodajPacijenta(pacijenti[i]);
                                        Pregled pregledcic = new Pregled(ordinacije_17580_1[0].NazivOrdinacije, "",
                                            ordinacije_17580_1[0].CijenaUsluga());
                                        pregledcic.Broj_u_redu = ordinacije_17580_1[0].Broj_U_Redu();
                                        pacijenti[i].Karton.DodajPregled(pregledcic);
                                        Pregled pregledcic1 = new Pregled(ordinacije_17580_1[2].NazivOrdinacije, "",
                                            ordinacije_17580_1[2].CijenaUsluga());
                                        pregledcic1.Broj_u_redu = ordinacije_17580_1[2].Broj_U_Redu();
                                        pacijenti[i].Karton.DodajPregled(pregledcic1);
                                        Pregled pregledcic2 = new Pregled(ordinacije_17580_1[5].NazivOrdinacije, "",
                                            ordinacije_17580_1[5].CijenaUsluga());
                                        pregledcic2.Broj_u_redu = ordinacije_17580_1[5].Broj_U_Redu();
                                        pacijenti[i].Karton.DodajPregled(pregledcic2);
                                        Console.WriteLine();
                                        Console.WriteLine("Uspjesno ste zakazali preglede za ljekarski za vozacki ispit");
                                        Console.WriteLine();

                                    }
                                    else if (j == 2)
                                    {
                                        ordinacije_17580_1[0].dodajPacijenta(pacijenti[i]);
                                        ordinacije_17580_1[6].dodajPacijenta(pacijenti[i]);
                                        Pregled pregledcic = new Pregled(ordinacije_17580_1[0].NazivOrdinacije, "",
                                            ordinacije_17580_1[0].CijenaUsluga());
                                        pregledcic.Broj_u_redu = ordinacije_17580_1[0].Broj_U_Redu();
                                        pacijenti[i].Karton.DodajPregled(pregledcic);
                                        Pregled pregledcic1 = new Pregled(ordinacije_17580_1[6].NazivOrdinacije, "",
                                            ordinacije_17580_1[6].CijenaUsluga());
                                        pregledcic1.Broj_u_redu = ordinacije_17580_1[6].Broj_U_Redu();
                                        pacijenti[i].Karton.DodajPregled(pregledcic1);
                                        Console.WriteLine();
                                        Console.WriteLine("Uspjesno ste zakazali preglede za ljekarski za konkurs za posao");
                                        Console.WriteLine();

                                    }
                                    else
                                    {
                                        ordinacije_17580_1[j - 3].dodajPacijenta(pacijenti[i]);
                                        Pregled pregledcic = new Pregled(ordinacije_17580_1[j - 3].NazivOrdinacije, "",
                                            ordinacije_17580_1[j - 3].CijenaUsluga());
                                        pregledcic.Broj_u_redu = ordinacije_17580_1[j - 3].Broj_U_Redu();
                                        pacijenti[i].Karton.DodajPregled(pregledcic);
                                        Console.WriteLine();
                                        Console.WriteLine("Vi ste {0} na redu cekanja", pacijenti[i].Karton.
                                            DajPregled(ordinacije_17580_1[j - 3].NazivOrdinacije).Broj_u_redu);
                                        Console.WriteLine();
                                    }
                                    pacijenti[i].Karton.SortirajPreglede();
                                }
                            }
                        }
                        break;
                    case 6:
                        int analiza = MenuAnaliza();
                        if (analiza == 1)
                        {
                            int index = 0, max = ordinacije_17580_1[0].Protok;
                            for (int i = 1; i < ordinacije_17580_1.Count; i++)
                            {
                                if (ordinacije_17580_1[i].Protok > max) { max = ordinacije_17580_1[i].Protok; index = i; }
                            }
                            Console.WriteLine("Najposjeceniji doktor je: {0} {1} sa brojem posjeta {2}",
                                ordinacije_17580_1[index].Doktor.Ime, ordinacije_17580_1[index].Doktor.Prezime,ordinacije_17580_1[index].Protok);
                        }
                        else if (analiza == 2)
                        {
                            int index = 0, max = ordinacije_17580_1[0].Doktor.Plata;
                            for (int i = 1; i < ordinacije_17580_1.Count; i++)
                            {
                                if (ordinacije_17580_1[i].Doktor.Plata > max) { max = ordinacije_17580_1[i].Doktor.Plata; index = i; }
                            }
                            Console.WriteLine("Doktor sa najvecom platom je: {0} {1} u iznosu od {2}",
                                ordinacije_17580_1[index].Doktor.Ime, ordinacije_17580_1[index].Doktor.Prezime, ordinacije_17580_1[index].Doktor.Plata);

                        }
                        else if (analiza == 3)
                        {
                            Karton aa=kartoteka.Najposjeceniji();
                            Console.WriteLine("Pacijent koji je najvise puta posjetio ovu ustanovu je: {0} {1}",
                                aa.Ime, aa.Prezime);
                        }

                        break;
                    case 7:
                        Console.WriteLine("Unesite JMBG pacijenta: ");
                        int l = unosBroja();
                        for(int i = 0; i < pacijenti.Count; i++)
                        {
                            if (pacijenti[i].Jmbg == l)
                            {
                                pacijenti[i].Karton.IspisiPregledeZaRacun();
                                    Console.WriteLine("Da li zelite da platite na rate ili odmah?");
                                    Console.WriteLine("1. Odmah");
                                    Console.WriteLine("2. Na rate");
                                    Console.WriteLine("3. Uplata rate");
                                    Console.WriteLine("0. Izlaz");
                                    l = unosBroja();
                                if (l == 1)
                                {
                                    pacijenti[i].Karton.Racun = 0;
                                }
                                else if (l == 2)
                                {
                                    double rata = pacijenti[i].Karton.Racun / (double)3;
                                    Console.WriteLine("Mjesecna rata je: {0}", rata);
                                    pacijenti[i].Karton.Dug += pacijenti[i].Karton.Racun;
                                    pacijenti[i].Karton.Dug -= rata;
                                    pacijenti[i].Karton.Rate = 3;
                                    pacijenti[i].Karton.Rate--;
                                    Console.WriteLine("Dugovanje pacijenta je: {0}", pacijenti[i].Karton.Dug);
                                    Console.WriteLine("Preostalo je jos {0} rata", pacijenti[i].Karton.Rate);
                                    pacijenti[i].Karton.Broj_dolazaka++;
                                }
                                else if (l == 3)
                                {
                                    Console.WriteLine("Dugovanje pacijenta je: {0}", pacijenti[i].Karton.Dug);
                                    Console.WriteLine("Koliki iznos zelite uplatiti: ");
                                    int iznos = unosBroja();
                                    pacijenti[i].Karton.Dug -= iznos;
                                    pacijenti[i].Karton.Rate--;
                                    Console.WriteLine("Preostalo za uplatiti je: {0}", pacijenti[i].Karton.Dug);
                                    Console.WriteLine("Preostalo je jos {0} rata", pacijenti[i].Karton.Rate);

                                }
                                else break;
                                }
                                else
                                break;   
                        }
                        break;
                    case 8:
                        int osmica = MenuOstalo();
                        switch (osmica)
                        {
                            case 1:
                                //Console.WriteLine("Vas JMBG");
                                //int id2 = unosBroja();
                                Console.WriteLine("Koja ordinacija je u pitanju");
                                for(int i = 0; i < ordinacije_17580_1.Count; i++)
                                {
                                    Console.WriteLine("{0}. {1}", i + 1, ordinacije_17580_1[i].NazivOrdinacije);
                                }
                                int id2 = unosBroja();
                                ordinacije_17580_1[id2 - 1].PregledanPacijent();
                                break;
                            case 2:
                                Console.WriteLine("Koja ordinacija je u pitanju");
                                for (int i = 0; i < ordinacije_17580_1.Count; i++)
                                {
                                    Console.WriteLine("{0}. {1}", i + 1, ordinacije_17580_1[i].NazivOrdinacije);
                                }
                                int id3 = unosBroja();
                                ordinacije_17580_1[id3 - 1].Doktor.PromjeniPrisustvo();
                                break;
                            case 3:
                                Console.WriteLine("Koja ordinacija je u pitanju");
                                for (int i = 0; i < ordinacije_17580_1.Count; i++)
                                {
                                    Console.WriteLine("{0}. {1}", i + 1, ordinacije_17580_1[i].NazivOrdinacije);
                                }
                                int id4 = unosBroja();
                                ordinacije_17580_1[id4 - 1].Aparat.PromjeniIspravnost();
                                break;
                            default:
                                break;
                        }
                        break;
                }
                izbor = Menu();
                if (izbor == 0) istina = false;
            }
           // kartoteka.IspisiSveKartone();
            Console.ReadKey();
            
        }
    }
}
