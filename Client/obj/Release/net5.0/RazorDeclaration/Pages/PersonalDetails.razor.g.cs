// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace XebecPortal.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class PersonalDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 358 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\Pages\PersonalDetails.razor"
      
    public PersonalInformation PersonalInfo { get; set; } = new PersonalInformation();

#line default
#line hidden
#nullable disable
#nullable restore
#line 361 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\Pages\PersonalDetails.razor"
           
    [Parameter]
    public EventCallback<string> GenderChanged
    {
        get;
        set;
    }

    private Task OnGenderChanged(ChangeEventArgs e)
    {
        PersonalInfo.Gender = e.Value.ToString();
        return GenderChanged.InvokeAsync(PersonalInfo.Gender);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 376 "C:\Users\Iviwe\source\repos\xebec-recruitment-portal\Client\Pages\PersonalDetails.razor"
           
    /*
        * Html <option>'s values are string
        * the below code will allow us to accept boolean values from the disability drop down
        * Yes - true
        * No - false
        */
    [Parameter]
    public EventCallback<bool> DisabilityChanged
    {
        get;
        set;
    }

    private Task OnDisabilityChanged(ChangeEventArgs e)
    {
        PersonalInfo.Disability = Convert.ToBoolean(e.Value.ToString());
        return DisabilityChanged.InvokeAsync(PersonalInfo.Disability);
    }

    [Parameter]
    public bool isNotEmpty { get; set; }
   


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<AdditionalInfo> Logger { get; set; }
    }
}
#pragma warning restore 1591
