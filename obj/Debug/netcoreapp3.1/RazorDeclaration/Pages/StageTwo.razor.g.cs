// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageTwo.razor"
using Best_Hackathon_Codiseea.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageTwo.razor"
using Best_Hackathon_Codiseea.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageTwo.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageTwo.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageTwo.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stagetwo")]
    public partial class StageTwo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageTwo.razor"
       
    [Parameter]
    public string CorrectAnswer6 { get; set; } = "{FLG:B4esSrChB4esSrSnL33rM3B3g1n}";
    public string value;

    public string UserAnswer6 { get; set; } = "";
    public string UserAnswer2 { get; set; } = "";

    public bool HideAnswer6 = false;
    public bool HideAnswer2 = false;

    protected async Task CheckAnswer(int VerifyTask)
    {
        switch (VerifyTask)
        {
            case 6:
                if (!string.IsNullOrEmpty(UserAnswer6))
                {
                    if (UserAnswer6.ToLower() == CorrectAnswer6.ToLower())
                    {
                        value = "Correct";
                    }
                    else
                    {
                        value = "Incorrect";
                    }
                }
                break;
            default:
                value = "False";
                break;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TeamTaskService teamTaskService { get; set; }
    }
}
#pragma warning restore 1591
