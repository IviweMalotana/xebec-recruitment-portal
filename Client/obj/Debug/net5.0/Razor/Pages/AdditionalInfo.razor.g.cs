#pragma checksum "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ada885b6ae9ff9295c3c86fc1274f4576242ad"
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
#line 1 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/additional")]
    public partial class AdditionalInfo : Microsoft.AspNetCore.Components.ComponentBase
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
            <div class=""progress-img""><i class=""fa fa-briefcase material-none""></i></div>
            <div class=""progress-line""></div>
            <div class=""progress-img""><i class=""fa fa-laptop material-color""></i></div></div>
        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-div");
            __builder.AddMarkupContent(12, "<h1>Additional Information</h1>\r\n            ");
            __builder.OpenElement(13, "form");
            __builder.AddAttribute(14, "class", "main-form");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group form-check-inline form-group-first");
            __builder.AddMarkupContent(17, "<i class=\"fa fa-github mr-2\" style=\"color: black;\"></i>\r\n                    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control form-control-style");
            __builder.AddAttribute(21, "id", "github");
            __builder.AddAttribute(22, "placeholder", "Github Link");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 280 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                                                                                                            AdditionalInformation.GitHubLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AdditionalInformation.GitHubLink = __value, AdditionalInformation.GitHubLink));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"github-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group form-check-inline form-group-others");
            __builder.AddMarkupContent(29, "<i class=\"fa fa-facebook mr-2\" style=\"color: #4267B2;\"></i>\r\n                    ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "form-control form-control-style");
            __builder.AddAttribute(33, "id", "facebook");
            __builder.AddAttribute(34, "placeholder", "Facebook");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 285 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                                                                                                           AdditionalInformation.FacebookLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AdditionalInformation.FacebookLink = __value, AdditionalInformation.FacebookLink));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"facebook-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "<br>\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group form-check-inline form-group-others");
            __builder.AddMarkupContent(41, "<i class=\"fa fa-linkedin mr-2\" style=\"color:#0077b5\"></i>\r\n                    ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "class", "form-control form-control-style");
            __builder.AddAttribute(45, "id", "linkedin");
            __builder.AddAttribute(46, "placeholder", "LinkedIn");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 291 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                                                                                                           AdditionalInformation.LinkedInLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AdditionalInformation.LinkedInLink = __value, AdditionalInformation.LinkedInLink));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"linkedin-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group form-check-inline form-group-others");
            __builder.AddMarkupContent(53, "<i class=\"fa fa-globe mr-1\" style=\"color:orange;\"></i>\r\n                    ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control form-control-style");
            __builder.AddAttribute(57, "id", "website");
            __builder.AddAttribute(58, "placeholder", "Website");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 296 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                                                                                                         AdditionalInformation.PersonalWebsiteUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AdditionalInformation.PersonalWebsiteUrl = __value, AdditionalInformation.PersonalWebsiteUrl));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"website-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "<br>\r\n\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group form-check-inline form-group-text-area");
            __builder.OpenComponent<BlazorInputFile.InputFile>(65);
            __builder.AddAttribute(66, "class", "dropzone");
            __builder.AddAttribute(67, "style", "border: none;");
            __builder.AddAttribute(68, "id", "fileInput");
            __builder.AddAttribute(69, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 303 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                                                                                               OnInputFileChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(70, "accept", "image/png,image/gif,image/jpeg,application/pdf,application/msword");
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n\r\n                    <input type=\"checkbox\" class=\"form-check-input\" style=\"margin-left: 5%;\" id=\"job-description-check\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "<br>\r\n                ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "form-group form-check-inline form-group-others");
#nullable restore
#line 308 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                     if (selectedFiles != null && selectedFiles.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "drop-zone-button-div");
            __builder.OpenElement(77, "ul");
#nullable restore
#line 312 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                 foreach (var file in selectedFiles)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "li");
            __builder.AddContent(79, 
#nullable restore
#line 315 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                         file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(80, "\r\n                                        ");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "class", "drop-zone-button");
            __builder.AddAttribute(83, "type", "button");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 316 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                                                                                   e => RemoveFile(file)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Remove");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 318 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 321 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.AddMarkupContent(87, "<div class=\"add-button-div\"><button type=\"submit\" class=\"add-button\">Add</button></div><br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "form");
            __builder.AddAttribute(90, "class", "div-buttons");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(91);
            __builder.AddAttribute(92, "class", "buttondivs");
            __builder.AddAttribute(93, "href", "/");
            __builder.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(95, "<div class=\"btn-previous\"><h2 class=\"nav-item\">Previous</h2></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(97);
            __builder.AddAttribute(98, "class", "buttondivs");
            __builder.AddAttribute(99, "href", "/");
            __builder.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(101, "<div class=\"btn-next\"><h2 class=\"nav-item\">Submit</h2></div>");
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
#line 343 "C:\Users\Iviwe\Source\Repos\xebec-recruitment-portal\Client\Pages\AdditionalInfo.razor"
      

    private string dropClass = "";
    private bool fileTypeError = false;
    private List<IFileListEntry> selectedFiles = new List<IFileListEntry>();

    /*private void HandleDragEnter()
    {
        dropClass = "dropzone-drag";
    }

    private void HandleDragLeave()
    {
        dropClass = "";
    }*/

    private async Task OnInputFileChange(IFileListEntry[] files)
    {
        dropClass = "";
        fileTypeError = false;
        List<string> acceptedFileTypes = new List<string>() { "image/png", "image/jpeg", "image/gif", "application/pdf", "application/msword" };
        if (files != null)
        {
            foreach (var file in files)
            {
                bool error = false;

                if (!acceptedFileTypes.Contains(file.Type))
                {
                    error = true;
                    fileTypeError = true;
                }

                //keep the good files
                if (!error)
                {
                    selectedFiles.Add(file);
                }
            }
        }
        await base.OnInitializedAsync();
    }

    private void RemoveFile(IFileListEntry file)
    {
        selectedFiles.Remove(file);
    }

    public AdditionalInformation AdditionalInformation { get; set; } = new AdditionalInformation();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<AdditionalInfo> Logger { get; set; }
    }
}
#pragma warning restore 1591
