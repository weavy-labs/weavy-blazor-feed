#pragma checksum "C:\weavy\test\BlazorApp\Pages\Feed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d888e5daa0ed1e7b9c6f944f92f11e107f6b8a1c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\weavy\test\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\weavy\test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\weavy\test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\weavy\test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\weavy\test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\weavy\test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\weavy\test\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\weavy\test\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\weavy\test\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\weavy\test\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\weavy\test\BlazorApp\_Imports.razor"
using BlazorApp.Weavy;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/feed")]
    public partial class Feed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorApp.Shared.Weavy>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "style", "height: 100vh;");
                __builder2.OpenComponent<BlazorApp.Shared.WeavyApp>(4);
                __builder2.AddAttribute(5, "SpaceKey", "blazor-space");
                __builder2.AddAttribute(6, "type", "posts");
                __builder2.AddAttribute(7, "key", 
#nullable restore
#line 5 "C:\weavy\test\BlazorApp\Pages\Feed.razor"
                                                             FeedKey

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(8, "name", 
#nullable restore
#line 5 "C:\weavy\test\BlazorApp\Pages\Feed.razor"
                                                                             FeedName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\weavy\test\BlazorApp\Pages\Feed.razor"
       
    private string FeedKey { get; set; } = "blazor-feed";
    private string FeedName { get; set; }  = "Blazor Feed";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
