#pragma checksum "C:\Users\me\source\repos\This\Client\Shared\EducationForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a784f3f171fe99b7f6c06afdf334b20707bcc73"
// <auto-generated/>
#pragma warning disable 1591
namespace XebecPortal.Client.Shared
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
#line 14 "C:\Users\me\source\repos\This\Client\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\me\source\repos\This\Client\Shared\EducationForm.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/education-form")]
    public partial class EducationForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .wrapper {\r\n        height: 100vh;\r\n        width: 100%;\r\n    }\r\n\r\n    .nav {\r\n        height: 10vh;\r\n        background-color: lightgrey;\r\n        width: 100%;\r\n    }\r\n\r\n    .main-body {\r\n        height: 90vh;\r\n        width: 100%;\r\n    }\r\n\r\n    .progress-div {\r\n        margin-top: 2.5%;\r\n        height: 10%;\r\n        margin-bottom: 2.5%;\r\n        width: 60%;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n        display: flex;\r\n    }\r\n\r\n    .progress-img {\r\n        height: 100%;\r\n        width: 10%;\r\n        text-align: center;\r\n    }\r\n\r\n    .progress-line {\r\n        height: 100%;\r\n        width: 20%;\r\n        text-align: center;\r\n    }\r\n\r\n    .form-div {\r\n        height: auto;\r\n        margin-bottom: 5%;\r\n        width: 60%;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n        \r\n    }\r\n\r\n    .main-form {\r\n        height: 83.5%;\r\n        width: 80%;\r\n        margin-left: 10%;\r\n        margin-right: 10%;\r\n        margin-top: 2.5%;\r\n        background-color: lightgrey;\r\n        border: black 1px solid;\r\n    }\r\n\r\n    .div-buttons {\r\n        margin-top: 1%;\r\n        height: 10%;\r\n        display: flex;\r\n        align-content: center;\r\n        text-align: center;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n        width: 60%;\r\n    }\r\n\r\n    .form-group-first {\r\n        margin-top: 5%;\r\n        width: 40%;\r\n        margin-left: 5%;\r\n        margin-right: 2.5%;\r\n    }\r\n\r\n    .form-group-others {\r\n        width: 40%;\r\n        margin-left: 5%;\r\n        margin-right: 2.5%;\r\n    }\r\n\r\n    .form-group-text-area {\r\n        width: 70%;\r\n        margin-left: 15%;\r\n        margin-right: 15%;\r\n    }\r\n\r\n    .form-control-style {\r\n        border: 2px darkgrey solid;\r\n    }\r\n\r\n    .form-control-text-area {\r\n        border: 2px darkgrey solid;\r\n        height: 400px;\r\n        width: 100%;\r\n    }\r\n\r\n    .btn-previous {\r\n        height: 100%;\r\n        width: 60%;\r\n        margin-left: 30%;\r\n        margin-right: 10%;\r\n        background-color: #22577A;\r\n        border: transparent;\r\n        border-radius: 10px;\r\n    }\r\n\r\n    .btn-next {\r\n        height: 100%;\r\n        width: 60%;\r\n        margin-left: 10%;\r\n        margin-right: 30%;\r\n        background-color: #0B8457;\r\n        border: transparent;\r\n        border-radius: 10px;\r\n    }\r\n\r\n    .buttondivs {\r\n        height: 80%;\r\n        width: 50%;\r\n        margin-bottom: 20%;\r\n        border: none;\r\n        color: white;\r\n    }\r\n\r\n        .buttondivs:hover {\r\n            text-decoration: none;\r\n        }\r\n\r\n    .add-button-div {\r\n        height: 10%;\r\n        width: 40%;\r\n        margin-left: 30%;\r\n        margin-right: 30%;\r\n        border: none;\r\n        display: flex;\r\n    }\r\n\r\n    .add-button {\r\n        width: 80px;\r\n        margin-left: 35%;\r\n        margin-right: 35%;\r\n        height: 100%;\r\n        border: transparent;\r\n        border-radius: 10px;\r\n        background-color: #28ABB9;\r\n        color: white;\r\n    }\r\n\r\n    h1 {\r\n        font-family: SigmarOne;\r\n        font-size: 30px;\r\n        text-align: center;\r\n    }\r\n\r\n    .material-icon {\r\n        font-size: 50px;\r\n        text-align: center;\r\n        margin: 0;\r\n    }\r\n\r\n    .material-line {\r\n        font-size: 50px;\r\n        display: inline-block;\r\n        width: 100%;\r\n        text-align: center;\r\n        margin: 0;\r\n        height: 100%;\r\n        background-color: maroon;\r\n    }\r\n\r\n    .no-material-line {\r\n        font-size: 50px;\r\n        display: inline-block;\r\n        width: 100%;\r\n        text-align: center;\r\n        margin: 0;\r\n        background-color: white;\r\n    }\r\n\r\n    .material-color {\r\n        font-size: 50px;\r\n        text-align: center;\r\n        margin: 0;\r\n        color: purple;\r\n    }\r\n\r\n    .material-none {\r\n        font-size: 50px;\r\n        text-align: center;\r\n        margin: 0;\r\n    }\r\n\r\n    .no-form-icon {\r\n        color: lightgrey;\r\n    }\r\n\r\n    .form-icon {\r\n        color: black;\r\n    }\r\n\r\n    .labels-div {\r\n        width: 90%;\r\n        margin-left: 5%;\r\n        margin-right: 5%;\r\n        margin-top: 5px;\r\n        display: flex;\r\n        height: 30px;\r\n    }\r\n\r\n    label {\r\n        margin-top: 5px;\r\n        color: black;\r\n        font-family: Calibri;\r\n        font-size: 15px;\r\n    }\r\n\r\n    .mini-label1 {\r\n        width: 40%;\r\n        display: inline-block;\r\n        margin-right: 9%;\r\n        margin-left: 1%;\r\n    }\r\n\r\n    .mini-label2 {\r\n        display: inline-block;\r\n        width: 40%;\r\n        margin-left: 4.5%;\r\n    }\r\n\r\n    h2 {\r\n        text-decoration: none;\r\n        font-family: Arial;\r\n        font-size: 20px;\r\n    }\r\n\r\n    h3 {\r\n        font-family: SigmarOne;\r\n        font-size: 20px;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "class", "main-form");
            __builder.AddMarkupContent(3, "<div class=\"form-check-inline form-group-first\"><h3>Education</h3></div><br>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-check-inline form-group-others");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "id", "institution");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control form-control-style");
            __builder.AddAttribute(10, "placeholder", "Insitution");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 256 "C:\Users\me\source\repos\This\Client\Shared\EducationForm.razor"
                                                                                           Education.Insitution

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Education.Insitution = __value, Education.Insitution));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"institution-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-check-inline form-group-others");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "id", "qualification");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control form-control-style");
            __builder.AddAttribute(21, "placeholder", "Qualification");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 260 "C:\Users\me\source\repos\This\Client\Shared\EducationForm.razor"
                                                                                             Education.Qualification

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Education.Qualification = __value, Education.Qualification));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"qualification-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "<br>\r\n    ");
            __builder.AddMarkupContent(26, "<div class=\"form-check-inline labels-div\"><div class=\"mini-label1\"><label>Start Date</label></div>\r\n        <div class=\"mini-label2\"><label>End Date</label></div></div>\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group form-check-inline form-group-others");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "id", "eduend");
            __builder.AddAttribute(31, "type", "date");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "placeholder", "First Name");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 272 "C:\Users\me\source\repos\This\Client\Shared\EducationForm.razor"
                                                                  Education.StartDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Education.StartDate = __value, Education.StartDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"qualification-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group form-check-inline form-group-others");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "date");
            __builder.AddAttribute(42, "id", "edusend");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "placeholder", "Last Name");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 276 "C:\Users\me\source\repos\This\Client\Shared\EducationForm.razor"
                                                                    Education.EndDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Education.EndDate = __value, Education.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"qualification-check\">");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 281 "C:\Users\me\source\repos\This\Client\Shared\EducationForm.razor"
      
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        Education.StartDate = DateTime.Now;
        Education.EndDate = DateTime.Now;
    }
    public Education Education { get; set; } = new Education();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<WorkHistoryForm> Logger { get; set; }
    }
}
#pragma warning restore 1591
