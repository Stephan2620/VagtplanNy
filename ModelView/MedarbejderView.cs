using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VagtplanNy
{
    public class MedarbejderView
    {

        


        const string serverUrl = "http://localhost:56319/";


        public ObservableCollection<Medarbejder> OC_Medarbejder { get; set; }

        public RelayCommand AddNyMedarbejder { get; set; }

        //public RelayCommand SletSelectedBlomst { get; set; }

        //public RelayCommand GemData { get; set; }

        public RelayCommand HentData { get; set; }



        public MedarbejderView()
        {
            OC_Medarbejder = new ObservableCollection<Medarbejder>();

            //Testdata 
            OC_Medarbejder.Add(new Medarbejder(4, "Cikurt", "Rød"));
            OC_Medarbejder.Add(new Medarbejder(4, "Simon", "Hvid"));
            OC_Medarbejder.Add(new Medarbejder(4, "Glen", "Gul"));

            AddNyMedarbejder = new RelayCommand(AddMedarbejder);
            //SletSelectedBlomst = new RelayCommand(SletBlomst, canDeleteBlomsterListe);

            //SelectedOrdreBlomst = new OrdreBlomst();


            //GemData = new RelayCommand(GemDataTilDiskAsync);

            HentData = new RelayCommand(Get);
            //DanData();
        }


        public void AddMedarbejder()
        {
            //Medarbejder oBlomst = new Medarbejder(medarbejderID, navn, telefon);

            //OC_blomster.Add(oBlomst);

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
                    //Medarbejder m = new Medarbejder() { MedarbejderID , Navn, Telefon };
                    //Get all the flower orders from the database
                    //var medarbejderResponse = client.PostAsJsonAsync<Medarbejder>("api/Medarbejders", m).Result;

                    //Check response -> throw exception if NOT successful
                    //medarbejderResponse.EnsureSuccessStatusCode();

                    //Get the hotels as a ICollection
                    //var medarbejder = medarbejderResponse.Content.ReadAsAsync<Medarbejder>().Result;

                    //SletSelectedBlomst.RaiseCanExecuteChanged();
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
                    //Get all the flower orders from the database
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


    }

}
