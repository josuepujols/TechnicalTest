#pragma checksum "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Pages\DetailsBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1f38a7dd06981ab69b9a44eaecc7897714e6ca"
// <auto-generated/>
#pragma warning disable 1591
namespace WebClient.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/{Id}")]
    public partial class DetailsBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid d-flex justify-content-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card rounded p-4 mt-5");
            __builder.OpenElement(4, "h2");
            __builder.AddAttribute(5, "class", "text-center mt-3");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Pages\DetailsBook.razor"
             book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mt-3");
            __builder.AddMarkupContent(10, "<span class=\"bold\">Descrpcion</span>\r\n            ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 13 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Pages\DetailsBook.razor"
                 book.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        <hr>\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "<span class=\"bold\">Extracto</span>\r\n            ");
            __builder.OpenElement(16, "p");
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Pages\DetailsBook.razor"
                 book.Excerpt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        <hr>\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "d-flex justify-content-around");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "<span class=\"bold\">Numero de Paginas</span>\r\n                ");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, 
#nullable restore
#line 31 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Pages\DetailsBook.razor"
                     book.PageCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddMarkupContent(27, "<span class=\"bold\">Fecha</span>\r\n                ");
            __builder.OpenElement(28, "p");
            __builder.AddContent(29, 
#nullable restore
#line 38 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Pages\DetailsBook.razor"
                     book.PublishDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Pages\DetailsBook.razor"
       
    [Parameter]
    public string Id { get; set; }

    public Book book = new Book();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            int IdConverted = Convert.ToInt32(Id);
            book = await BookServices.GetById(IdConverted);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BookServices BookServices { get; set; }
    }
}
#pragma warning restore 1591
