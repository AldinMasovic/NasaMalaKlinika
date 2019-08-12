using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    partial class Prva_pomoc
    {
        string opis;
        string razlog;

        public Prva_pomoc(string opis, string razlog, string datum)
        {
            this.opis = opis;
            this.razlog = razlog;
            this.datum = datum;
        }

        public string Opis { get => opis; set => opis = value; }
        public string Razlog { get => razlog; set => razlog = value; }
    }

    partial class Prva_pomoc
        {
            string datum;

            public string Datum
            {
                get => datum; set => datum = value;
            }

            }
        }
