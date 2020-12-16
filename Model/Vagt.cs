using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VagtplanNy
{
    public partial class Vagt : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string afdeling;

        public string Afdeling
        {
            get { return afdeling; }
            set
            {
                afdeling = value;
                OnPropertyChanged();
            }
        }

        private string lokation;

        public string Lokation
        {
            get { return lokation; }
            set
            {
                lokation = value;
                OnPropertyChanged();
            }
        }


        private string tid;

        public string Tid
        {
            get { return tid; }
            set
            {
                tid = value;
                OnPropertyChanged();
            }
        }


        public Vagt(string afdeling, string lokation, string tid)
        {
            Afdeling = afdeling;
            Lokation = lokation;
            Tid = tid;
        }

        public Vagt()
        {
        }


    }
}
