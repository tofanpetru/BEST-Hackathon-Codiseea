#pragma checksum "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2d6a84a883807934423175b9656911d4983044b"
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
using Best_Hackathon_Codiseea.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
using Best_Hackathon_Codiseea.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stageone")]
    public partial class StageOne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Bun venit la BEST Hackathon Codiseea !</h3>\r\n");
            __builder.AddMarkupContent(1, "<h6>\r\n    Ne bucurăm că sunteţi alături de noi, pentru a începe cel mai fain drum, dar şi cel mai dificil.\r\n    La această etapă trebuie să vă adaptaţi, pentru a înfrunta alternativul creaturilor mitice, adică problemele logice.\r\n</h6>\r\n");
            __builder.AddMarkupContent(2, "<h6>\r\n    Alte detalii:\r\n    Soluţiile se vor introduce în chenarele de mai jos, iar după ce aţi introdus soluţia, butonaţi \"Submit\".\r\n</h6>\r\n\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "h4");
            __builder.AddMarkupContent(8, "\r\n            1. Status : ");
#nullable restore
#line 22 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                           if (!string.IsNullOrEmpty(value))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "text-danger");
            __builder.AddContent(11, 
#nullable restore
#line 23 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                            value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "hidden", 
#nullable restore
#line 26 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                      HideAnswer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "<strong>Problema:</strong>\r\n            ");
            __builder.AddMarkupContent(16, "<p>BEST Chișinău iubește culoarea roșu.</p>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(17, "<strong>Sarcina:</strong>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(18, "<p>Trebuie să calculați suma componentelor roșii din fiecare pixel a <a href=\"https://drive.google.com/u/0/uc?id=1HPxGU2uXfbxHAyRan4cHtHuOaS8EKNWq&export=download\">imaginii</a></p>\r\n            <br>\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-9");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                        UserAnswer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserAnswer = __value, UserAnswer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-3");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "submit");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                                            () => CheckAnswer(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n<br>\r\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "card-body");
            __builder.OpenElement(40, "h4");
            __builder.AddMarkupContent(41, "\r\n            2. Status : ");
#nullable restore
#line 50 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                           if (!string.IsNullOrEmpty(value2))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "span");
            __builder.AddAttribute(43, "class", "text-danger");
            __builder.AddContent(44, 
#nullable restore
#line 51 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                            value2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                         }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "hidden", 
#nullable restore
#line 54 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                      HideAnswer2

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(48, "<strong>Problema succesului:</strong>\r\n            ");
            __builder.AddMarkupContent(49, @"<p>
                Se dă un şir de numere care ar reprezenta succesul unei persoane. Succesul este atunci când valorile din subşir sunt în ordine crescătoare. Pentru că nimeni nu este ideal, după fiecare acţiune executată cu succes, urmează insuccesul - o valoare mai mică de cât precedenta.
                Toate acestea se vor repeta una după alta până când se va întâlni valoarea 0, rezultând sfarşitul şirului.
            </p>
            <br>
            ");
            __builder.AddMarkupContent(50, "<strong>Sarcina:</strong>\r\n            ");
            __builder.AddMarkupContent(51, "<p>Se va afişa succesul în ordine inversă celei de introducer, separate prin spaţiu.</p>\r\n            ");
            __builder.AddMarkupContent(52, "<strong>Exemplu:</strong>\r\n            ");
            __builder.AddMarkupContent(53, "<p>Intrare: 1 2 10 3 7 5 4 3 0</p>\r\n            ");
            __builder.AddMarkupContent(54, "<p>Ieşire:  10 2 1 7 3 3 4 5 2</p>\r\n            <br>  \r\n            ");
            __builder.AddMarkupContent(55, @"<p>Numerele 1,2,10 reprezintă succesul, respectiv ca date de ieşire se vor inversa (10,2,1), dupa urmează nr 3 şi reprezintă eşecul, iar 7 reprezintă succesul, iar 5,4,3 reprezintă eşecul. La sfarşitul şirului de numere, în locul lui 0 va fi numărul de succese, în cazul nostru este nr 2.</p>
            <br>
            ");
            __builder.AddMarkupContent(56, "<p>Datele de intrare pentru determinarea cheii: 1 1 4 8 9 2 4 8 44 5 86 2 4 0</p>\r\n            <br>\r\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-9");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                        UserAnswer2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserAnswer2 = __value, UserAnswer2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-3");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "submit");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                                            () => CheckAnswer(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n<br>\r\n");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "card");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "card-body");
            __builder.OpenElement(78, "h4");
            __builder.AddMarkupContent(79, "\r\n            3. Status : ");
#nullable restore
#line 87 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                           if (!string.IsNullOrEmpty(value3))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "span");
            __builder.AddAttribute(81, "class", "text-danger");
            __builder.AddContent(82, 
#nullable restore
#line 88 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                            value3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                         }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "hidden", 
#nullable restore
#line 91 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                      HideAnswer3

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(86, "<strong>Problema:</strong>\r\n            ");
            __builder.AddMarkupContent(87, @"<p>Sunt date <a href=""https://drive.google.com/u/0/uc?id=13Uuo0yslwXKzi1b0bL3SzIdJRE5OznKq&export=download"">două fișiere</a> care conțin cuvinte. Primul fișier conține mai multe cuvinte. Al doilea conține câteva din cuvintele din primul fișier dar literele sunt schimbare cu locul în interiorul cuvintelor.</p>
            <br>
            ");
            __builder.AddMarkupContent(88, "<strong>Sarcina:</strong>\r\n            ");
            __builder.AddMarkupContent(89, "<p>\r\n                Să se găsească cuvintele care se conțin în ambele șiruri. <br>\r\n                Cheia va conține cuvintele concatenate în ordinea din fișierul al doilea.\r\n            </p>\r\n            <br>\r\n            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "row");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-9");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "class", "form-control");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 103 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                        UserAnswer3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserAnswer3 = __value, UserAnswer3));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col-3");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "type", "submit");
            __builder.AddAttribute(103, "class", "btn btn-primary");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                                            () => CheckAnswer(3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "card");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "card-body");
            __builder.OpenElement(111, "h4");
            __builder.AddMarkupContent(112, "\r\n            4. Status : ");
#nullable restore
#line 118 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                           if (!string.IsNullOrEmpty(value4))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(113, "span");
            __builder.AddAttribute(114, "class", "text-danger");
            __builder.AddContent(115, 
#nullable restore
#line 119 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                            value4

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 119 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                         }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "hidden", 
#nullable restore
#line 122 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                      HideAnswer4

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(119, "<strong>Problema:</strong>\r\n            ");
            __builder.AddMarkupContent(120, "<p>Pe pagina <a href=\"https://www.instagram.com/best_chisinau/\">BEST Chişinău</a> de instagram sunt ascunse bucăți de cheie.</p>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(121, "<strong>Sarcina:</strong>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(122, "<p>Găsiți cheia.</p>\r\n            <br>\r\n            ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "row");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "col-9");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "class", "form-control");
            __builder.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 132 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                        UserAnswer4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserAnswer4 = __value, UserAnswer4));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "col-3");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "type", "submit");
            __builder.AddAttribute(136, "class", "btn btn-primary");
            __builder.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                                                            () => CheckAnswer(4)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(138, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n<br>\r\n");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "card");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "card-body");
            __builder.OpenElement(144, "h4");
            __builder.AddMarkupContent(145, "\r\n            5. Status : ");
#nullable restore
#line 146 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                           if (!string.IsNullOrEmpty(value5))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(146, "span");
            __builder.AddContent(147, 
#nullable restore
#line 147 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                        value5

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 147 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                                     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "hidden", 
#nullable restore
#line 150 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
                      HideAnswer5

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(151, "<strong>Problema:</strong>\r\n            ");
            __builder.AddMarkupContent(152, @"<p>Mai jos este atașat un fișier text, care conține un fragment din Odiseea lui Homer. Acest <a href=""https://drive.google.com/u/0/uc?id=1y8NS47bNU0umd6jhWMLCqwCFhiTImoNX&export=download"">fișier</a> a fost criptat în două etape, utilizând doi algoritmi de criptare diferiți.</p>
            <br>
            ");
            __builder.AddMarkupContent(153, "<strong>Sarcina</strong>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(154, "<p>Să se descifreze fragmentul inițial. După ce a fost descifrat, utilizând aceiași algoritmi se va cripta următoarea secvență:</p>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(155, "<p>\r\n                o pace-ntre popor si el a pus,<br>\r\n                atene deci, schimbindu-i sortii pasul,<br>\r\n                si-avind ca Mentor chipul sau si glasul.<br></p>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(156, "<strong>Note:</strong>\r\n            ");
            __builder.AddMarkupContent(157, "<p>Prima etapă de decriptare:</p>\r\n            ");
            __builder.AddMarkupContent(158, "<p>Primul algoritm este xor. <br>\r\n            Se folosește un algoritm simetric, iar lungimea cheii este de 16 biți. În rezultatul decriptării va trebui să obțineți un text care conține doar caractere afișabile.</p>\r\n            ");
            __builder.AddMarkupContent(159, "<p>\r\n                A doua etapă: <br>\r\n                i = i <br>\r\n                v = a, dar a != v <br></p>\r\n            ");
            __builder.AddMarkupContent(160, "<p>Textul inițial conține nume de personaje, munți și alte substantive proprii din Odiseea. Toate sunt scrise cu litere minuscule.</p>\r\n\r\n            ");
            __builder.AddMarkupContent(161, "<strong>Criptarea:</strong>\r\n            ");
            __builder.AddMarkupContent(162, "<p>Textul propus va fi copiat în tocmai ca în sarcină. Textul variantei criptate se recomandă de a fi salvat într-un fișier de unde să fie ulterior copiat și inserat în câmpul cheii.</p>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(163, "<p>Sarcina respectiva se va verifica manual de catre organizatori</p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n<br>\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
       
    [Parameter]
    public string CorrectAnswer { get; set; } = "59008105";

    [Parameter]
    public string CorrectAnswer2 { get; set; } = "9 8 4 1 1 44 8 4 2 86 5 4 2 4";

    [Parameter]
    public string CorrectAnswer3 { get; set; } = "lopatavremeasosindfrumosrotundurechinimenigleznecatargvislas";

    [Parameter]
    public string CorrectAnswer4 { get; set; } = "OGPTRUTSFVUJSPZPOCGGHTYNXYUTEDMXVZAETZEMWTCKIFUPCVNBPCPYLNQLSABMOGLSRCNXLKNKFSZNNRGUTFSPRINEBYYSJROBDJAQXDZUYKUEGMERFUHHXDFDQHRBLXTFMNOQPGKUCNXTHWESFMKMIWXZEWOOKSPJTWATRKHHUQSFZHVRLOAMPNHDRVAQPORHQQCQHWLDAVJSAURWFRNNISWDDJMZPGTMPRRZKIPRZGTDZBERCYTOLHPRWCVWQGDMIPWLQILCCQEWCUWRMQDLXPOOIVEVYOYDKTVRM";

    [Parameter]
    public string CorrectAnswer5 { get; set; } = @"^WY^H^X^[^\U^W^L^K^]Y^H^V^H^V
Y^K^PX^\^TY^YY^H^L^KUr^X^L^\^V^\X^]^]^Z^QUX
^[^Q^Q^T^Z^P^V^]^MT^QY^K^V
^M^Q^PX ^Y
^M^UTs^K^PU^X^N^P^V^]X^Z^YY5^\^V^M^W^KX^Z^P^P^H^L^TY^K^X^MY^K^PX^^^T^X^K^L^TW";

    [Parameter]
    public string CorrectAnswer5_Linux { get; set; } = @"^WY^H^X^[^\U^W^L^K^]Y^H^V^H^V
Y^K^PX^\^TY^YY^H^L^KUr^X^L^\^V^\X^]^]^Z^QUX
^[^Q^Q^T^Z^P^V^]^MT^QY^K^V
^M^Q^PX ^Y
^M^UTs^K^PU^X^N^P^V^]X^Z^YY5^\^V^M^W^KX^Z^P^P^H^L^TY^K^X^MY^K^PX^^^T^X^K^L^TW";

    public string UserAnswer { get; set; }
    public string UserAnswer2 { get; set; }
    public string UserAnswer3 { get; set; }
    public string UserAnswer4 { get; set; }
    public string UserAnswer5 { get; set; }

    public bool HideAnswer = false;
    public bool HideAnswer2 = false;
    public bool HideAnswer3 = false;
    public bool HideAnswer4 = false;
    public bool HideAnswer5 = false;

    public string value, value2, value3, value4, value5 = "";
    //date;

    public int sum = 0;

    List<TeamTask> teamTasks1;
    List<TeamTask> teamTasks2;
    List<TeamTask> teamTasks3;
    List<TeamTask> teamTasks4;
    List<TeamTask> teamTasks5;



    protected async Task CheckAnswer(int VerifyTask)
    {
        switch (VerifyTask)
        {
            case 1:
                if (!string.IsNullOrEmpty(UserAnswer))
                {
                    if (UserAnswer.ToLower() == CorrectAnswer.ToLower())
                    {
                        value = "Correct";
                    }
                    else
                    {
                        value = "Incorrect";
                    }
                }
                break;
            case 2:
                if (!string.IsNullOrEmpty(UserAnswer2))
                {
                    if (UserAnswer2.ToLower() == CorrectAnswer2.ToLower())
                    {
                        value2 = "Correct";
                    }
                    else
                    {
                        value2 = "Incorrect";
                    }
                }
                break;
            case 3:
                if (!string.IsNullOrEmpty(UserAnswer3))
                {
                    if (UserAnswer3.ToLower() == CorrectAnswer3.ToLower())
                    {
                        value3 = "Correct";
                    }
                    else
                    {
                        value3 = "Incorrect";
                    }
                }
                break;
            case 4:
                if (!string.IsNullOrEmpty(UserAnswer4))
                {
                    if (UserAnswer4.ToLower() == CorrectAnswer4.ToLower())
                    {
                        value4 = "Correct";
                    }
                    else
                    {
                        value4 = "Incorrect";
                    }
                }
                break;
            case 5:
                if (!string.IsNullOrEmpty(UserAnswer5))
                {
                    if (UserAnswer5.ToLower() == CorrectAnswer5.ToLower())
                    {
                        value5 = "Correct";
                    }
                    else
                    {
                        value5 = "Incorrect";
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TeamTaskService teamTaskService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
