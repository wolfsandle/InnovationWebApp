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
    public partial class VoteForIdeasComponent : ComponentBase
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
        protected RadzenGrid<InnovationWebApp.Models.InnovateDb.Idea> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<InnovationWebApp.Models.InnovateDb.Idea> _getIdeasResult;
        protected IEnumerable<InnovationWebApp.Models.InnovateDb.Idea> getIdeasResult
        {
            get
            {
                return _getIdeasResult;
            }
            set
            {
                if (!object.Equals(_getIdeasResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getIdeasResult", NewValue = value, OldValue = _getIdeasResult };
                    _getIdeasResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

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

        bool _isEdit;
        protected bool isEdit
        {
            get
            {
                return _isEdit;
            }
            set
            {
                if (!object.Equals(_isEdit, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "isEdit", NewValue = value, OldValue = _isEdit };
                    _isEdit = value;
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
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }

            var innovateDbGetIdeasResult = await InnovateDb.GetIdeas(new Query() { Filter = "i => i.firstName.Contains(@0) || i.lastName.Contains(@1) || i.email.Contains(@2) || i.business.Contains(@3) || i.office.Contains(@4) || i.ideaDescription.Contains(@5) || i.scope.Contains(@6)", FilterParameters = new object[] { search, search, search, search, search, search, search } });
            getIdeasResult = innovateDbGetIdeasResult;

            idea = innovateDbGetIdeasResult.FirstOrDefault();

            isEdit = true;
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(InnovationWebApp.Models.InnovateDb.Idea args)
        {
            isEdit = true;

            idea = args;
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var innovateDbDeleteIdeaResult = await InnovateDb.DeleteIdea(data.id);
                    if (innovateDbDeleteIdeaResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception innovateDbDeleteIdeaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Idea");
            }
        }

        protected async System.Threading.Tasks.Task Form0Submit(InnovationWebApp.Models.InnovateDb.Idea args)
        {
            try
            {
                if (isEdit)
                {
                    var innovateDbUpdateIdeaResult = await InnovateDb.UpdateIdea(idea.id, idea);
                        NotificationService.Notify(NotificationSeverity.Success, $"Success", $"Idea updated!");


                }
            }
            catch (System.Exception innovateDbUpdateIdeaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Idea");
            }

            try
            {
                if (!this.isEdit)
                {
                    var innovateDbCreateIdeaResult = await InnovateDb.CreateIdea(args);
                    idea = new InnovationWebApp.Models.InnovateDb.Idea();

                        NotificationService.Notify(NotificationSeverity.Success, $"Success", $"Idea created!");
                }
            }
            catch (System.Exception innovateDbCreateIdeaException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Idea!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("welcome");
        }
    }
}
