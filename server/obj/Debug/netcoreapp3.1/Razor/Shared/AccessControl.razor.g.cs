#pragma checksum "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\Shared\AccessControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a3240b3cdc4b599828640ef60eee34a629004c6"
// <auto-generated/>
#pragma warning disable 1591
namespace InnovationWebApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using InnovationWebApp;

#line default
#line hidden
#line 9 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using InnovationWebApp.Shared;

#line default
#line hidden
#line 10 "C:\Users\cwolfsandle\source\repos\InnovationWebApp\server\_Imports.razor"
using Radzen;

#line default
#line hidden
    public partial class AccessControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "        \r\n        ");
                __builder2.AddMarkupContent(3, "<a href=\"logout\">Log out</a>\r\n    ");
            }
            ));
            __builder.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, "<a href=\"login?redirectUri=/\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
