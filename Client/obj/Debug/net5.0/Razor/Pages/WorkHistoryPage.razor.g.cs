#pragma checksum "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9bf8378dfd4d6ae76a35b37322df7f9e160ba55"
// <auto-generated/>
#pragma warning disable 1591
namespace XebecPortal.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using XebecPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using XebecPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using XebecPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using XebecPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
using XebecPortal.Client.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/work-history")]
    public partial class WorkHistoryPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .wrapper {\r\n        height: 100vh;\r\n        width: 100%;\r\n    }\r\n\r\n    .nav {\r\n        height: 10vh;\r\n        background-color: lightgrey;\r\n        width: 100%;\r\n        display: flex;\r\n    }\r\n\r\n    .main-body {\r\n        height: 90vh;\r\n        width: 100%;\r\n    }\r\n\r\n    .progress-div {\r\n        margin-top: 2.5%;\r\n        height: 10%;\r\n        margin-bottom: 2.5%;\r\n        width: 60%;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n        display: flex;\r\n    }\r\n\r\n    .progress-img {\r\n        height: 100%;\r\n        width: 10%;\r\n        text-align: center;\r\n    }\r\n\r\n    .progress-line {\r\n        height: 100%;\r\n        width: 20%;\r\n        text-align: center;\r\n    }\r\n\r\n    .form-div {\r\n        height: auto;\r\n        margin-bottom: 5%;\r\n        width: 60%;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n    }\r\n\r\n    .main-form {\r\n        height: 83.5%;\r\n        width: 80%;\r\n        margin-left: 10%;\r\n        margin-right: 10%;\r\n        margin-top: 2.5%;\r\n        background-color: lightgrey;\r\n        border: black 1px solid;\r\n    }\r\n\r\n    .div-buttons {\r\n        margin-top: 1%;\r\n        height: 10%;\r\n        display: flex;\r\n        align-content: center;\r\n        text-align: center;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n        width: 60%;\r\n    }\r\n\r\n    .form-group-first {\r\n        margin-top: 5%;\r\n        width: 40%;\r\n        margin-left: 5%;\r\n        margin-right: 2.5%;\r\n    }\r\n\r\n    .form-group-others {\r\n        width: 40%;\r\n        margin-left: 5%;\r\n        margin-right: 2.5%;\r\n    }\r\n\r\n    .form-group-text-area {\r\n        width: 70%;\r\n        margin-left: 15%;\r\n        margin-right: 15%;\r\n    }\r\n\r\n    .form-control-style {\r\n        border: 2px darkgrey solid;\r\n    }\r\n\r\n    .form-control-text-area {\r\n        border: 2px darkgrey solid;\r\n        height: 400px;\r\n        width: 100%;\r\n    }\r\n\r\n    .btn-previous {\r\n        height: 100%;\r\n        width: 60%;\r\n        margin-left: 30%;\r\n        margin-right: 10%;\r\n        background-color: #22577A;\r\n        border: transparent;\r\n        border-radius: 10px;\r\n    }\r\n\r\n    .btn-next {\r\n        height: 100%;\r\n        width: 60%;\r\n        margin-left: 10%;\r\n        margin-right: 30%;\r\n        background-color: #0B8457;\r\n        border: transparent;\r\n        border-radius: 10px;\r\n    }\r\n\r\n    .buttondivs {\r\n        height: 80%;\r\n        width: 50%;\r\n        margin-bottom: 20%;\r\n        border: none;\r\n        color: white;\r\n    }\r\n\r\n        .buttondivs:hover {\r\n            text-decoration: none;\r\n        }\r\n\r\n    .add-button-div {\r\n        height: 10%;\r\n        width: 40%;\r\n        margin-left: 30%;\r\n        margin-right: 30%;\r\n        border: none;\r\n        display: flex;\r\n    }\r\n\r\n    .add-button {\r\n        width: 80px;\r\n        margin-left: 35%;\r\n        margin-right: 35%;\r\n        height: 100%;\r\n        border: transparent;\r\n        border-radius: 10px;\r\n        background-color: #28ABB9;\r\n        color: white;\r\n    }\r\n\r\n    h1 {\r\n        font-family: SigmarOne;\r\n        font-size: 30px;\r\n        text-align: center;\r\n    }\r\n\r\n    .material-icon {\r\n        font-size: 50px;\r\n        text-align: center;\r\n        margin: 0;\r\n    }\r\n\r\n    .material-line {\r\n        font-size: 50px;\r\n        display: inline-block;\r\n        width: 100%;\r\n        text-align: center;\r\n        margin: 0;\r\n        height: 100%;\r\n        background-color: maroon;\r\n    }\r\n\r\n    .no-material-line {\r\n        font-size: 50px;\r\n        display: inline-block;\r\n        width: 100%;\r\n        text-align: center;\r\n        margin: 0;\r\n        background-color: white;\r\n    }\r\n\r\n    .material-color {\r\n        font-size: 50px;\r\n        text-align: center;\r\n        margin: 0;\r\n        color: purple;\r\n    }\r\n\r\n    .material-none {\r\n        font-size: 50px;\r\n        text-align: center;\r\n        margin: 0;\r\n    }\r\n\r\n    .no-form-icon {\r\n        color: lightgrey;\r\n    }\r\n\r\n    .form-icon {\r\n        color: black;\r\n    }\r\n\r\n    .labels-div {\r\n        width: 90%;\r\n        margin-left: 5%;\r\n        margin-right: 5%;\r\n        margin-top: 5px;\r\n        display: flex;\r\n        height: 30px;\r\n    }\r\n\r\n    label {\r\n        margin-top: 5px;\r\n        color: black;\r\n        font-family: Calibri;\r\n        font-size: 15px;\r\n    }\r\n\r\n    .mini-label1 {\r\n        width: 40%;\r\n        display: inline-block;\r\n        margin-right: 9%;\r\n        margin-left: 1%;\r\n    }\r\n\r\n    .mini-label2 {\r\n        display: inline-block;\r\n        width: 40%;\r\n        margin-left: 4.5%;\r\n    }\r\n\r\n    h2 {\r\n        text-decoration: none;\r\n        font-family: Arial;\r\n        font-size: 20px;\r\n    }\r\n\r\n    h3 {\r\n        font-family: SigmarOne;\r\n        font-size: 20px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "wrapper");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "nav");
            __builder.OpenComponent<XebecPortal.Client.Shared.NavMenu>(5);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "main-body");
            __builder.AddMarkupContent(9, @"<div class=""progress-div""><div class=""progress-img""><i class=""fa fa-user-circle material-none""></i></div>
            <div class=""progress-line""></div>
            <div class=""progress-img""><i class=""fa fa-graduation-cap material-none""></i></div>
            <div class=""progress-line""></div>
            <div class=""progress-img""><i class=""fa fa-briefcase material-color""></i></div>
            <div class=""progress-line""></div>
            <div class=""progress-img""><i class=""fa fa-laptop material-none""></i></div></div>
        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-div");
            __builder.AddMarkupContent(12, "<h1>Work History</h1>\r\n\r\n            ");
            __builder.OpenComponent<XebecPortal.Client.Shared.WorkHistoryForm>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "add-button-div");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "add-button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 283 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
                                                     addNewDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "<br>");
