using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
   sealed class Pregled
    {
        String pregled;
        String misljenje;
        int broj_u_redu;
        int cijena;
        public string Preglede { get => pregled; set => pregled = value; }
        public int Broj_u_redu { get => broj_u_redu; set => broj_u_redu = value; }
        public int Cijena { get => cijena; set => cijena = value; }

        //Ordinacija pregledi;
        public Pregled(string pregled,string misljenje,int cijena)
        {
            this.cijena = cijena;
            broj_u_redu = 0;
            this.pregled = pregled;
            this.misljenje = misljenje;
        }
        public string DajMisljenje()
        {
            return misljenje;
        }
        
    }
}
