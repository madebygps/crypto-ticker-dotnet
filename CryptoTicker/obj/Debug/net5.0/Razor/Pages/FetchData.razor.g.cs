#pragma checksum "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cca3b2dbcf1de11c2477a8eb48fd04a4225f9d26"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 8 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
 if (prices == null)
{
    
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudProgressLinear>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                              Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Class", "my-7");
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudContainer>(4);
            __builder.AddAttribute(5, "Class", "mt-16");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(7);
                __builder2.AddAttribute(8, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 18 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                   Typo.h3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 18 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                   Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, "$PRICES");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudText>(14);
                __builder2.AddAttribute(15, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 19 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                    Align.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "SignalR status: ");
                    __builder3.OpenComponent<MudBlazor.MudText>(18);
                    __builder3.AddAttribute(19, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 19 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                                  Align.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                                                         hubConnection.State.ToString() is "Connected" ? Color.Success : Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(22, 
#nullable restore
#line 19 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                                                                                                                                        hubConnection.State

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, " \r\n\r\n   \r\n    \r\n    \r\n    \r\n    ");
                __builder2.OpenComponent<MudBlazor.MudGrid>(24);
                __builder2.AddAttribute(25, "Class", "mt-8");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 26 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
         foreach(var coin in prices)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudItem>(27);
                    __builder3.AddAttribute(28, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                          12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                  6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                         4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(32);
                        __builder4.AddAttribute(33, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "Class", "rounded-lg pb-4");
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(36);
                            __builder5.AddAttribute(37, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(38);
                                __builder6.AddAttribute(39, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 34 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                       Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(40, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 34 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                       Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(42, 
#nullable restore
#line 34 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                                      coin.name

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(43, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudText>(44);
                                __builder6.AddAttribute(45, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 35 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                       Typo.body1

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 35 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                          Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(48, 
#nullable restore
#line 36 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                             coin.Symbol

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(49, "\r\n                \r\n  ");
                            __builder5.OpenComponent<MudBlazor.MudAvatar>(50);
                            __builder5.AddAttribute(51, "Image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                     coin.image

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(52, "Style", "display: block; margin-left: auto;\r\n  margin-right: auto;");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(53, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(54);
                            __builder5.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(56, "div");
                                __builder6.AddAttribute(57, "class", "d-flex justify-center");
                                __builder6.AddAttribute(58, "b-yhfvw8jw73");
                                __builder6.OpenComponent<MudBlazor.MudText>(59);
                                __builder6.AddAttribute(60, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 47 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                       Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(62, "$");
                                    __builder7.AddContent(63, 
#nullable restore
#line 47 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                  coin.current_price

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(64, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudText>(65);
                                __builder6.AddAttribute(66, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 48 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                       Typo.subtitle1

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(67, "Class", "ml-1 mt-5");
                                __builder6.AddAttribute(68, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 48 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                                                Color.Secondary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(70, "/Current Price");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(71, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudList>(72);
                                __builder6.AddAttribute(73, "Class", "mx-auto mt-4");
                                __builder6.AddAttribute(74, "Style", "width:300px;");
                                __builder6.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudListItem>(76);
                                    __builder7.AddAttribute(77, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                            Icons.Material.Filled.Analytics

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(79, 
#nullable restore
#line 52 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                             coin.market_cap.ToString("C")

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.AddMarkupContent(80, " USD\r\n                        ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(81, "\r\n                        ");
                                    __builder7.OpenComponent<MudBlazor.MudListItem>(82);
                                    __builder7.AddAttribute(83, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                             coin.price_change_percentage_24h > 0? @Icons.Material.Filled.ArrowUpward: @Icons.Material.Filled.ArrowDownward

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(84, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 54 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                                                                                                                                                                           coin.price_change_percentage_24h > 0? Color.Success: Color.Error

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(86, 
#nullable restore
#line 55 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
                             coin.price_change_percentage_24h

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.AddMarkupContent(87, "%\r\n                        ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 62 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.OpenComponent<MudBlazor.MudContainer>(88);
            __builder.AddAttribute(89, "Class", "mt-10");
            __builder.CloseComponent();
#nullable restore
#line 72 "C:\Users\gwyne\Developer\crypto-ticker-dotnet\CryptoTicker\Pages\FetchData.razor"





     
    
}

#line default
#line hidden
#nullable disable
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