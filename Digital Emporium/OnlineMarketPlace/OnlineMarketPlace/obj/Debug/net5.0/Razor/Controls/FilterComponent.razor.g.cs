#pragma checksum "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\FilterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0185a5da1caef262566039f3380c32380f0a1a75"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineMarketPlace.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 12 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace.Models;

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
    public partial class FilterComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "filter-box");
            __builder.AddAttribute(2, "b-tf27g24qca");
            __builder.AddMarkupContent(3, @"<div class=""panel-heading"" b-tf27g24qca><h4 class=""panel-title"" b-tf27g24qca><a aria-expanded=""true"" class data-target=""#collapseCategories"" data-toggle=""collapse"" b-tf27g24qca><span class=""font-weight-600 title"" b-tf27g24qca>Category</span></a></h4></div>
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "collapse show");
            __builder.AddAttribute(6, "id", "collapseCategories");
            __builder.AddAttribute(7, "b-tf27g24qca");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "panel-body");
            __builder.AddAttribute(10, "b-tf27g24qca");
#nullable restore
#line 13 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\FilterComponent.razor"
             foreach (var category in categoriesList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-check");
            __builder.AddAttribute(13, "b-tf27g24qca");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\FilterComponent.razor"
                                 ()=>OnClickCallback.InvokeAsync(category.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-tf27g24qca");
            __builder.AddContent(17, 
#nullable restore
#line 16 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\FilterComponent.razor"
                                                                                category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\FilterComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\FilterComponent.razor"
       

    [Parameter]
    public List<Category> categoriesList { get; set; }
    
    [Parameter]
    public EventCallback<int> OnClickCallback { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
