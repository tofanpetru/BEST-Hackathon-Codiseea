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
#nullable restore
#line 8 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 212 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
       


    public string UserAnswer { get; set; }

    //date;

    List<TeamTask> teamTasks1;
    List<TeamTask> teamTasks2;
    List<TeamTask> teamTasks3;
    List<TeamTask> teamTasks4;
    List<TeamTask> teamTasks5;

    List<TeamTask> globalCorrectAnswers;
    List<TeamTask> personalCorrectAnswers;

    //List<Answer> Answers;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        var teamName = httpContextAccessor.HttpContext.User.Identity.Name;

        teamTasks1 = await teamTaskService?.GetTasksAsync(teamName, "1");
        teamTasks2 = await teamTaskService?.GetTasksAsync(teamName, "2");
        teamTasks3 = await teamTaskService?.GetTasksAsync(teamName, "3");
        teamTasks4 = await teamTaskService?.GetTasksAsync(teamName, "4");
        teamTasks5 = await teamTaskService?.GetTasksAsync(teamName, "5");

        globalCorrectAnswers = await teamTaskService.GetGlobalCorrectAnswersAsync();
        personalCorrectAnswers = await teamTaskService.GetPersonalTasksAsync(teamName);

        //Answers = await teamTaskService?.GetAnswersAsync();
    }
    public double personalProgressWhoutPrecent;
    public string PersonalProgress()
    {
        int TotalTasks = 5;
        double result = ((personalCorrectAnswers.Count * 100) / TotalTasks);
        personalProgressWhoutPrecent = result;
        return Convert.ToString(((personalCorrectAnswers.Count*100)/TotalTasks)+"%");
    }

    protected string StatusAnswer(List<TeamTask> Task)
    {
        string result = null;

        foreach (var item in Task)
        {
            result = (item.Value == "Correct") ? item.Value : "Incorrect";
        }
        return result;
    }

    protected bool HideAnswer(List<TeamTask> Task)
    {
        bool result = false;

        foreach (var item in Task)
        {
            result = (item.Value == "Correct") ? true : false;
        }
        return result;
    }


    public List<Answer> CorrectAnswers1 = new List<Answer>()
    {//urmeaza sa o fac cu bd
        new Answer()
        {
            ID=1,
            Task="59008105"
        },
        new Answer()
        {
            ID=2,
            Task="9 8 4 1 1 44 8 4 2 86 5 4 2 4"
        },
        new Answer()
        {
            ID=3,
            Task="lopatavremeasosindfrumosrotundurechinimenigleznecatargvislas"
        },
        new Answer()
        {
            ID=4,
            Task="OGPTRUTSFVUJSPZPOCGGHTYNXYUTEDMXVZAETZEMWTCKIFUPCVNBPCPYLNQLSABMOGLSRCNXLKNKFSZNNRGUTFSPRINEBYYSJROBDJAQXDZUYKUEGMERFUHHXDFDQHRBLXTFMNOQPGKUCNXTHWESFMKMIWXZEWOOKSPJTWATRKHHUQSFZHVRLOAMPNHDRVAQPORHQQCQHWLDAVJSAURWFRNNISWDDJMZPGTMPRRZKIPRZGTDZBERCYTOLHPRWCVWQGDMIPWLQILCCQEWCUWRMQDLXPOOIVEVYOYDKTVRM"},
        new Answer()
        {
            ID=5,
            Task="2 6"
        }
    };

    public List<string> userAnswer1 = new List<string>();

    protected async Task CheckAnswer(int VerifyTask)
    {
        try
        {
            DateTime now = DateTime.Now;

            var totalAnswers = CorrectAnswers1.Count;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 321 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
              
            userAnswer1.Add(UserAnswer);
            var points = (now.Hour >= 24 / 2) ? ((int)((now.Hour * VerifyTask) / 2) / totalAnswers) : ((int)(now.Hour * VerifyTask) / totalAnswers);

            if (CorrectAnswers1.Any()) 
            {
                foreach (var item in CorrectAnswers1)
                {
                    foreach (var answer in userAnswer1)
                    {
                        if (answer.Contains(item.Task) && item.ID == VerifyTask)
                        {
                            TeamTask s = new TeamTask()
                            {
                                ID = Guid.NewGuid().ToString(),
                                TeamName = httpContextAccessor.HttpContext.User.Identity.Name,
                                Value = "Correct",
                                Points = points,
                                ItemNumber = Convert.ToString(VerifyTask),
                                Attempts = 0,
                                Date = DateTime.Now,
                            };

                            await teamTaskService.InsertTeamTaskAsync(s);
                            await load();
                        }
                    }
                }
            }
            else
            {
                //value = "Incorrect";
            }
        }
        catch (Exception e)
        {

            throw new Exception(e.ToString());
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
