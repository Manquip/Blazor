#pragma checksum "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aab96b4b5e20895418b906e861cb5f8779d7e1fa"
// <auto-generated/>
#pragma warning disable 1591
namespace Parameters.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Parameters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\_Imports.razor"
using Parameters.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Parameters.Components.SelectBoss>(0);
            __builder.AddAttribute(1, "BossId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\Pages\Index.razor"
                                                BossId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "BossIdChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BossId = __value, BossId))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n<hr>\r\n");
            __builder.OpenComponent<Parameters.Components.ListEmployees>(4);
            __builder.AddAttribute(5, "BossId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "E:\Projects\2020\BLAZOR\Charla\Talks\Parameters\Pages\Index.razor"
                                                   BossId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "BossIdChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BossId = __value, BossId))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
