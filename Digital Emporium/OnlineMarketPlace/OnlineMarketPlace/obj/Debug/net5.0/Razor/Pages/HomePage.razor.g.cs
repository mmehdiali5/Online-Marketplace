#pragma checksum "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "936b7be46f16cf9ca562dbb61bc4842cdfb18212"
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
#line 2 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using OnlineMarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class HomePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""carousel slide mx-5"" data-ride=""carousel"" id=""carousel-1"" b-2d50xmqt8c><div class=""carousel-inner"" b-2d50xmqt8c><div class=""carousel-item active"" b-2d50xmqt8c><a href=""#"" b-2d50xmqt8c><img alt=""Slide Image"" class=""w-100 d-block"" height=""350px"" src=""images/banner1.jpg"" b-2d50xmqt8c></a></div>
        <div class=""carousel-item"" b-2d50xmqt8c><a href=""#"" b-2d50xmqt8c><img alt=""Slide Image"" class=""w-100 d-block"" height=""350px"" src=""images/banner2.jpg"" b-2d50xmqt8c></a></div>
        <div class=""carousel-item"" b-2d50xmqt8c><a href=""#"" b-2d50xmqt8c><img alt=""Slide Image"" class=""w-100 d-block"" height=""350px"" src=""images/banner3.jpg"" b-2d50xmqt8c></a></div></div>
    <div b-2d50xmqt8c><a class=""carousel-control-prev"" data-slide=""prev"" href=""#carousel-1"" b-2d50xmqt8c><span class=""carousel-control-prev-icon"" b-2d50xmqt8c></span><span class=""sr-only"" b-2d50xmqt8c>Previous</span></a><a class=""carousel-control-next"" data-slide=""next"" href=""#carousel-1"" b-2d50xmqt8c><span class=""carousel-control-next-icon"" b-2d50xmqt8c></span><span class=""sr-only"" b-2d50xmqt8c>Next</span></a></div>
    <ol class=""carousel-indicators"" b-2d50xmqt8c><li class=""active"" data-slide-to=""0"" data-target=""#carousel-1"" b-2d50xmqt8c></li>
        <li data-slide-to=""1"" data-target=""#carousel-1"" b-2d50xmqt8c></li>
        <li data-slide-to=""2"" data-target=""#carousel-1"" b-2d50xmqt8c></li></ol></div>

");
            __builder.AddMarkupContent(1, @"<div class=""categories-btns container"" b-2d50xmqt8c><div class=""row d-flex justify-content-center"" b-2d50xmqt8c><button class=""btn btn-light m-2 active col-md-2 category-btn"" type=""button"" b-2d50xmqt8c><i aria-hidden=""true"" class=""fa fa-shopping-bag"" b-2d50xmqt8c></i>Fashion
            &
            Beauty
        </button>
        <button class=""btn btn-light m-2 col-md-2 category-btn"" type=""button"" b-2d50xmqt8c><i aria-hidden=""true"" class=""fa fa-male"" b-2d50xmqt8c></i>Men's
            Fashion
        </button>
        <button class=""btn btn-light m-2 col-md-2 category-btn"" type=""button"" b-2d50xmqt8c><i class=""fa fa-female"" b-2d50xmqt8c></i>Women's
            Fashion
        </button>
        <button class=""btn btn-light m-2 col-md-2 category-btn"" type=""button"" b-2d50xmqt8c><i aria-hidden=""true"" class=""fa fa-bicycle"" b-2d50xmqt8c></i>Sports
        </button></div></div>


");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddAttribute(4, "b-2d50xmqt8c");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddAttribute(7, "b-2d50xmqt8c");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-10 col-12");
            __builder.AddAttribute(10, "b-2d50xmqt8c");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container-fluid");
            __builder.AddAttribute(13, "b-2d50xmqt8c");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddAttribute(16, "b-2d50xmqt8c");
            __builder.AddMarkupContent(17, "<div class=\"col-md-1\" b-2d50xmqt8c></div>\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-3 m-0 d-none d-md-block");
            __builder.AddAttribute(20, "id", "divFilters");
            __builder.AddAttribute(21, "style", "margin-top:25px;");
            __builder.AddAttribute(22, "b-2d50xmqt8c");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "filtered-search-div");
            __builder.AddAttribute(25, "b-2d50xmqt8c");
