#pragma checksum "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\Components\Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa7b5c78798cce94ec480c44bda00d25b54f51c2"
// <auto-generated/>
#pragma warning disable 1591
namespace ParamReviews.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using ParamReviews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using ParamReviews.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\_Imports.razor"
using ParamReviews.Components;

#line default
#line hidden
#nullable disable
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "select");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 2 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\Components\Employees.razor"
                       ChangeSelection

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "option");
            __builder.AddContent(6, "Seleccionar empleado...");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 4 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\Components\Employees.razor"
         foreach (var emp in employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value", 
#nullable restore
#line 6 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\Components\Employees.razor"
                            emp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, 
#nullable restore
#line 6 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\Components\Employees.razor"
                                     emp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 7 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\Components\Employees.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<hr>\r\n");
            __builder.AddContent(16, 
#nullable restore
#line 11 "E:\Projects\2020\BLAZOR\Charla\Talks\ParamReviews\Components\Employees.razor"
 IdEmployee

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
