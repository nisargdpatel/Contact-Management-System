#pragma checksum "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c484e13b13b87dbd2b4ead73c7f948a83b6d017"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ContactManagemenSystem.Data
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using ContactManagemenSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\_Imports.razor"
using ContactManagemenSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
using ContactManagemenSystem.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactPage")]
    public partial class ContactPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
       
    List<Contact> contacts;

    protected override async Task OnInitializedAsync()
    {
        contacts = await Task.Run(() => contactService.getContact());
    }

    public void confirmDelete(Contact tempcontact)
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactService contactService { get; set; }
    }
}
#pragma warning restore 1591