#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "586a79ee6dfdc9ddcb5af821b25ff9d6cd63c3f8"
// <auto-generated/>
#pragma warning disable 1591
namespace XebecPortal.Client.JobPortalTestEnv.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using XebecPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using XebecPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\_Imports.razor"
using XebecPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addjobpost")]
    public partial class AddJobPostTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>@import url(\'https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800&display=swap\');\r\n\r\n    *\r\n    {\r\n        font-family: \'Montserrat\', sans-serif;\r\n    }\r\n\r\n    .wrapper-job {\r\n        width: 100%;\r\n        height: 100vh;\r\n        display: flex;\r\n        flex-direction: column;        \r\n       justify-content: center;\r\n       align-items: center;\r\n       background-color: #d8e2dc;\r\n    }\r\n\r\n    .add-job-container {\r\n        padding: 20px;\r\n        width: 90%;\r\n        max-width: 600px;\r\n        margin: auto;\r\n        height: 90%;\r\n        max-height: 500px;\r\n        display: flex;\r\n        justify-content: space-evenly;\r\n        align-items: center;\r\n        flex-direction: column;\r\n        box-shadow: rgba(50, 50, 93, 0.25) 0px 6px 12px -2px, rgba(0, 0, 0, 0.3) 0px 3px 7px -3px;\r\n        background-color: #fff;\r\n        border-radius: 5px;\r\n    }\r\n\r\n    .details {\r\n        padding:10px;\r\n        width: 100%;\r\n        height: 85%;\r\n        display: flex;\r\n        justify-content: space-evenly;\r\n        \r\n    }\r\n\r\n\r\n    .details .textarea{\r\n        width: 45%;\r\n        height: 150px;\r\n        margin: auto;\r\n    }    \r\n\r\n    .right {\r\n        display: flex;     \r\n        flex-direction: column;\r\n        justify-content: center;\r\n        align-items: center;\r\n        width: 50%;\r\n        margin: auto;\r\n    }\r\n\r\n    .right-input{\r\n        margin: 5px 0;\r\n    }\r\n\r\n    .btns-wrapper {\r\n        width: 90%;\r\n        height: 10%;\r\n        margin: auto;\r\n        display: flex;\r\n        justify-content: space-between;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "wrapper-job");
            __builder.AddMarkupContent(3, "<h1 class=\"mt-5\">Add Job Post</h1>\r\n\r\n    \r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 88 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                     job

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 88 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                                         OnValid

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "class", "add-job-container");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            \r\n            \r\n            ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "class", "form-control w-50 mt-3");
                __builder2.AddAttribute(16, "placeholder", "Job Title");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                                                                                                   job.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job.JobTitle = __value, job.JobTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n   \r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "details");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(22);
                __builder2.AddAttribute(23, "class", "form-control input textarea");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 104 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                                                                                 job.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => job.Description = __value, job.Description))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => job.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n\r\n\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "right");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "class", "form-control right-input");
                __builder2.AddAttribute(33, "placeholder", "Location");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 111 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                                                                                                            job.Location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job.Location = __value, job.Location));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n                    \r\n                    ");
                __builder2.OpenElement(37, "select");
                __builder2.AddAttribute(38, "class", "custom-select right-input");
                __builder2.AddAttribute(39, "id", "inputGroupSelect01");
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                                                                                                 OnJobTypeChanged

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(41, "option");
                __builder2.AddAttribute(42, "selected");
                __builder2.AddContent(43, "-- Select Job Type --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "option");
                __builder2.AddAttribute(46, "value", "Full-time");
                __builder2.AddContent(47, "Full-time");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", "Part-time");
                __builder2.AddContent(51, "Part-time");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "option");
                __builder2.AddAttribute(54, "value", "Contract");
                __builder2.AddContent(55, "Contract");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n                    \r\n                    ");
                __builder2.OpenElement(57, "select");
                __builder2.AddAttribute(58, "class", "custom-select right-input");
                __builder2.AddAttribute(59, "id", "inputGroupSelect01");
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                                                                                                 OnDepartmentChanged

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(61, "option");
                __builder2.AddAttribute(62, "selected");
                __builder2.AddContent(63, "-- Select Department --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.OpenElement(65, "option");
                __builder2.AddAttribute(66, "value", "Accounting");
                __builder2.AddContent(67, "Accounting");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.OpenElement(69, "option");
                __builder2.AddAttribute(70, "value", "Legal");
                __builder2.AddContent(71, "Legal");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                        ");
                __builder2.OpenElement(73, "option");
                __builder2.AddAttribute(74, "value", "I.T");
                __builder2.AddContent(75, "I.T");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                    \r\n                    ");
                __builder2.OpenElement(77, "input");
                __builder2.AddAttribute(78, "type", "text");
                __builder2.AddAttribute(79, "class", "form-control right-input");
                __builder2.AddAttribute(80, "placeholder", "Compensation");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 130 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
                                                                                                                job.Compensation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job.Compensation = __value, job.Compensation));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n        ");
                __builder2.AddMarkupContent(84, @"<div class=""btns-wrapper""><div class=""checkboxes""><input type=""checkbox""> LinkedIn &nbsp;
                <input type=""checkbox""> Indeed &nbsp;
                <input type=""checkbox""> PNet &nbsp;
                

            </div>

            <div class=""btns""><button class=""btn btn-success btn-sm"">Add Job Post</button></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\AddJobPostTest.razor"
 
    //This is the model that we bind to the form
    JobSampleTest job = new JobSampleTest();

    //This is the event callback we use in the select drop down elements
    [Parameter]
    public EventCallback<string> ValueChanged
    {
        get;
        set;
    }

    /*The function we trigger when we interact with the job type drop down
    It simply binds the value from the drop down to the job type field in the model*/
    private Task OnJobTypeChanged(ChangeEventArgs e)
    {
        job.JobType = e.Value.ToString();
        return ValueChanged.InvokeAsync(job.JobType);
    }

    /*The function we trigger when we interact with the department drop down
    It simply binds the value from the drop down to the department field in the model*/
    private Task OnDepartmentChanged(ChangeEventArgs e)
    {
        job.Department = e.Value.ToString();
        return ValueChanged.InvokeAsync(job.Department);
    }

    /*Here we send a post request to another port, different from the port we're
    running our application from. This is to simulate us making an API call
    to a third party vendor such as LinkedIn, or Indeed*/
    private async Task OnValid()
    {
        
        if(job != null)
        {
            var msg = await HttpClient.PostAsJsonAsync("https://localhost:3001/api/job", job);
            if(msg.IsSuccessStatusCode)
            {
                 NavigationManager.NavigateTo("/successtest");   
            }
        }
        
    }

  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
