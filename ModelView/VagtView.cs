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
    public class VagtView
    {
        const string serverUrl = "http://localhost:56319/";

        public ObservableCollection<Vagt> OC_Vagt { get; set; }


        public VagtView()
        {
            OC_Vagt = new ObservableCollection<Vagt>();

            //OC_Vagt.Add(new Vagt("Afdeling", "Lokation", "tid"));


            OC_Vagt.Clear();

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
                    var vagtResponse = client.GetAsync("api/Vagts").Result;

                    //Check response -> throw exception if NOT successful
                    vagtResponse.EnsureSuccessStatusCode();

                    //Get the hotels as a ICollection
                    //var Medarbejderes = medarbejderResponse.Content.ReadAsAsync<List<Medarbejder>>().Result;

                    var vagter = vagtResponse.Content.ReadAsAsync<ICollection<Vagt>>().Result;

                    foreach (var Vagtere in vagter)
                    {

                        OC_Vagt.Add(Vagtere);
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
