#pragma checksum "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddcfe0b1a3b2c500d04c671e4da4701c69787ec8"
// <auto-generated/>
#pragma warning disable 1591
namespace WebClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using WebClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Services.BookService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\_Imports.razor"
using Services.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style b-tva32fkiip>\r\n    #brand-name {\r\n        font-size: 25px;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "top-row pl-4 navbar navbar-dark text-center");
            __builder.AddAttribute(3, "b-tva32fkiip");
            __builder.AddMarkupContent(4, "<a id=\"brand-name\" class=\"navbar-brand\" href b-tva32fkiip>Book Store</a>\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "navbar-toggler");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "b-tva32fkiip");
            __builder.AddMarkupContent(9, "<span class=\"navbar-toggler-icon\" b-tva32fkiip></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 15 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "b-tva32fkiip");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "nav flex-column");
            __builder.AddAttribute(17, "b-tva32fkiip");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddAttribute(20, "b-tva32fkiip");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 18 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "<span class=\"oi oi-book\" aria-hidden=\"true\" b-tva32fkiip></span> Libros\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddAttribute(30, "b-tva32fkiip");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "add");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-tva32fkiip></span> Agregar Libro\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
