#pragma checksum "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d755d30bb009a40d4efe9ca49569188f21bff3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using BlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using BlazorDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Blazorise.Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Blazorise.DataGrid.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\_Imports.razor"
using Blazorise.Icons.FontAwesome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
using BlazorDemo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.DataGrid.DataGrid<WeatherForecast>>(3);
            __builder.AddAttribute(4, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WeatherForecast>>(
#nullable restore
#line 16 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                         forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ShowPager", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                                                               5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridCommandColumn<WeatherForecast>>(11);
                __builder2.AddAttribute(12, "NewCommandTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Blazorise.DataGrid.CommandContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Blazorise.Button>(13);
                    __builder3.AddAttribute(14, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 19 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                     Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                              context.Clicked

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(17, "New");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<WeatherForecast>>(19);
                __builder2.AddAttribute(20, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                    nameof(WeatherForecast.Date)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Caption", "Date");
                __builder2.AddAttribute(22, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<WeatherForecast>>(24);
                __builder2.AddAttribute(25, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                    nameof(WeatherForecast.TemperatureC)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Caption", "Temp(C)");
                __builder2.AddAttribute(27, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<WeatherForecast>>(29);
                __builder2.AddAttribute(30, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                    nameof(WeatherForecast.TemperatureF)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Caption", "Temp(F)");
                __builder2.AddAttribute(32, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGridColumn<WeatherForecast>>(34);
                __builder2.AddAttribute(35, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                    nameof(WeatherForecast.Summary)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Caption", "Summary");
                __builder2.AddAttribute(37, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 28 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\BurakOzcelik\repositories\Blazorise\BlazorDemo\BlazorDemo\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
