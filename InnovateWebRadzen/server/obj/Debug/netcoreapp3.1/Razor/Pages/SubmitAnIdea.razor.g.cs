#pragma checksum "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a3a3433ae00a3f03afb2e9c2c4be90026709d7"
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
#line 5 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
using InnovationWebApp.Models.InnovateDb;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/submit-an-idea")]
    public partial class SubmitAnIdea : InnovationWebApp.Pages.SubmitAnIdeaComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<InnovationWebApp.Models.InnovateDb.Idea>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<InnovationWebApp.Models.InnovateDb.Idea>(
#line 12 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                   idea

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                    idea != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<InnovationWebApp.Models.InnovateDb.Idea>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<InnovationWebApp.Models.InnovateDb.Idea>(this, 
#line 12 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                                            Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(16);
                    __builder3.AddAttribute(17, "Size", "H1");
                    __builder3.AddAttribute(18, "Text", "Submit An Idea");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\n            ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(22, "class", "row");
                    __builder3.AddMarkupContent(23, "\n              ");
                    __builder3.OpenElement(24, "div");
                    __builder3.AddAttribute(25, "class", "col-md-3");
                    __builder3.AddMarkupContent(26, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(27);
                    __builder3.AddAttribute(28, "Component", "firstName");
                    __builder3.AddAttribute(29, "style", "width: 100%");
                    __builder3.AddAttribute(30, "Text", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\n              ");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "col-md-9");
                    __builder3.AddMarkupContent(35, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(36);
                    __builder3.AddAttribute(37, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 22 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                          16777215

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(38, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(39, "Name", "FirstName");
                    __builder3.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 22 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                       idea.firstName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idea.firstName = __value, idea.firstName))));
                    __builder3.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => idea.firstName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(44);
                    __builder3.AddAttribute(45, "Component", "FirstName");
                    __builder3.AddAttribute(46, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                      false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(47, "style", "position: absolute");
                    __builder3.AddAttribute(48, "Text", "firstName is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(54, "class", "row");
                    __builder3.AddMarkupContent(55, "\n              ");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "col-md-3");
                    __builder3.AddMarkupContent(58, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(59);
                    __builder3.AddAttribute(60, "Component", "lastName");
                    __builder3.AddAttribute(61, "style", "width: 100%");
                    __builder3.AddAttribute(62, "Text", "Last Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n              ");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "col-md-9");
                    __builder3.AddMarkupContent(67, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(68);
                    __builder3.AddAttribute(69, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 34 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                          16777215

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(70, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(71, "Name", "LastName");
                    __builder3.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 34 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                       idea.lastName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idea.lastName = __value, idea.lastName))));
                    __builder3.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => idea.lastName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(76);
                    __builder3.AddAttribute(77, "Component", "LastName");
                    __builder3.AddAttribute(78, "style", "position: absolute");
                    __builder3.AddAttribute(79, "Text", "lastName is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(85, "class", "row");
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "class", "col-md-3");
                    __builder3.AddMarkupContent(89, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(90);
                    __builder3.AddAttribute(91, "Component", "email");
                    __builder3.AddAttribute(92, "style", "width: 100%");
                    __builder3.AddAttribute(93, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n              ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "col-md-9");
                    __builder3.AddMarkupContent(98, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(99);
                    __builder3.AddAttribute(100, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 46 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                          16777215

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(101, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(102, "Name", "Email");
                    __builder3.AddAttribute(103, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 46 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                       idea.email

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(104, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idea.email = __value, idea.email))));
                    __builder3.AddAttribute(105, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => idea.email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenEmailValidator>(107);
                    __builder3.AddAttribute(108, "Component", "Email");
                    __builder3.AddAttribute(109, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 48 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                               true

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(110, "style", "display: block; float: none; font-weight: bold; position: absolute; vertical-align: baseline; z-index: 100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(112);
                    __builder3.AddAttribute(113, "Component", "Email");
                    __builder3.AddAttribute(114, "Popup", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 50 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(115, "style", "position: absolute");
                    __builder3.AddAttribute(116, "Text", "email is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(122, "class", "row");
                    __builder3.AddMarkupContent(123, "\n              ");
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "col-md-3");
                    __builder3.AddMarkupContent(126, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(127);
                    __builder3.AddAttribute(128, "Component", "business");
                    __builder3.AddAttribute(129, "style", "width: 100%");
                    __builder3.AddAttribute(130, "Text", "Business");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(131, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.OpenElement(133, "div");
                    __builder3.AddAttribute(134, "class", "col-md-9");
                    __builder3.AddMarkupContent(135, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(136);
                    __builder3.AddAttribute(137, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 60 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                          16777215

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(138, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(139, "Name", "Business");
                    __builder3.AddAttribute(140, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 60 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                       idea.business

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(141, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idea.business = __value, idea.business))));
                    __builder3.AddAttribute(142, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => idea.business));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(143, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(144);
                    __builder3.AddAttribute(145, "Component", "Business");
                    __builder3.AddAttribute(146, "style", "position: absolute");
                    __builder3.AddAttribute(147, "Text", "business is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(148, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(149, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(150, "\n            ");
                    __builder3.OpenElement(151, "div");
                    __builder3.AddAttribute(152, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(153, "class", "row");
                    __builder3.AddMarkupContent(154, "\n              ");
                    __builder3.OpenElement(155, "div");
                    __builder3.AddAttribute(156, "class", "col-md-3");
                    __builder3.AddMarkupContent(157, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(158);
                    __builder3.AddAttribute(159, "Component", "office");
                    __builder3.AddAttribute(160, "style", "width: 100%");
                    __builder3.AddAttribute(161, "Text", "Office");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(162, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(163, "\n              ");
                    __builder3.OpenElement(164, "div");
                    __builder3.AddAttribute(165, "class", "col-md-9");
                    __builder3.AddMarkupContent(166, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(167);
                    __builder3.AddAttribute(168, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 72 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                          16777215

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(169, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(170, "Name", "Office");
                    __builder3.AddAttribute(171, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 72 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                       idea.office

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(172, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idea.office = __value, idea.office))));
                    __builder3.AddAttribute(173, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => idea.office));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(174, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(175);
                    __builder3.AddAttribute(176, "Component", "Office");
                    __builder3.AddAttribute(177, "style", "position: absolute");
                    __builder3.AddAttribute(178, "Text", "office is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(179, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(180, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(181, "\n            ");
                    __builder3.OpenElement(182, "div");
                    __builder3.AddAttribute(183, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(184, "class", "row");
                    __builder3.AddMarkupContent(185, "\n              ");
                    __builder3.OpenElement(186, "div");
                    __builder3.AddAttribute(187, "class", "col-md-3");
                    __builder3.AddMarkupContent(188, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(189);
                    __builder3.AddAttribute(190, "Component", "ideaDescription");
                    __builder3.AddAttribute(191, "style", "width: 100%");
                    __builder3.AddAttribute(192, "Text", "Idea Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(193, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(194, "\n              ");
                    __builder3.OpenElement(195, "div");
                    __builder3.AddAttribute(196, "class", "col-md-9");
                    __builder3.AddMarkupContent(197, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(198);
                    __builder3.AddAttribute(199, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 84 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                          16777215

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(200, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(201, "Name", "IdeaDescription");
                    __builder3.AddAttribute(202, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 84 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                       idea.ideaDescription

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(203, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idea.ideaDescription = __value, idea.ideaDescription))));
                    __builder3.AddAttribute(204, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => idea.ideaDescription));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(205, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(206);
                    __builder3.AddAttribute(207, "Component", "IdeaDescription");
                    __builder3.AddAttribute(208, "style", "position: absolute");
                    __builder3.AddAttribute(209, "Text", "ideaDescription is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(210, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(211, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(212, "\n            ");
                    __builder3.OpenElement(213, "div");
                    __builder3.AddAttribute(214, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(215, "class", "row");
                    __builder3.AddMarkupContent(216, "\n              ");
                    __builder3.OpenElement(217, "div");
                    __builder3.AddAttribute(218, "class", "col-md-3");
                    __builder3.AddMarkupContent(219, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(220);
                    __builder3.AddAttribute(221, "Component", "scope");
                    __builder3.AddAttribute(222, "style", "width: 100%");
                    __builder3.AddAttribute(223, "Text", "Scope");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(224, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(225, "\n              ");
                    __builder3.OpenElement(226, "div");
                    __builder3.AddAttribute(227, "class", "col-md-9");
                    __builder3.AddMarkupContent(228, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(229);
                    __builder3.AddAttribute(230, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#line 96 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                          16777215

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(231, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(232, "Name", "Scope");
                    __builder3.AddAttribute(233, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 96 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                       idea.scope

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(234, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idea.scope = __value, idea.scope))));
                    __builder3.AddAttribute(235, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => idea.scope));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(236, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(237);
                    __builder3.AddAttribute(238, "Component", "Scope");
                    __builder3.AddAttribute(239, "style", "position: absolute");
                    __builder3.AddAttribute(240, "Text", "scope is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(241, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(242, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(243, "\n            ");
                    __builder3.OpenElement(244, "div");
                    __builder3.AddAttribute(245, "class", "row");
                    __builder3.AddMarkupContent(246, "\n              ");
                    __builder3.OpenElement(247, "div");
                    __builder3.AddAttribute(248, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(249, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(250);
                    __builder3.AddAttribute(251, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 104 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(252, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 104 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(253, "Icon", "save");
                    __builder3.AddAttribute(254, "Text", "Save");
                    __builder3.AddAttribute(255, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 104 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                                               Button1Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(256, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(257);
                    __builder3.AddAttribute(258, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 106 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(259, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 106 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                          ButtonType.Button

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(260, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(261, "Text", "Cancel");
                    __builder3.AddAttribute(262, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 106 "C:\Users\cwolfsandle\source\repos\InnovateWebRadzen\server\Pages\SubmitAnIdea.razor"
                                                                                                                                             Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(263, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(264, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(265, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(266, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(267, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(268, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591