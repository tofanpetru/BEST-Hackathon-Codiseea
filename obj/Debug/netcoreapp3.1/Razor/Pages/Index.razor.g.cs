#pragma checksum "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462e5d13c6be5f9445a3069a5ff35c9ad2d812c0"
// <auto-generated/>
#pragma warning disable 1591
namespace Best_Hackathon_Codiseea.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Best_Hackathon_Codiseea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Best_Hackathon_Codiseea.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/panel")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container text-center");
            __builder.AddMarkupContent(2, "<h3>Welcome to Odisee Hackathon</h3>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<h5>- Here you can see your progres -</h5>\r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(6, @"<div class=""progress""><div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 0"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 0"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 0"" aria-valuenow=""10"" aria-valuemin=""0"" aria-valuemax=""100""></div></div>
            ");
                __builder2.AddMarkupContent(7, "<div class=\"congrats\"><h1 class=\"titlu\">Congratulations!</h1></div>");
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "<p>Please log in to access the site content</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
