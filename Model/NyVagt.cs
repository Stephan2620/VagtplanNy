using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace VagtplanNy
{
    public partial class NyVagt : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string nyVagtNavn;

        public string NyVagtNavn
        {
            get { return nyVagtNavn; }
            set
            {
                nyVagtNavn = value;
                OnPropertyChanged();
            }
        }
        private string nyVagtAfdeling;

        public string NyVagtAfdeling
        {
            get { return nyVagtAfdeling; }
            set
            {
                nyVagtAfdeling = value;
                OnPropertyChanged();
            }
        }

        private string nyVagtLokation;

        public string NyVagtLokation
        {
            get { return nyVagtLokation; }
            set
            {
                nyVagtLokation = value;
                OnPropertyChanged();
            }
        }


        private string nyVagtTid;

        public string NyVagtTid
        {
            get { return nyVagtTid; }
            set
            {
                nyVagtTid = value;
                OnPropertyChanged();
            }
        }

        private string nyVagtDato;

        public string NyVagtDato
        {
            get { return nyVagtDato; }
            set
            {
                nyVagtDato = value;
                OnPropertyChanged();
            }
        }



        public NyVagt(string nyVagtNavn, string nyVagtAfdeling, string nyVagtLokation, string nyVagtTid, string nyVagtDato)
        {
            NyVagtNavn = nyVagtNavn;
            NyVagtAfdeling = nyVagtAfdeling;
            NyVagtLokation = nyVagtLokation;
            NyVagtTid = nyVagtTid;
            NyVagtDato = nyVagtDato;
        }

        public NyVagt()
        {
        }


    }
}

 