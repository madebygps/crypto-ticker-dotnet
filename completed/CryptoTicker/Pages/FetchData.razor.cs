using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace CryptoTicker.Pages
{
    public class FetechDataBase : ComponentBase
    {
        protected Coin[] prices;
        [Inject]
        public HttpClient Http {get;set;}
    protected HubConnection hubConnection;
    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    protected override async Task OnInitializedAsync()
    {
        

        prices = await Http.GetFromJsonAsync<Coin[]>("https://cryptodatadotnet.azurewebsites.net/api/GetPricesJson");
        //prices = await Http.GetFromJsonAsync<Coin[]>("http://localhost:7071/api/GetPricesJson");
            
        hubConnection = new HubConnectionBuilder().WithUrl("https://cryptodatadotnet.azurewebsites.net/api").Build();

        hubConnection.On<Coin[]>("updated", (coin) =>
            {
            prices = coin;
                StateHasChanged();
            }                  
        );                                                                                          
   
        await hubConnection.StartAsync();
                 
    }

     public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }
    }
}