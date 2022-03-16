#pragma checksum "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b886167f290409c2c09056cd3c3a77ec3c4b8519"
// <auto-generated/>
#pragma warning disable 1591
namespace WaterProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/_Imports.razor"
using WaterProject.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""bg-info text-white p-2"">

    <div class=""container-fluid"">

        <div class=""row"">

            <div class=""col"">

                <span class=""navbar-brand m-lg-2"">Water Project Administration</span>
            </div>

            <div class=""col-2 text-right"">
                <a class=""btn btn-sm btn-primary"" href=""/account/logout"">Log out</a>
            </div>

        </div>

    </div>

</div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\n\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2");
            __builder.AddMarkupContent(6, "\n\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3");
            __builder.AddMarkupContent(9, "\n\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "d-grid gap-2");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "btn btn-outline-primary");
            __builder.AddAttribute(15, "href", "/admin/projects");
            __builder.AddAttribute(16, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(17, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 32 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/AdminLayout.razor"
                                                                     NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Projects");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "btn btn-outline-primary");
            __builder.AddAttribute(23, "href", "/admin/donations");
            __builder.AddAttribute(24, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(25, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 34 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/AdminLayout.razor"
                                                                     NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, "Donations");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.AddMarkupContent(33, "\n            ");
#nullable restore
#line 40 "/Users/michaelpiscione/Projects/WaterProject/Pages/Admin/AdminLayout.razor"
__builder.AddContent(34, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
