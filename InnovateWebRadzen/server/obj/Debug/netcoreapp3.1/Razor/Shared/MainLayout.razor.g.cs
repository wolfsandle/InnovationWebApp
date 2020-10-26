#pragma checksum "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e399f93936b099e54b8134a5017e3abacc5680ba"
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
#line 1 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\_Imports.razor"
using InnovationWebApp.Shared;

#line default
#line hidden
#line 3 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor"
using InnovationWebApp.Models.InnovateDb;

#line default
#line hidden
    public partial class MainLayout : InnovationWebApp.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(13, "\n      ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(17);
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#line 15 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenImage>(20);
                __builder2.AddAttribute(21, "Path", "assets/images/ledcor.png");
                __builder2.AddAttribute(22, "style", "float: none; text-align: right; vertical-align: middle; width: 50px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(24);
                __builder2.AddAttribute(25, "style", "font-size: 24px; font-style: oblique; font-weight: bold; padding-left: 17px");
                __builder2.AddAttribute(26, "Text", "Innovation Web App");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n      ");
                __builder2.AddMarkupContent(29, "<div class=\"col-md-6 text-lg-right\">\n      </div>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(32);
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(35);
                __builder2.AddAttribute(36, "Name", "main");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\n    ");
                    __builder3.AddContent(39, 
#line 30 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(40, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(42, (__value) => {
#line 27 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(44);
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(47);
                __builder2.AddAttribute(48, "style", "height: 100%");
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(51);
                    __builder3.AddAttribute(52, "Icon", "language");
                    __builder3.AddAttribute(53, "Path", "welcome");
                    __builder3.AddAttribute(54, "Text", "Welcome");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(56);
                    __builder3.AddAttribute(57, "Icon", "build");
                    __builder3.AddAttribute(58, "Path", "submit-an-idea");
                    __builder3.AddAttribute(59, "Text", "Submit An Idea");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(61);
                    __builder3.AddAttribute(62, "Icon", "zoom_in");
                    __builder3.AddAttribute(63, "Path", "review-ideas");
                    __builder3.AddAttribute(64, "Text", "Review Ideas");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(66);
                    __builder3.AddAttribute(67, "Icon", "thumb_up");
                    __builder3.AddAttribute(68, "Path", "vote-for-ideas");
                    __builder3.AddAttribute(69, "Text", "Vote For Ideas");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(72, (__value) => {
#line 34 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(74);
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(77);
                __builder2.AddAttribute(78, "Text", "CW, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591