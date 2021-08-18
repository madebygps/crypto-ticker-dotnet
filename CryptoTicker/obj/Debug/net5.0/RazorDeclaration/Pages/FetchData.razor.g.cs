// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CryptoTicker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using CryptoTicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using CryptoTicker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
       
  
    private Coin[] prices;
    bool disabled = false;
    private HubConnection hubConnection;
    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    protected override async Task OnInitializedAsync()
    {
        

        prices = await Http.GetFromJsonAsync<Coin[]>("http://localhost:7071/api/GetPricesJson");
        hubConnection = new HubConnectionBuilder().WithUrl("http://localhost:7071/api").Build();

        

        hubConnection.On<Coin[]>("updated", (coin) =>
            {

                prices = coin;
            
                StateHasChanged();


            }
                         
            );
   
        await hubConnection.StartAsync();
        
        // 

          
    }

     public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

    



    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
   

    public class Coin
    {
        public string id { get; set; }
        public string Symbol { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public double current_price { get; set; }
        public double market_cap { get; set; }
        public object total_volume { get; set; }
        public double price_change_percentage_24h { get; set; }
        public double market_cap_change_24h { get; set; }
        public double market_cap_change_percentage_24h { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
