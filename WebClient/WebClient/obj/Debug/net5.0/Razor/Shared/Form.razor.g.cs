#pragma checksum "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd2fe4d2501b9736716dc87d69a8c5d0bd01168"
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
    public partial class Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "form-book");
            __builder.AddAttribute(2, "class", "card w-75 p-4 justify-content-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, "<label for=\"exampleFormControlInput1\">Titulo</label>\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "id", "exampleFormControlInput1");
            __builder.AddAttribute(10, "placeholder", "Book 1");
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                                               (e) => { book.Title=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                       book.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Title = __value, book.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"exampleFormControlTextarea1\">Descripcion</label>\r\n        ");
            __builder.OpenElement(18, "textarea");
            __builder.AddAttribute(19, "class", "form-control textarea");
            __builder.AddAttribute(20, "id", "exampleFormControlTextarea1");
            __builder.AddAttribute(21, "rows", "3");
            __builder.AddAttribute(22, "placeholder", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.");
            __builder.AddAttribute(23, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                                                        (e) => { book.Description=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                          book.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Description = __value, book.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.AddMarkupContent(29, "<label for=\"exampleFormControlInput2\">Numero de Paginas</label>\r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "number");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "id", "exampleFormControlInput2");
            __builder.AddAttribute(34, "placeholder", "10");
            __builder.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                                                   (e) => {
                                                       try
                                                       {
                                                           book.PageCount=(int)e.Value;
                                                       }
                                                       catch (Exception ex)
                                                       {

                                                       }
                                                   }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                       book.PageCount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PageCount = __value, book.PageCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "<label for=\"exampleFormControlTextarea2\">Extracto</label>\r\n        ");
            __builder.OpenElement(42, "textarea");
            __builder.AddAttribute(43, "class", "form-control textarea");
            __builder.AddAttribute(44, "id", "exampleFormControlTextarea2");
            __builder.AddAttribute(45, "rows", "3");
            __builder.AddAttribute(46, "placeholder", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.");
            __builder.AddAttribute(47, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                                                    (e) => { book.Excerpt=(string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                          book.Excerpt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Excerpt = __value, book.Excerpt));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.AddMarkupContent(53, "<label for=\"exampleFormControlInput3\">Fecha</label>\r\n        ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "datetime-local");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "id", "exampleFormControlInput3");
            __builder.AddAttribute(58, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                                                     (e) => { book.PublishDate=(DateTime)Convert.ToDateTime(e.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                       book.PublishDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.PublishDate = __value, book.PublishDate, format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "d-flex justify-content-center");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                          BackHome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "class", "btn btn-danger mr-3");
            __builder.AddContent(67, "Atras");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
                          CreateOrUpadate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "class", "btn btn-success");
            __builder.AddContent(72, "Guardar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Josue Pujols\OneDrive\Escritorio\Prueba Tecnica Claro\WebClient\WebClient\Shared\Form.razor"
       
    [Parameter]
    public string Id { get; set; }
    private Book book = new Book();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            int IdConverted = Convert.ToInt32(Id);
            book = await BookServices.GetById(IdConverted);
        }
    }

    private async Task CreateOrUpadate()
    {
        //Check if the user is going to update or delete
        bool response;
        if (Id != null)
        {
            response = await BookServices.Update(book.Id, book);
            if (response)
            {
                await JsRuntime.InvokeVoidAsync("alert", "Se ha actualizado el libro " + book.Title);
                book = new Book();
                BackHome();
            }
            else
            {
                await JsRuntime.InvokeVoidAsync("alert", "Ha ocurrido un error al actualizado el libro " + book.Title);
            }
        }
        else
        {
            response = await BookServices.Add(book);
            if (response)
            {
                await JsRuntime.InvokeVoidAsync("alert", "Se ha creado el libro " + book.Title);
                book = new Book();
            }
            else
            {
                await JsRuntime.InvokeVoidAsync("alert", "Ha ocurrido un error al crear el libro " + book.Title);
            }
        }
;
    }

    private void BackHome()
    {
        NavManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BookServices BookServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
