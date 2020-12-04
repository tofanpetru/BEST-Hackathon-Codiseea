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
#line 7 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
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
#line 208 "C:\Users\Tofan\OneDrive\Desktop\Endava\Hackathon codiseea\BEST-Hackathon-Codiseea\Pages\StageOne.razor"
       
    [Parameter]
    public string CorrectAnswer { get; set; } = "bestchisinaucodiseeahackathon2020decembrie";
    [Parameter]
    public string CorrectAnswer2 { get; set; } = "58738108";
    [Parameter]
    public string CorrectAnswer3 { get; set; } = "9 8 4 1 1 2 44 8 4 5 86 2 4 4";
    [Parameter]
    public string CorrectAnswer4 { get; set; } = "text";
    [Parameter]
    public string CorrectAnswer5 { get; set; } = "58738108";

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

    string taskId;
    string teamName;
    public string value = "";
    string points;
    //date;

    public int sum = 0;

    List<TeamTask> teamTasks1;
    List<TeamTask> teamTasks2;
    List<TeamTask> teamTasks3;
    List<TeamTask> teamTasks4;
    List<TeamTask> teamTasks5;

    List<TeamTask> totalPoints;

    TeamTask teamTask;

    protected async Task load()
    {
        var teamName = httpContextAccessor.HttpContext.User.Identity.Name;
        teamTasks1 = await teamTaskService.GetTasksAsync(teamName, "1");
        teamTasks2 = await teamTaskService.GetTasksAsync(teamName, "2");
        teamTasks3 = await teamTaskService.GetTasksAsync(teamName, "3");
        teamTasks4 = await teamTaskService.GetTasksAsync(teamName, "4");
        teamTasks5 = await teamTaskService.GetTasksAsync(teamName, "5");
        totalPoints = await teamTaskService.GetTotalPointsAsync(teamName);

    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await load();
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected async Task CheckAnswer(int VerifyTask)
    {
        try
        {
            switch (VerifyTask)
            {
                case 1:
                    if (!string.IsNullOrEmpty(UserAnswer))
                    {
                        if (UserAnswer.ToLower() == CorrectAnswer.ToLower())
                        {
                            TeamTask s = new TeamTask()
                            {
                                ID = Guid.NewGuid().ToString(),
                                TeamName = httpContextAccessor.HttpContext.User.Identity.Name,
                                Value = "Correct",
                                Points = 3,
                                ItemNumber = "1",
                                Date = DateTime.Now,
                            };

                            await teamTaskService.InsertTeamTaskAsync(s);
                            await load();
                        }
                        else
                        {
                            value = "Incorrect";
                        }
                    }
                    break;
                case 2:
                    if (UserAnswer2.Length >= 0 || UserAnswer2 == null)
                    {
                        if (UserAnswer2.ToLower() == CorrectAnswer2.ToLower())
                        {
                            TeamTask s = new TeamTask()
                            {
                                ID = Guid.NewGuid().ToString(),
                                TeamName = httpContextAccessor.HttpContext.User.Identity.Name,
                                Value = "Correct",
                                Points = 5,
                                ItemNumber = "2",
                                Date = DateTime.Now,
                            };

                            await teamTaskService.InsertTeamTaskAsync(s);
                            await load();
                        }
                    }
                    break;
                case 3:
                    if (UserAnswer3.Length >= 0 || UserAnswer3 == null)
                    {
                        if (UserAnswer3.ToLower() == CorrectAnswer3.ToLower())
                        {
                            TeamTask s = new TeamTask()
                            {
                                ID = Guid.NewGuid().ToString(),
                                TeamName = httpContextAccessor.HttpContext.User.Identity.Name,
                                Value = "Correct",
                                Points = 8,
                                ItemNumber = "3",
                                Date = DateTime.Now,
                            };

                            await teamTaskService.InsertTeamTaskAsync(s);
                            await load();
                        }
                    }
                    break;
                case 4:
                    if (UserAnswer4.Length >= 0 || UserAnswer4 == null)
                    {
                        if (UserAnswer4.ToLower() == CorrectAnswer4.ToLower())
                        {
                            TeamTask s = new TeamTask()
                            {
                                ID = Guid.NewGuid().ToString(),
                                TeamName = httpContextAccessor.HttpContext.User.Identity.Name,
                                Value = "Correct",
                                Points = 15,
                                ItemNumber = "4",
                                Date = DateTime.Now,
                            };

                            await teamTaskService.InsertTeamTaskAsync(s);
                            await load();
                        }
                    }
                    break;
                case 5:
                    if (UserAnswer5.Length >= 0 || UserAnswer5 == null)
                    {
                        if (UserAnswer5.ToLower() == CorrectAnswer5.ToLower())
                        {
                            TeamTask s = new TeamTask()
                            {
                                ID = Guid.NewGuid().ToString(),
                                TeamName = httpContextAccessor.HttpContext.User.Identity.Name,
                                Value = "Correct",
                                Points = 17,
                                ItemNumber = "5",
                                Date = DateTime.Now,
                            };

                            await teamTaskService.InsertTeamTaskAsync(s);
                            await load();
                        }
                    }
                    break;
                default:
                    value = "False";
                    break;
            }
        }
        catch (Exception)
        {

            throw;
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
