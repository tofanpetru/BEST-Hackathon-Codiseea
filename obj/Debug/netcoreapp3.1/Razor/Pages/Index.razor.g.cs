#pragma checksum "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32b8692aed52d2f7e4569629d6e3e67f7862e363"
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
#line 1 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Best_Hackathon_Codiseea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\_Imports.razor"
using Best_Hackathon_Codiseea.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
using Best_Hackathon_Codiseea.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
using Best_Hackathon_Codiseea.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/panel")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
 if (globalCorrectAnswers == null || numberOfTeams == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading</em></p>");
#nullable restore
#line 9 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "<h3 class=\"container text-center\">Welcome to Odisee Hackathon</h3>\r\n        <br>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "<p>Salutări și bine ați ați venit la acest <strong>BEST Hackathon: Codiseea!</strong> Această secțiune reprezintă un scurt ghid pentru evenimentul ce va urma și ce etape trebuie îndeplinite. </p>\r\n                <br>\r\n                ");
                __builder2.AddMarkupContent(7, @"<p><strong>Soluţiile pe github:</strong><br>
                    La acest hackathon veți avea de a face cu mai multe probleme. Veți primi câte o problemă și cu cât mai departe ajungeți cu atât sarcinile vor deveni mai complexe. Pentru a putea urmări progresul echipelor și în final să determinăm câștigătorul, fiecare echipă va crea un repozitoriu privat pe github( poate fi gestionat de un singur membru al echipei). După creare se vor respecta următoarele reguli pentru aranjarea soluțiilor: <br>
                    1. Petru fiecare sarcină se va crea o mapă separată în mapa repozitoriului, în care va fi adăugat codul sursă utilizat la rezolvarea problemei. Imaginile și alte fișiere extra din sarcină nu trebuie adăugate. <br>
                    2. Pe tot parcursul evenimentului repozitoriul va fi privat pentru ca alte echipe să nu vadă soluțiile străine. La finalul evenimentului repozitoriul va fi făcut public și organizatorilor le va fi trimis un link la acesta pentru verificare și apreciere. <br>
                    3. Commiturile pot fi făcute local și sincronizate abia la sfârșitul evenimentului.
                </p>
                <br>
                ");
                __builder2.OpenElement(8, "p");
#nullable restore
#line 28 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                      
                        if (globalCorrectAnswers.Count == 0)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(9, "<span>Fii primul care va face prima soluţie!</span>");
#nullable restore
#line 32 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(10, "strong");
                __builder2.AddMarkupContent(11, "Grăbeşte-te! deja au fost încărcate ");
                __builder2.OpenElement(12, "span");
                __builder2.AddAttribute(13, "class", "text-danger");
                __builder2.AddContent(14, 
#nullable restore
#line 35 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                                                                                                   globalCorrectAnswers.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, " soluţie/soluţii corecte");
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                        }
                    

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                <hr>\r\n                ");
                __builder2.OpenElement(17, "p");
                __builder2.AddContent(18, 
#nullable restore
#line 40 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                     numberOfTeams.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(19, "   team number");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "p");
                __builder2.AddContent(22, 
#nullable restore
#line 41 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                    globalCorrectAnswers.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(23, "  glabal answers");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "p");
                __builder2.AddContent(26, 
#nullable restore
#line 42 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                    AllUserProgress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.AddMarkupContent(28, "<h5>Aici puteți vedea progresul global al evenimentului</h5>\r\n                <hr>\r\n                <br>\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "progress");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "progress-bar progress-bar-striped bg-info");
                __builder2.AddAttribute(33, "role", "progressbar");
                __builder2.AddAttribute(34, "style", "width:" + " " + (
#nullable restore
#line 47 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                                                                                                             GlobalProgress()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "aria-valuenow", "60");
                __builder2.AddAttribute(36, "aria-valuemin", "0");
                __builder2.AddAttribute(37, "aria-valuemax", "100");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "progress-bar progress-bar-striped bg-danger");
                __builder2.AddAttribute(41, "role", "progressbar");
                __builder2.AddAttribute(42, "style", "width:" + " " + (
#nullable restore
#line 49 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
                                                                                                               Remaning()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "aria-valuenow", "10");
                __builder2.AddAttribute(44, "aria-valuemin", "0");
                __builder2.AddAttribute(45, "aria-valuemax", "100");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.AddMarkupContent(47, "<p><strong>Legenda:</strong></p>\r\n                ");
                __builder2.AddMarkupContent(48, "<p>\r\n                    - Albastru semnifică progresul general al evenimentului<br>\r\n                    - Roşu semnifică progresul rămas\r\n                </p>");
            }
            ));
            __builder.AddAttribute(49, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(50, "<p>Please log in to access the site content</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Tofan\OneDrive\Desktop\Endava\bn\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\Index.razor"
      
    List<TeamTask> globalCorrectAnswers;
    List<TeamTask> numberOfTeams;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        globalCorrectAnswers = await teamTaskService.GetGlobalCorrectAnswersAsync();
        numberOfTeams = await teamTaskService.GetNumberOfTeamsWhoAnswer();
    }
    public double AllUserProgress;

    public string Remaning()
    {
        return ((Convert.ToString(100 - AllUserProgress)) + "%");
    }

    public string GlobalProgress()
    {
        int TotalEventTasks = 5;
        double precent = 0;

        if(numberOfTeams.Count !=0)
        {
            precent = (((globalCorrectAnswers.Count / numberOfTeams.Count) * 100) / TotalEventTasks);
            AllUserProgress = precent;
            return (Convert.ToString(precent) + "%");
        }
        else
        {
            return ("0%");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TeamTaskService teamTaskService { get; set; }
    }
}
#pragma warning restore 1591
