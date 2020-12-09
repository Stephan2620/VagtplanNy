﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace VagtplanNy
{
    public partial class Medarbejder : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string navn;

        public string Navn
        {
            get { return navn; }
            set
            {
                navn = value;
                OnPropertyChanged();
            }
        }




        private string telefon;

        public string Telefon
        {
            get { return telefon; }
            set
            {
                telefon = value;
                OnPropertyChanged();
            }
        }

  



        public Medarbejder(string navn, string telefon)
        {
            Navn = navn;
            Telefon = telefon;
        }

        public Medarbejder()
        {
        }

    }
}
