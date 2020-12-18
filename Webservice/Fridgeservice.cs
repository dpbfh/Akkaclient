using System.Net.Http;
using System.Threading.Tasks;
using AkkaClient;

namespace Service
{
    public class Fridgeservice{

        private Client client;
        public Fridgeservice(){
            client = new Client("http://localhost:4200",new HttpClient());
        }

        public Task<System.Collections.Generic.ICollection<ProductDto>>  getInventory(){
            return client.GetFridgeInventoryAsync();
        }   

        public Task<ConsumeMessageDto> consumeProduct(ProductDto dto){
            return client.ConsumeProductAsync(dto);
        }
    }

}