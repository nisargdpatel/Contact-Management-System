#pragma checksum "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb5b57af1e68d41652375942a387fdf3c30f4981"
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
#line 2 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
using ContactManagemenSystem.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewContact")]
    public partial class NewContactPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Contact</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"FirstName\" class=\"control-label\">First Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "FirstName");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                                                                     contact.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contact.FirstName = __value, contact.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 15 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                 if (contact.FirstName == null || contact.FirstName.Length == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                    ");
            __builder.AddMarkupContent(20, "<p class=\"alert-danger\">First name cannot be empty!</p>\r\n");
#nullable restore
#line 18 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                 if (contact.FirstName != null && contact.FirstName.Length > 250)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                    ");
            __builder.AddMarkupContent(22, "<p class=\"alert-danger\">First name must be less than 250 characters long.</p>\r\n");
#nullable restore
#line 22 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<label for=\"LastName\" class=\"control-label\">Last Name</label>\r\n                ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "form", "LastName");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                                                                    contact.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contact.LastName = __value, contact.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 27 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                 if (contact.LastName == null || contact.LastName.Length == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.AddMarkupContent(36, "<p class=\"alert-danger\">Last name cannot be empty!</p>\r\n");
#nullable restore
#line 30 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                 if (contact.LastName != null && contact.LastName.Length > 250)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                    ");
            __builder.AddMarkupContent(38, "<p class=\"alert-danger\">Last name must be less than 250 characters long.</p>\r\n");
#nullable restore
#line 34 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<label for=\"PhoneNumber\" class=\"control-label\">Phone Number</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "form", "PhoneNumber");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                                                                       contact.PhoneNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contact.PhoneNumber = __value, contact.PhoneNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 39 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                 if (contact.PhoneNumber == null || contact.PhoneNumber.Length == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                    ");
            __builder.AddMarkupContent(52, "<p class=\"alert-danger\">Phone number cannot be empty!</p>\r\n");
#nullable restore
#line 42 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                 if (contact.PhoneNumber != null && contact.PhoneNumber.Length != 10)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                    ");
            __builder.AddMarkupContent(54, "<p class=\"alert-danger\">Phone number must be 10 digits long!</p>\r\n");
#nullable restore
#line 46 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                 if (contact.PhoneNumber != null && contact.PhoneNumber != null && !Double.TryParse(contact.PhoneNumber, out _))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                    ");
            __builder.AddMarkupContent(56, "<p class=\"alert-danger\">Phone number must be all numeric!</p>\r\n");
#nullable restore
#line 50 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<label for=\"BirthDate\" class=\"control-label\">Birth Date</label>\r\n                ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "date");
            __builder.AddAttribute(65, "form", "BirthDate");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                                                                                 contact.BirthDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => contact.BirthDate = __value, contact.BirthDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-md-4");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group");
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "type", "button");
            __builder.AddAttribute(84, "class", "btn btn-primary");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                                                                       createContact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "value", "Add Contact");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "type", "button");
            __builder.AddAttribute(90, "class", "btn btn-primary");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
                                                                       cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\nisar\BlazorProjects\Contact-Management-System\ContactManagemenSystem\ContactManagemenSystem\Data\NewContactPage.razor"
       

    Contact contact = new Contact();

    protected void createContact()
    {
        if (contact.FirstName == null || contact.FirstName.Length == 0 || (contact.FirstName != null && contact.FirstName.Length > 250) ||
            contact.LastName == null || contact.LastName.Length == 0 || (contact.LastName != null && contact.LastName.Length > 250) ||
            contact.PhoneNumber == null || contact.PhoneNumber.Length == 0 || (contact.PhoneNumber != null && contact.PhoneNumber.Length != 10) ||
            !Double.TryParse(contact.PhoneNumber, out _))
        {
            alert();
        } else
        {
            contactService.Create(contact);
            navigationManager.NavigateTo("ContactPage");
        }

    }
    void cancel()
    {
        navigationManager.NavigateTo("ContactPage");
    }

    async Task alert()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"One ore more fields invalid. Please try again"))
        {
            return;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactService contactService { get; set; }
    }
}
#pragma warning restore 1591
