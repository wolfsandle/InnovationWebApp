using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using InnovationWebApp.Models.InnovateDb;
using Microsoft.EntityFrameworkCore;

namespace InnovationWebApp.Pages
{
    public partial class SubmitAnIdeaComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected InnovateDbService InnovateDb { get; set; }

        InnovationWebApp.Models.InnovateDb.Idea _idea;
        protected InnovationWebApp.Models.InnovateDb.Idea idea
        {
            get
            {
                return _idea;
            }
            set
            {
                if (!object.Equals(_idea, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "idea", NewValue = value, OldValue = _idea };
                    _idea = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            idea = new InnovationWebApp.Models.InnovateDb.Idea(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(InnovationWebApp.Models.InnovateDb.Idea args)
        {
            try
            {
                var innovateDbCreateIdeaResult = await InnovateDb.CreateIdea(idea);
                DialogService.Close(idea);
            }
            catch (System.Exception innovateDbCreateIdeaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Idea!");
            }
        }

        protected async System.Threading.Tasks.Task Button1Click(MouseEventArgs args)
        {
                NotificationService.Notify(NotificationSeverity.Success, $"Success", $"Your idea has been recorded");
            UriHelper.NavigateTo("welcome");
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("welcome");
        }
    }
}
