#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b800d1981733b28aa5f1e6133bf057602be4195"
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
#line 3 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
using XebecPortal.Client.JobPortalTestEnv.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/candidateinfo")]
    public partial class CandidateInfoTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>@import url(\'https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800&display=swap\');\r\n\r\n    * {\r\n        font-family: \'Montserrat\', sans-serif;\r\n    }\r\n\r\n    .wrapper-job {\r\n        width: 100%;\r\n        height: 100vh;\r\n        display: flex;\r\n        flex-direction: column;\r\n        justify-content: space-around;\r\n        align-items: center;\r\n        background-color: #d8e2dc;\r\n    }\r\n\r\n    .add-job-container {\r\n        padding: 20px;\r\n        width: 90%;\r\n        max-width: 650px;\r\n        margin: auto;\r\n        height: 90%;\r\n        max-height: 500px;\r\n        display: flex;\r\n        justify-content: space-evenly;\r\n        align-items: center;\r\n        flex-direction: column;\r\n        box-shadow: rgba(50, 50, 93, 0.25) 0px 6px 12px -2px, rgba(0, 0, 0, 0.3) 0px 3px 7px -3px;\r\n        background-color: #fff;\r\n        border-radius: 5px;\r\n    }\r\n\r\n    .inner-wrapper {\r\n        width: 100%;\r\n        height: 90%;\r\n        margin: auto;\r\n        display: flex;\r\n    }\r\n\r\n    .left {\r\n        width: 45%;\r\n        height: inherit;\r\n        padding: 5px;\r\n        overflow-y: scroll;\r\n    }\r\n\r\n    .left::-webkit-scrollbar {\r\n        width: 12px;\r\n    }\r\n\r\n    .left::-webkit-scrollbar-track {\r\n        background-color: #EAF2F8;\r\n    }\r\n\r\n    .left::-webkit-scrollbar-thumb {\r\n        background-color: #95A5A6;\r\n        border-radius: 20px;\r\n        border: 3px solid #EAF2F8;\r\n    }\r\n\r\n    .box {\r\n        width: 90%;\r\n        height: fit-content;\r\n        padding: 10px;\r\n        margin: 5px auto;\r\n        cursor: pointer;\r\n    }\r\n\r\n    .right {\r\n        width: 55%;\r\n        height: inherit;\r\n        display: flex;\r\n        flex-direction: column;\r\n        justify-content: space-evenly;\r\n    }\r\n\r\n    .select-details {\r\n        width: 90%;\r\n        height: 70%;\r\n        margin: auto;\r\n        padding: 10px;\r\n    }\r\n\r\n    .box,\r\n    .select-details {\r\n        border: 1px solid #95A5A6;\r\n        border-radius: 5px;\r\n        font-size: 13px;\r\n        padding: 5px;\r\n    }\r\n\r\n    .btn-container {\r\n        width: 90%;\r\n        height: 25%;\r\n        margin: auto;\r\n        display: flex;\r\n        justify-content: flex-end;\r\n        align-items: center;\r\n    }\r\n\r\n\r\n    ul span\r\n    {\r\n        font-weight: bold;\r\n    }\r\n \r\n    li\r\n    {\r\n        list-style: none;\r\n    }\r\n\r\n    .select-details p span\r\n    {\r\n        font-weight: bold;\r\n    }\r\n\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "wrapper-job");
            __builder.AddMarkupContent(3, "<h1 class=\"mt-5\" style=\"margin-bottom: -5px;\">Candidates</h1>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "add-job-container");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control w-75 mt-2 mb-3");
            __builder.AddAttribute(9, "placeholder", "search");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 131 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                                                                 searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "inner-wrapper");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "left");
#nullable restore
#line 137 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                 if(SearchResults != null && SearchResults.Count > 0)
                {
                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                      foreach (var candidate in SearchResults)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "box");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 141 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                   On

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "id", 
#nullable restore
#line 141 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                            $"{(candidate.Id)}"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(21, "ul");
            __builder.AddMarkupContent(22, "<span>ID: </span> ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "id", "child");
            __builder.AddContent(25, 
#nullable restore
#line 144 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                                candidate.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, " \r\n                              ");
            __builder.AddMarkupContent(27, "<span>Name: </span> ");
            __builder.OpenElement(28, "li");
            __builder.AddContent(29, 
#nullable restore
#line 145 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                       candidate.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                              ");
            __builder.AddMarkupContent(31, "<span>Job Applied For: </span> ");
            __builder.OpenElement(32, "li");
            __builder.AddContent(33, 
#nullable restore
#line 146 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                                  candidate.JobAppliedFor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 151 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "right");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "select-details");
#nullable restore
#line 163 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                     if(IsClicked && CurrentCandidate != null)
                    {
                    
                  
                       

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "p");
            __builder.AddMarkupContent(40, "<span>ID: </span>");
            __builder.AddContent(41, 
#nullable restore
#line 168 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                             CurrentCandidate.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "p");
            __builder.AddMarkupContent(44, "<span>Name: </span>");
            __builder.AddContent(45, 
#nullable restore
#line 169 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                               CurrentCandidate.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "p");
            __builder.AddMarkupContent(48, "<span>Job Applied For: </span>");
            __builder.AddContent(49, 
#nullable restore
#line 170 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                          CurrentCandidate.JobAppliedFor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "p");
            __builder.AddMarkupContent(52, "<span>Years of Exp: </span>");
            __builder.AddContent(53, 
#nullable restore
#line 171 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                       CurrentCandidate.YearsOfExp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "                        \r\n                        ");
            __builder.OpenElement(55, "p");
            __builder.AddMarkupContent(56, "<span>Additional Info: </span>");
            __builder.AddContent(57, 
#nullable restore
#line 172 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                          CurrentCandidate.ExtraInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 173 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "btn-container");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 178 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
                                                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 193 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\XebecPortal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
 
    static string searchTerm = string.Empty;
    private static List<CandidateTest> Candidates = new List<CandidateTest>
    {


        new CandidateTest
        {
            Id = 1,
            Name = "Johnathan Snow",
            JobAppliedFor = "Developer",
            YearsOfExp = 2,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        },

        new CandidateTest
        {
            Id = 2,
            Name = "Edward Stark",
            JobAppliedFor = "Lawyer",
            YearsOfExp = 8,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        },

        new CandidateTest
        {
            Id = 3,
            Name = "Peter Parker",
            JobAppliedFor = "Developer",
            YearsOfExp = 1,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        },

        new CandidateTest
        {
            Id = 4,
            Name = "Bruce Banner",
            JobAppliedFor = "Cloud Engineer",
            YearsOfExp = 5,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        }

    };

    private static List<CandidateTest> SearchResults = Candidates;
    private static bool isFound = false;    

    private static void Search()
    {
        SearchResults = Candidates.FindAll(q => q.JobAppliedFor.ToLower().Equals(searchTerm.ToLower())); 
       
    }    

    bool IsClicked = false;
    private int ReturnedCandidateId = 0;
    private CandidateTest CurrentCandidate = null;
    private async Task On()
    {
        IsClicked = true;
        ReturnedCandidateId = Int32.Parse(await jsr.InvokeAsync<string>("show"));
       
       
        CurrentCandidate = SearchResults.FirstOrDefault(q => q.Id == ReturnedCandidateId); 
    
           
            

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await jsr.InvokeVoidAsync("initialize");
        }
    }

    




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591
