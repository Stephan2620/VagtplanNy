using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VagtplanNy
{
    public partial class Medarbejder
    {
        public Medarbejder(int medarbejderID, string navn, string telefon)
        {
            MedarbejderID = medarbejderID;
            Navn = navn;
            Telefon = telefon;
        }

        public int MedarbejderID { get; set; }


        public string Navn { get; set; }

        public string Telefon { get; set; }

    }
}
