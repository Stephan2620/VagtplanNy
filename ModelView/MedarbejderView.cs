using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;


namespace VagtplanNy
{
    public class MedarbejderView
    {

        


        const string serverUrl = "http://localhost:56319/";

        private string medNavn;
        private string medTelefon;


        public string MedNavn { get => medNavn; set => medNavn = value; }
        public string MedTelefon { get => medTelefon; set => medTelefon = value; }


        public ObservableCollection<Medarbejder> OC_Medarbejder { get; set; }

        public RelayCommand AddNyMedarbejder { get; set; }

        public RelayCommand SletSelectedMedarbejder { get; set; }

        //public RelayCommand GemData { get; set; }

        public RelayCommand HentData { get; set; }

        public Medarbejder SelectedMedarbejder { get; set; }


        public MedarbejderView()
        {
            OC_Medarbejder = new ObservableCollection<Medarbejder>();

            //Testdata 
            OC_Medarbejder.Add(new Medarbejder("Cikurt", "12345678",1));
            OC_Medarbejder.Add(new Medarbejder("Simon", "12345678", 2));
            OC_Medarbejder.Add(new Medarbejder("Glen", "12345678", 3));



            AddNyMedarbejder = new RelayCommand(AddMedarbejder);

            SletSelectedMedarbejder = new RelayCommand(SletMedarbejder);

            //SelectedOrdreBlomst = new OrdreBlomst();


            //GemData = new RelayCommand(GemDataTilDiskAsync);

            HentData = new RelayCommand(Get);
            //DanData();
        }

        //public MedarbejderView(string medNavn, string medTelefon)
        //{
        //    MedNavn = medNavn;
        //    MedTelefon = medTelefon;
        //}



        public void AddMedarbejder()
        {
            OC_Medarbejder.Clear();
            //Setup client handler
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                //Initialize client
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();

                //Request JSON format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    // her tager vi data i text felterne og sætter dem ind til klassen Medarbejder og kalder det "m" 
                    Medarbejder m = new Medarbejder() {Navn = MedNavn, Telefon = MedTelefon };

                    //og her poster vi det til vores database som en Json og som Async så det programmet ikke føles langsomt
                    var medarbejderResponse = client.PostAsJsonAsync("api/Medarbejders", m).Result;

                    //Check response -> throw exception if NOT successful
                    medarbejderResponse.EnsureSuccessStatusCode();

                    // her henter vi tabellen fra databasen 
                    var getmedarbejderResponse = client.GetAsync("api/Medarbejders").Result;

                    //Check response -> throw exception if NOT successful
                    getmedarbejderResponse.EnsureSuccessStatusCode();

                    //her tager vi tabellen Medarbejder som vi lige har hentet laver det til en en ICollection
                    var DBMedarbejder = getmedarbejderResponse.Content.ReadAsAsync<ICollection<Medarbejder>>().Result;
                    // her for vi udskrevet tabellen som en foreach i programmet i vores observablecollection 
                    foreach (var Medarbejdere in DBMedarbejder)
                    {

                        OC_Medarbejder.Add(Medarbejdere);
                    }
                }
                catch
                {

                }
            }
        }


        public void Get()
        {
            //List<Medarbejder> nyListe = new List<Medarbejder>();

            //Setup client handler

            OC_Medarbejder.Clear();

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                //Initialize client
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();

                //Request JSON format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    //Get all medarbejdere fra database
                    var medarbejderResponse = client.GetAsync("api/Medarbejders").Result;

                    //Check response -> throw exception if NOT successful
                    medarbejderResponse.EnsureSuccessStatusCode();

                    //Get the hotels as a ICollection
                    //var Medarbejderes = medarbejderResponse.Content.ReadAsAsync<List<Medarbejder>>().Result;

                    var orders = medarbejderResponse.Content.ReadAsAsync<ICollection<Medarbejder>>().Result;

                    foreach (var Medarbejdere in orders)
                    {

                        OC_Medarbejder.Add(Medarbejdere);
                    }

                    //

                }
                catch
                {

                }
                //return OC_Medarbejder;
                //return null;
            }
        }
        private void SletMedarbejder()
        {

            //Setup client handler
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                //Initialize client
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();

                //Request JSON format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    //Get all the flower orders from the database

                    var MedarbejderResponse = client.DeleteAsync($"api/Medarbejders/{SelectedMedarbejder.MedarbejderID}").Result;

                    //Check response -> throw exception if NOT successful
                    MedarbejderResponse.EnsureSuccessStatusCode();
                    
                    //Get the hotels as a ICollection
                    var orders = MedarbejderResponse.Content.ReadAsAsync<Medarbejder>().Result;

                    SletSelectedMedarbejder.RaiseCanExecuteChanged();
                }
                catch
                {

                }
            }
            OC_Medarbejder.Remove(SelectedMedarbejder);
            SletSelectedMedarbejder.RaiseCanExecuteChanged();

        }


    }

}
