#pragma checksum "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\Pages\Welcome.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0203f37842d3b44357faf2c0fe086758ec09ce7"
// <auto-generated/>
#pragma warning disable 1591
namespace InnovationWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using InnovationWebApp;

#line default
#line hidden
#line 9 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\_Imports.razor"
using InnovationWebApp.Shared;

#line default
#line hidden
#line 6 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\Pages\Welcome.razor"
using Radzen;

#line default
#line hidden
#line 7 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\Pages\Welcome.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 8 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\InnovateWebRadzen\server\Pages\Welcome.razor"
using InnovationWebApp.Models.InnovateDb;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/welcome")]
    public partial class Welcome : InnovationWebApp.Pages.WelcomeComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Welcome");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenImage>(8);
                __builder2.AddAttribute(9, "Path", "assets/images/Ledcor_Project_Intro.jpg");
                __builder2.AddAttribute(10, "style", "width: 100%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.AddMarkupContent(12, "<div class=\"row\">\n\n        </div>\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