#nullable restore
#line 81 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                             if (allCategoriesDataForFilterComponenent.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<OnlineMarketPlace.Controls.FilterComponent>(26);
            __builder.AddAttribute(27, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 83 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                  GetCategoryId

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "categoriesList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<OnlineMarketPlace.Models.Category>>(
#nullable restore
#line 83 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                                 allCategoriesDataForFilterComponenent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 86 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                            }


                            

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-md-8 p-0 m-0");
            __builder.AddAttribute(32, "b-2d50xmqt8c");
#nullable restore
#line 98 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                          
                            if (ShowOnlyFilteredProducts == true)
                            {
                                ListData searchedCategoryData = allListItems.Find((temp) => temp.category.Id == categoryIdClickedFromChild);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "d-flex justify-content-center w-50 mx-auto py-2 featured-products");
            __builder.AddAttribute(35, "b-2d50xmqt8c");
            __builder.OpenElement(36, "h2");
            __builder.AddAttribute(37, "class", "product-category-heading");
            __builder.AddAttribute(38, "b-2d50xmqt8c");
            __builder.OpenElement(39, "u");
            __builder.AddAttribute(40, "b-2d50xmqt8c");
            __builder.AddContent(41, 
#nullable restore
#line 103 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                             searchedCategoryData.category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "container my-5 p-0");
            __builder.AddAttribute(45, "b-2d50xmqt8c");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.AddAttribute(48, "b-2d50xmqt8c");
            __builder.OpenComponent<OnlineMarketPlace.Controls.CardComponent<ItemData>>(49);
            __builder.AddAttribute(50, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ItemData>>(
#nullable restore
#line 107 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                               searchedCategoryData.itemsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<ItemData>)((myProd) => (__builder2) => {
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-md-4 col-sm-6");
                __builder2.AddAttribute(54, "b-2d50xmqt8c");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "card my-card mt-0");
                __builder2.AddAttribute(57, "b-2d50xmqt8c");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "align-items-center p-2 text-center");
                __builder2.AddAttribute(60, "b-2d50xmqt8c");
                __builder2.OpenElement(61, "img");
                __builder2.AddAttribute(62, "alt");
                __builder2.AddAttribute(63, "class", "card-img-top w-100 d-block p-2");
                __builder2.AddAttribute(64, "height", "200");
                __builder2.AddAttribute(65, "src", 
#nullable restore
#line 113 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                    myProd.imgPath

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(66, "b-2d50xmqt8c");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                                            ");
                __builder2.OpenElement(68, "h4");
                __builder2.AddAttribute(69, "class", "item-name");
                __builder2.AddAttribute(70, "b-2d50xmqt8c");
                __builder2.AddContent(71, 
#nullable restore
#line 114 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                   myProd.item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                                            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "mt-3 text-dark");
                __builder2.AddAttribute(75, "b-2d50xmqt8c");
                __builder2.OpenElement(76, "span");
                __builder2.AddAttribute(77, "class", "cost-display");
                __builder2.AddAttribute(78, "b-2d50xmqt8c");
                __builder2.AddContent(79, "$ ");
                __builder2.AddContent(80, 
#nullable restore
#line 116 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                              myProd.item.UnitPrice

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                                            <hr b-2d50xmqt8c>\r\n                                                            ");
                __builder2.OpenElement(82, "button");
                __builder2.AddAttribute(83, "class", "show-detail-btn");
                __builder2.AddAttribute(84, "b-2d50xmqt8c");
                __builder2.OpenElement(85, "a");
                __builder2.AddAttribute(86, "class", "show-detail-btn");
                __builder2.AddAttribute(87, "href", "/product/" + (
#nullable restore
#line 121 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                   myProd.item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "b-2d50xmqt8c");
                __builder2.AddContent(89, " Show Details ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n                                        ");
            __builder.AddMarkupContent(91, "<span class=\"ml-auto\" b-2d50xmqt8c><a href=\"#\" b-2d50xmqt8c>See more</a></span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 131 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                            }
                            else
                            {
                                foreach (var listItem in allListItems)
                                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "d-flex justify-content-center w-50 mx-auto py-2 featured-products");
            __builder.AddAttribute(94, "b-2d50xmqt8c");
            __builder.OpenElement(95, "h2");
            __builder.AddAttribute(96, "class", "product-category-heading");
            __builder.AddAttribute(97, "b-2d50xmqt8c");
            __builder.OpenElement(98, "u");
            __builder.AddAttribute(99, "b-2d50xmqt8c");
            __builder.AddContent(100, 
#nullable restore
#line 138 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                 listItem.category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                                    ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "container my-5 p-0");
            __builder.AddAttribute(104, "b-2d50xmqt8c");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "row");
            __builder.AddAttribute(107, "b-2d50xmqt8c");
            __builder.OpenComponent<OnlineMarketPlace.Controls.CardComponent<ItemData>>(108);
            __builder.AddAttribute(109, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ItemData>>(
#nullable restore
#line 142 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                   listItem.itemsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<ItemData>)((myProd) => (__builder2) => {
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "col-md-4 col-sm-6");
                __builder2.AddAttribute(113, "b-2d50xmqt8c");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "card my-card mt-0");
                __builder2.AddAttribute(116, "b-2d50xmqt8c");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "align-items-center p-2 text-center");
                __builder2.AddAttribute(119, "b-2d50xmqt8c");
                __builder2.OpenElement(120, "img");
                __builder2.AddAttribute(121, "alt");
                __builder2.AddAttribute(122, "class", "card-img-top w-100 d-block p-2");
                __builder2.AddAttribute(123, "height", "200");
                __builder2.AddAttribute(124, "src", 
#nullable restore
#line 148 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                        myProd.imgPath

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(125, "b-2d50xmqt8c");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                                                                ");
                __builder2.OpenElement(127, "h4");
                __builder2.AddAttribute(128, "class", "item-name");
                __builder2.AddAttribute(129, "b-2d50xmqt8c");
                __builder2.AddContent(130, 
#nullable restore
#line 149 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                       myProd.item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                                                                ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "mt-3 text-dark");
                __builder2.AddAttribute(134, "b-2d50xmqt8c");
                __builder2.OpenElement(135, "span");
                __builder2.AddAttribute(136, "class", "cost-display");
                __builder2.AddAttribute(137, "b-2d50xmqt8c");
                __builder2.AddContent(138, "$ ");
                __builder2.AddContent(139, 
#nullable restore
#line 151 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                                  myProd.item.UnitPrice

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                                                                <hr b-2d50xmqt8c>\r\n                                                                ");
                __builder2.OpenElement(141, "button");
                __builder2.AddAttribute(142, "class", "show-detail-btn");
                __builder2.AddAttribute(143, "b-2d50xmqt8c");
                __builder2.OpenElement(144, "a");
                __builder2.AddAttribute(145, "class", "show-detail-btn");
                __builder2.AddAttribute(146, "href", "/product/" + (
#nullable restore
#line 156 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                                                                       myProd.item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(147, "b-2d50xmqt8c");
                __builder2.AddContent(148, " Show Details ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(149, "\r\n                                            ");
            __builder.AddMarkupContent(150, "<span class=\"ml-auto\" b-2d50xmqt8c><a href=\"#\" b-2d50xmqt8c>See more</a></span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 166 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n        <div class=\"col-2\" b-2d50xmqt8c></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 339 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
      
    bool ShowOnlyFilteredProducts = false;
    int categoryIdClickedFromChild = -1;

    List<Category> allCategoriesDataForFilterComponenent = new List<Category>();
    public class ItemData
    {
        public Item item;
        public string imgPath;
    }

    public class ListData
    {
        public Category category;

        public List<ItemData> itemsList = new List<ItemData>();
    }
    List<ListData> allListItems = new List<ListData>();

    //    List<Item> allItemList = new List<Item>();

    List<Item> list = new List<Item>();
    protected override async Task<Task> OnInitializedAsync()
    {
        List<Category> allCategoriesList = new List<Category>();
        JArray result = new JArray();
        Console.WriteLine("In On Initialized");
        result = await GetResponse("category");
        Console.WriteLine("Hello");

        allCategoriesList = ConvertJsonArrayToList<Category>(result);
        allCategoriesDataForFilterComponenent = allCategoriesList;
        foreach (var category in allCategoriesList)
        {
            result = await GetResponse("item", "CategoryId", category.Id);
            List<Item> allItemsRelatedToCategory = ConvertJsonArrayToList<Item>(result);
            List<ItemData> itemDataList = new List<ItemData>();
            foreach (var item in allItemsRelatedToCategory)
            {
                result = await GetResponse("image", "ItemId", item.Id);
                String imgPath = ConvertJsonArrayToList<Image>(result).ElementAt(0).Path;
                itemDataList.Add(new ItemData { item = item, imgPath = imgPath });
            }
            Console.WriteLine("Result: " + result);
            allListItems.Add(new ListData { category = category, itemsList = itemDataList });
        }
        return base.OnInitializedAsync();
    }

    async Task<JArray> GetResponse(string table)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 392 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\HomePage.razor"
            String jsonDataAsString;
    Console.Write("In GetResponse(table)");
    HttpClient http = new HttpClient();
    var requestMessage = new HttpRequestMessage()
    {
        Method = new HttpMethod("GET"),
        RequestUri = new Uri("http://localhost:5000/odata/" + table)
    };
    var response = await http.SendAsync(requestMessage);
    jsonDataAsString = await response.Content.ReadAsStringAsync();
    Console.WriteLine(jsonDataAsString);
    var data = (JObject)JsonConvert.DeserializeObject(jsonDataAsString);
    return (JArray)data["value"];
}
async Task<JArray> GetResponse(string table, string field, int id)
{
    String jsonDataAsString;
    Console.Write("In GetResponse(table)");
    HttpClient http = new HttpClient();
    var requestMessage = new HttpRequestMessage()
    {
        Method = new HttpMethod("GET"),
        RequestUri = new Uri("http://localhost:5000/odata/" + table + "?$filter=" + field + " eq " + id)
    };
    var response = await http.SendAsync(requestMessage);
    jsonDataAsString = await response.Content.ReadAsStringAsync();
    Console.WriteLine(jsonDataAsString);
    var data = (JObject)JsonConvert.DeserializeObject(jsonDataAsString);
    return (JArray)data["value"];
}

async Task<List<T>> GetList<T>(string fieldName, int categoryId)
{
    JArray result = new JArray();
    string table = typeof(T).Name;
    result = await GetResponse(table, fieldName, categoryId);
    return ConvertJsonArrayToList<T>(result);
}
public List<T> ConvertJsonArrayToList<T>(JArray jsonArray)
{
    Console.WriteLine("array" + jsonArray);
    List<T> list = jsonArray.ToObject<List<T>>();
    return list;
}

private void GetCategoryId(int id)
{
    ShowOnlyFilteredProducts = true;
    categoryIdClickedFromChild = id;
}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591