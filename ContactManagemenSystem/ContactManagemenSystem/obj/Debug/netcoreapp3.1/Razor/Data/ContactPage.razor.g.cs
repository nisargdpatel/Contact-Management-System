#pragma checksum "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c7adeeed0131691c7e9a7de6f05611de704a9d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "\r\nNavigate to Add Contact Component when Add New Contact link is clicked\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "NewContact");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span>Add New Contact\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.AddMarkupContent(7, "<h1>All Contacts</h1>\r\n");
#nullable restore
#line 11 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
 if (contacts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 14 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddAttribute(12, "style", "background-color:lightgray");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, @"<thead style=""text-align: center; margin:auto"">
            <tr>
                <th>Contact Id</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Phone Number</th>
                <th>Birth Date</th>
                <th>Actions</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(15, "tbody");
            __builder.AddAttribute(16, "style", "text-align: center; margin:auto");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 29 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
             foreach (var contact in contacts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "style", "vertical-align: middle");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
                                                        contact.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "style", "vertical-align: middle");
            __builder.AddContent(27, 
#nullable restore
#line 33 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
                                                        contact.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "style", "vertical-align: middle");
            __builder.AddContent(31, 
#nullable restore
#line 34 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
                                                        contact.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "style", "vertical-align: middle");
            __builder.AddContent(35, 
#nullable restore
#line 35 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
                                                        contact.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "style", "vertical-align: middle");
            __builder.AddContent(39, 
#nullable restore
#line 36 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
                                                        contact.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "style", "vertical-align: middle");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "EditContact/" + (
#nullable restore
#line 38 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
                                                               contact.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n                            <p class=\"oi oi-pencil\" aria-hidden=\"true\"></p>Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "style", "vertical-align: middle");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "DeleteContact/" + (
#nullable restore
#line 43 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
                                                                 contact.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "\r\n                            <p class=\"oi oi-trash\" aria-hidden=\"true\"></p>Delete\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 48 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 51 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\ContactPage.razor"
       
    List<Contact> contacts;

    protected override async Task OnInitializedAsync()
    {
        contacts = await Task.Run(() => contactService.getContact());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactService contactService { get; set; }
    }
}
#pragma warning restore 1591
