using System.Net.Http;
using System.Threading.Tasks;
using AkkaClient;

namespace Service
{
    public class HomeService{
        private Client client;
        public HomeService(){
            client = new Client("http://localhost:4200",new HttpClient());
        }
        public Task<ImuttableHomeState> GetHomeState(){
            return client.GetHomeStateAsync();
        }

        public Task<double> getTemperature(Temperature t){
            switch(t){
                case Temperature.Fahrenheit:
                    return client.GetTemperatureFahrenheitAsync();
                case Temperature.Kelvin:
                    return client.GetTemperatureKelvinAsync();
                default:
                    return client.GetTemperatureCelsiusAsync();
            }
        }      

        public void setTemperature(Temperature t, double value){
            var msg = new TempPostMessage();
            msg.Temp = value;
            switch(t){
                case Temperature.Fahrenheit:
                     client.SetTemperatureFahrenheitAsync(msg);
                     break;
                case Temperature.Kelvin:
                    client.SetTemperatureKelvinAsync(msg);
                    break;
                default:
                    client.SetTemperatureCelsiusAsync(msg);
                    break;
            }
        }     

        public void openBlinds(){
            client.OpenBlindsAsync("").GetAwaiter().GetResult();
        }

         public void closeBlinds(){
            client.CloseBlindsAsync("").GetAwaiter().GetResult();
        }

         public void startMediaStation(){
          client.TurnOnMediastationAsync("").GetAwaiter().GetResult();                  
        }

          public void stopMediaStation(){
            client.TurnOffMediastationAsync("").GetAwaiter().GetResult();

        }
    }
  
}