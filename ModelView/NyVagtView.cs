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

namespace VagtplanNy.ModelView
  {
    public class NyVagtView
{
    const string serverUrl = "http://localhost:56319/";


    private string medarbejderNavnVagt;
    private string vagtAfdeling;
    private string vagtLokation;
    private string vagtTid;
    private string vagtDato;
    


    public string MedarbejderNavnVagt { get => medarbejderNavnVagt; set => medarbejderNavnVagt = value; }
    public string VagtAfdeling{ get => vagtAfdeling; set => vagtAfdeling = value; }
    public string VagtLokation { get => vagtLokation; set => vagtLokation = value; }
    public string VagtTid { get => vagtTid; set => vagtTid = value; }
    public string VagtDato { get => vagtDato; set => vagtDato = value; }

    public ObservableCollection<NyVagt> OC_NyVagt { get; set; }

    public RelayCommand AddNyVagt { get; set; }
    public RelayCommand HentData { get; set; }

    public NyVagtView()
    {
        OC_NyVagt = new ObservableCollection<NyVagt>();

        AddNyVagt = new RelayCommand(AddVagt);

        //HentData = new RelayCommand(Get);

    }

    public void AddVagt()
    {
        OC_NyVagt.Clear();
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
                NyVagt m1 = new NyVagt() { NyVagtNavn = MedarbejderNavnVagt, NyVagtAfdeling = VagtAfdeling, NyVagtLokation = VagtLokation, NyVagtTid = VagtTid, NyVagtDato = VagtDato };

                //og her poster vi det til vores database som en Json og som Async så det programmet ikke føles langsomt
                var nyVagtResponse = client.PostAsJsonAsync("api/NyVagts", m1).Result;

                //Check response -> throw exception if NOT successful
                nyVagtResponse.EnsureSuccessStatusCode();

                // her henter vi tabellen fra databasen 
                var getmedarbejderResponse = client.GetAsync("api/NyVagts").Result;

                //Check response -> throw exception if NOT successful
                getmedarbejderResponse.EnsureSuccessStatusCode();

                //her tager vi tabellen Medarbejder som vi lige har hentet laver det til en en ICollection
                var DBNyVagt = getmedarbejderResponse.Content.ReadAsAsync<ICollection<NyVagt>>().Result;
                // her for vi udskrevet tabellen som en foreach i programmet i vores observablecollection 
                foreach (var Nyvagt in DBNyVagt)
                {

                    OC_NyVagt.Add(Nyvagt);
                }
            }
            catch
            {

            }
        }
    }

}
}
