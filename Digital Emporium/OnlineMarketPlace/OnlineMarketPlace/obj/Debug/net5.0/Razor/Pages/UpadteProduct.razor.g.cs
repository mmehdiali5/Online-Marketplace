#pragma checksum "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5224ebc7ee0f6b2aa6931e6ee3d0f0ce4ff65d0c"
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
#line 3 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using OnlineMarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/updateproduct")]
    public partial class UpadteProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid bg-light");
            __builder.AddAttribute(2, "style", "padding-top: 2%;");
            __builder.AddMarkupContent(3, @"<div class=""bg-dark"" style=""padding: 1%; margin-left: 10%; margin-right: 10%; margin-bottom: 3%; border-radius: 5px;""><div style=""padding: 1%; border: 1px dashed gray;background-color: #FCECEC; border-radius: 5px;""><p>Home>Add Products>Update Product</p>
            <div class=""text-center""><h2>Update Products</h2></div></div></div>
    
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form");
            __builder.AddAttribute(6, "style", "padding-left: 10%; padding-right: 10%;");
            __builder.AddMarkupContent(7, "<h4>Product Details</h4>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                          updateProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 26 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                                        submitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, @"<div class=""form-row""><div class=""form-group col-md-4 image-upload-wrap""><input class=""file-upload-input"" type=""file"" onchange=""readURL(this);"" accept=""image/*""></div>
                <div class=""form-group col-md-4 image-upload-wrap""><input class=""file-upload-input"" type=""file"" onchange=""readURL(this);"" accept=""image/*""></div>
                <div class=""form-group col-md-4 image-upload-wrap""><input class=""file-upload-input"" type=""file"" onchange=""readURL(this);"" accept=""image/*""></div></div>
            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label for=\"Name\"><b>Name:</b></label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "name");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "placeholder", "Enter product name");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                                  updateProduct.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateProduct.Name = __value, updateProduct.Name))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateProduct.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.UpadteProduct.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 42 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                          ()=> updateProduct.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-row");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(33, "<label for=\"Price\"><b>Price:</b></label>\r\n                    ");
                __Blazor.OnlineMarketPlace.Pages.UpadteProduct.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "price", 36, "form-control", 37, "Enter product price", 38, 
#nullable restore
#line 47 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                                         updateProduct.Price

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateProduct.Price = __value, updateProduct.Price)), 40, () => updateProduct.Price);
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __Blazor.OnlineMarketPlace.Pages.UpadteProduct.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 48 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                              ()=> updateProduct.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(47, "<label for=\"Quantity\"><b>Quantity:</b></label>\r\n                    ");
                __Blazor.OnlineMarketPlace.Pages.UpadteProduct.TypeInference.CreateInputNumber_3(__builder2, 48, 49, "quantity", 50, "form-control", 51, "Enter product Quantity", 52, 
#nullable restore
#line 52 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                                            updateProduct.Quantity

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateProduct.Quantity = __value, updateProduct.Quantity)), 54, () => updateProduct.Quantity);
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __Blazor.OnlineMarketPlace.Pages.UpadteProduct.TypeInference.CreateValidationMessage_4(__builder2, 56, 57, 
#nullable restore
#line 53 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                              ()=> updateProduct.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(61, "<label for=\"catagory\"><b>Category:</b></label>\r\n                    ");
                __builder2.OpenElement(62, "select");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "id", "catagory");
                __builder2.OpenElement(65, "option");
                __builder2.AddContent(66, "Food");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.OpenElement(68, "option");
                __builder2.AddContent(69, "Women");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.OpenElement(71, "option");
                __builder2.AddContent(72, "Men");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.OpenElement(74, "option");
                __builder2.AddContent(75, "Kids");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.OpenElement(77, "option");
                __builder2.AddContent(78, "Mobile");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "<label for=\"discription\"><b>Description:</b></label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "id", "comment");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "row", "3");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                                     updateProduct.Discription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateProduct.Discription = __value, updateProduct.Discription))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateProduct.Discription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.UpadteProduct.TypeInference.CreateValidationMessage_5(__builder2, 91, 92, 
#nullable restore
#line 69 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
                                          ()=> updateProduct.Discription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(94, "<div class=\"text-center\"><button class=\"btn btn-primary\">Add Product</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "<br>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Muhammad Mehdi Ali\Desktop\PUCIT Files\6th Semester\EAD\EAD-Project\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\UpadteProduct.razor"
      
    async Task submitForm()
    {
        Image image = new Image();
        Seller seller = new Seller();
        Item item = new Item();
        Category category = new Category();
        JArray obj = await checkProductNameDuplication(updateProduct.Name);
        if (obj.Count == 0)
        {
            item.Name = updateProduct.Name;
            item.UnitPrice = updateProduct.Price;
            int categoryID = await addToDB("category", category);
            item.CategoryId = categoryID;
            item.Description = updateProduct.Discription;
            int sellerID = await addToDB("seller", seller);
            item.SellerId = sellerID;
            category.Name = updateProduct.Category;
            await addToDB("item", item);
        }
        else
        {
            updateProduct.nameWarning = "Product Name already in use.";
        }
    }

    async Task<JArray> checkProductNameDuplication(string name)
    {
        String jsonDataAsString;
        HttpClient http = new HttpClient();
        var requestMessage = new HttpRequestMessage()
        {
            Method = new HttpMethod("GET"),
            RequestUri = new Uri("http://localhost:5000/odata/userItem?$filter=email eq '" + name + "'")
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

    public class Image
    {
        public int ItemId { get; set; }
        public string Path { get; set; }
    }

    public class Seller
    {
        public int UserId { get; set; }
        public int ShopAddressId { get; set; }
        public int PaymentTypeId { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double? AverageRating { get; set; }
        public int CategoryId { get; set; }
        public float UnitPrice { get; set; }
        public int SellerId { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
    }

    UpdateProduct updateProduct = new UpdateProduct();
    public class UpdateProduct
    {
        [Required]
        [StringLength(100, ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required]
        [Range(0, 9999, ErrorMessage = "Price must be between 0 and 9999")]
        public int Price { get; set; }
        [Required]
        [Range(0, 99, ErrorMessage = "Quantity must be between 0 and 99")]
        public int Quantity { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Discription { get; set; }
        public string nameWarning = null;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.OnlineMarketPlace.Pages.UpadteProduct
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
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
    }
}
#pragma warning restore 1591