#nullable restore
#line 286 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
            for (int i=0;i<forms.Count;++i) 
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, 
#nullable restore
#line 288 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
                 forms[i]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 288 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
                         ;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "add-button-div");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "add-button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 290 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
                                                         addNewDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "add-button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 291 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
                                                         (()=>removeDiv(i-1))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Remove");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "<br>");
#nullable restore
#line 293 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
                       
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "form");
            __builder.AddAttribute(36, "class", "div-buttons");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "buttondivs");
            __builder.AddAttribute(39, "href", "/educational");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "<div class=\"btn-previous\"><h2 class=\"nav-item\">Previous</h2></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "buttondivs");
            __builder.AddAttribute(45, "href", "/additional");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<div class=\"btn-next\"><h2 class=\"nav-item\">Next</h2></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 314 "C:\Users\me\source\repos\This\Client\Pages\WorkHistoryPage.razor"
      

     private async Task OnAfterRenderAsync()

     {
         await JS.InvokeVoidAsync("addDiv");
     }

    List<RenderFragment> forms = new List<RenderFragment>();

    private const string WorkHistoryFormstr = "<WorkHistoryForm />";
    public WorkHistoryForm WorkHistoryForm = null;
    private void addNewDiv() {

        forms.Add(
            new RenderFragment(builder =>
            {
                builder.OpenComponent<WorkHistoryForm>(0);
                builder.AddComponentReferenceCapture(0, inst => { WorkHistoryForm = (WorkHistoryForm)inst; });
                builder.CloseComponent();
            })
        );
    }
    private void removeDiv(int index) {

        if (index<forms.Count)
        {
            forms.RemoveAt(index);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<WorkHistoryPage> Logger { get; set; }
    }
}
#pragma warning restore 1591
