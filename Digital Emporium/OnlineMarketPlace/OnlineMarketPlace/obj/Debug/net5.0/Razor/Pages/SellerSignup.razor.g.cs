#pragma checksum "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54bf7fdab5746674ac5c2771b80dd2675b4ddb4d"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineMarketPlace.Pages
{
    #line hidden
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using OnlineMarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/sellerSignup")]
    public partial class SellerSignup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row my-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", " col-10 col-md-3 text-center p-5 m-auto");
            __builder.AddAttribute(4, "style", "border: 1px solid #DADCE0;border-radius: 10px;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "justify-content- center");
            __builder.AddMarkupContent(7, "<img src=\"images/DigitalEmporiumLogo.png\" height=\"150px\">\r\n            <br>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(8, "<span style=\"font-size: x-large;\">Seller Sign up</span>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(9, "<span>to continue to start selling</span>\r\n            <br>\r\n            <br>\r\n            <br>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                              sellerSignUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 25 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                           submitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "placeholder", "Enter your name");
                __builder2.AddAttribute(19, "style", "font-size: large;");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.Name = __value, sellerSignUp.Name))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 30 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.Name 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "placeholder", "Enter your email");
                __builder2.AddAttribute(30, "style", "font-size: large;");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.Email = __value, sellerSignUp.Email))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 34 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.Email 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "type", "password");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "placeholder", "Enter your password");
                __builder2.AddAttribute(42, "style", "font-size: large;");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                                             sellerSignUp.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.Password = __value, sellerSignUp.Password))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_2(__builder2, 47, 48, 
#nullable restore
#line 38 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.Password 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "placeholder", "Enter your phone");
                __builder2.AddAttribute(53, "style", "font-size: large;");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.Phone = __value, sellerSignUp.Phone))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.Phone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_3(__builder2, 58, 59, 
#nullable restore
#line 42 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.Phone 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(60, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "placeholder", "Enter your country");
                __builder2.AddAttribute(64, "style", "font-size: large;");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.Country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.Country = __value, sellerSignUp.Country))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.Country));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_4(__builder2, 69, 70, 
#nullable restore
#line 46 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.Country 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "placeholder", "Enter your city");
                __builder2.AddAttribute(75, "style", "font-size: large;");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.City = __value, sellerSignUp.City))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_5(__builder2, 80, 81, 
#nullable restore
#line 50 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.City 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(82, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddAttribute(85, "placeholder", "Enter your postal code");
                __builder2.AddAttribute(86, "style", "font-size: large;");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.PostalCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.PostalCode = __value, sellerSignUp.PostalCode))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.PostalCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_6(__builder2, 91, 92, 
#nullable restore
#line 54 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.PostalCode 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(93, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(94);
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "placeholder", "Enter your state");
                __builder2.AddAttribute(97, "style", "font-size: large;");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.State

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.State = __value, sellerSignUp.State))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.State));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_7(__builder2, 102, 103, 
#nullable restore
#line 58 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.State 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(104, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(105);
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "placeholder", "Enter your street address");
                __builder2.AddAttribute(108, "style", "font-size: large;");
                __builder2.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                                             sellerSignUp.StreetAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignUp.StreetAddress = __value, sellerSignUp.StreetAddress))));
                __builder2.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignUp.StreetAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignup.TypeInference.CreateValidationMessage_8(__builder2, 113, 114, 
#nullable restore
#line 62 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                          () => sellerSignUp.StreetAddress 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(115, "\r\n                <br>\r\n                ");
                __builder2.AddMarkupContent(116, "<button class=\"btn btn-primary\" type=\"submit\">\r\n                    Sign up\r\n                </button>\r\n                <br>\r\n                <br>\r\n                ");
                __builder2.OpenElement(117, "span");
                __builder2.AddAttribute(118, "style", "color:red");
                __builder2.AddContent(119, 
#nullable restore
#line 69 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
                                         sellerSignUp.emailWarning

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(121, "<a href=\"sellerSignin\">Already have an account?</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
       

    async Task submitForm()
    {
        Address address = new Address();
        UserItem userItem = new UserItem();
        Seller seller = new Seller();
        JArray obj = await checkEmailDuplication(sellerSignUp.Email);
        if (obj.Count==0) {
            address.City = sellerSignUp.City;
            address.Country = sellerSignUp.Country;
            address.PostalCode = sellerSignUp.PostalCode;
            address.StreetAddress = sellerSignUp.StreetAddress;
            address.State = sellerSignUp.State;
            int addressID = await addToDB("address", address);
            userItem.AddressId = addressID;
            userItem.Name = sellerSignUp.Name;
            userItem.Phone = sellerSignUp.Phone;
            userItem.Email = sellerSignUp.Email;
            userItem.DateOfBirth = null;
            userItem.Password = sellerSignUp.Password;
            int userItemID = await addToDB("userItem", userItem);
            seller.PaymentTypeId = 1;
            seller.ShopAddressId = addressID;
            seller.UserId = userItemID;
            await addToDB("seller", seller);
            NavManager.NavigateTo("/sellerSignin");
        }
        else {
            sellerSignUp.emailWarning = "Email already in use.";
        }


    }

    async Task<JArray> checkEmailDuplication(string email)
    {
        String jsonDataAsString;
        HttpClient http = new HttpClient();
        var requestMessage = new HttpRequestMessage()
        {
            Method = new HttpMethod("GET"),
            RequestUri = new Uri("http://localhost:5000/odata/userItem?$filter=email eq '" + email + "'")
        };
        var response = await http.SendAsync(requestMessage);
        jsonDataAsString = await response.Content.ReadAsStringAsync();
        var data = (JObject)JsonConvert.DeserializeObject(jsonDataAsString);
        return (JArray)data["value"];
    }
    async Task<int> addToDB<T>(string table, T obj)
    {
        var json = JsonConvert.SerializeObject(obj);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var url = "http://localhost:5000/odata/" + table;
        using var client = new HttpClient();
        var response = await client.PostAsync(url, data);
        var result = await response.Content.ReadAsStringAsync();
        var data1 = (JObject)JsonConvert.DeserializeObject(result);
        return Convert.ToInt32(data1["value"][0].ToString());

    }

    public class Seller
    {
        public int UserId { get; set; }
        public int ShopAddressId { get; set; }
        public int PaymentTypeId { get; set; }
    }

    public class Address
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
    }
    public class UserItem
    {
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }

    }
    public class SellerSignUp
    {
        public string emailWarning=null;
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string StreetAddress { get; set; }

    }
    SellerSignUp sellerSignUp = new SellerSignUp();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.OnlineMarketPlace.Pages.SellerSignup
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591