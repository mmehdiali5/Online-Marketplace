#pragma checksum "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\CardComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21253ccf4eaf957d415c73629f2df56d0a9977b"
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
    public partial class CardComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\CardComponent.razor"
 foreach(TItem p in Items) { 
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 4 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\CardComponent.razor"
     ChildContent(p)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 4 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\CardComponent.razor"
                    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
