#pragma checksum "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\Pages\ReviewIdea.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a3de349d2fa6aace4591436ea649cc3918d8fe3"
// <auto-generated/>
#pragma warning disable 1591
namespace InnovationBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using InnovationBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using InnovationBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReviewIdea")]
    public partial class ReviewIdea : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Review Ideas</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\Pages\ReviewIdea.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\Pages\ReviewIdea.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\cwolfsandle\source\repos\InnovationBlazor\InnovationBlazor\Pages\ReviewIdea.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
