#pragma checksum "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07d06e343394b31ef4c134b2612b48341a1c1001"
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
#nullable restore
#line 2 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stageone")]
    public partial class StageOne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>StageOne</h3>\r\n");
            __builder.AddMarkupContent(1, @"<h6>
    La acest nivel veti avea parte de sarcini simple de logica , in chenarul din partea stanga postati codul sursa
    in chenarul din dreapta rezultatul , daca sunteti siguri , dati click pe submit . o data ce ati dat click sistemul va
    verifica daca raspunsul este corect sau nu . Aveti dreptul la 3 greselui , dupa sarcina se considera neindeplinita si veti
    primi alta . In total la dispozitie aveti 10 sarcini , pentru a trece la urmatorul nivel trebuie sa realizati 6 din ele.
    Daca nu puteti rezolva o sarcina aveti posibilitatea sa treceti la urmatorea apasand butonul ""Urmatoarea sarcina""
</h6>

<br>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "h4");
            __builder.AddContent(7, "Status : ");
            __builder.AddContent(8, 
#nullable restore
#line 16 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                      result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n        <hr>\r\n\r\n\r\n        Task : ....\r\n        <br>\r\n        ........\r\n        <br>\r\n\r\n\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-9");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "password");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "id", "exampleInputPassword1");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                                                              UserAnswer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserAnswer = __value, UserAnswer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-3");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "submit");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                                        CheckAnswer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 32 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                                                               ButtonDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
       
    private int okAnswers = 3;
    private int koAnswers = 2;
    [Parameter]
    public string CorrectAnswer { get; set; } = "BESTChisinauhackathonCodiseeadecembrie";
    public string UserAnswer { get; set; }
    public string result = "";
    public bool ButtonDisabled = false;

    void CheckAnswer()
    {

        if (UserAnswer.Length >= 0)
        {
            ButtonDisabled = true;
            if (UserAnswer.ToLower() == CorrectAnswer.ToLower())
            {
                result = "correct";
            }
            else
            {
                result = "incorrect";
            }
        }
        else
        {
            ButtonDisabled = false;
            result = "No answer";
        }


    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
