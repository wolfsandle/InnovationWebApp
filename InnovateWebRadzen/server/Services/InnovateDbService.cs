using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using InnovationWebApp.Data;

namespace InnovationWebApp
{
    public partial class InnovateDbService
    {
        private readonly InnovateDbContext context;
        private readonly NavigationManager navigationManager;

        public InnovateDbService(InnovateDbContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportIdeasToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/innovatedb/ideas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/innovatedb/ideas/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportIdeasToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/innovatedb/ideas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/innovatedb/ideas/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnIdeasRead(ref IQueryable<Models.InnovateDb.Idea> items);

        public async Task<IQueryable<Models.InnovateDb.Idea>> GetIdeas(Query query = null)
        {
            var items = context.Ideas.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnIdeasRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnIdeaCreated(Models.InnovateDb.Idea item);
        partial void OnAfterIdeaCreated(Models.InnovateDb.Idea item);

        public async Task<Models.InnovateDb.Idea> CreateIdea(Models.InnovateDb.Idea idea)
        {
            OnIdeaCreated(idea);

            context.Ideas.Add(idea);
            context.SaveChanges();

            OnAfterIdeaCreated(idea);

            return idea;
        }
        public async Task ExportVotesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/innovatedb/votes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/innovatedb/votes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportVotesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/innovatedb/votes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/innovatedb/votes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnVotesRead(ref IQueryable<Models.InnovateDb.Vote> items);

        public async Task<IQueryable<Models.InnovateDb.Vote>> GetVotes(Query query = null)
        {
            var items = context.Votes.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnVotesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnVoteCreated(Models.InnovateDb.Vote item);
        partial void OnAfterVoteCreated(Models.InnovateDb.Vote item);

        public async Task<Models.InnovateDb.Vote> CreateVote(Models.InnovateDb.Vote vote)
        {
            OnVoteCreated(vote);

            context.Votes.Add(vote);
            context.SaveChanges();

            OnAfterVoteCreated(vote);

            return vote;
        }

        partial void OnIdeaDeleted(Models.InnovateDb.Idea item);
        partial void OnAfterIdeaDeleted(Models.InnovateDb.Idea item);

        public async Task<Models.InnovateDb.Idea> DeleteIdea(int? id)
        {
            var item = context.Ideas
                              .Where(i => i.id == id)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnIdeaDeleted(item);

            context.Ideas.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterIdeaDeleted(item);

            return item;
        }

        partial void OnIdeaGet(Models.InnovateDb.Idea item);

        public async Task<Models.InnovateDb.Idea> GetIdeaByid(int? id)
        {
            var items = context.Ideas
                              .AsNoTracking()
                              .Where(i => i.id == id);

            var item = items.FirstOrDefault();

            OnIdeaGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.InnovateDb.Idea> CancelIdeaChanges(Models.InnovateDb.Idea item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnIdeaUpdated(Models.InnovateDb.Idea item);
        partial void OnAfterIdeaUpdated(Models.InnovateDb.Idea item);

        public async Task<Models.InnovateDb.Idea> UpdateIdea(int? id, Models.InnovateDb.Idea idea)
        {
            OnIdeaUpdated(idea);

            var item = context.Ideas
                              .Where(i => i.id == id)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(idea);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterIdeaUpdated(idea);

            return idea;
        }

        partial void OnVoteDeleted(Models.InnovateDb.Vote item);
        partial void OnAfterVoteDeleted(Models.InnovateDb.Vote item);

        public async Task<Models.InnovateDb.Vote> DeleteVote(int? voteid)
        {
            var item = context.Votes
                              .Where(i => i.voteid == voteid)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnVoteDeleted(item);

            context.Votes.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            OnAfterVoteDeleted(item);

            return item;
        }

        partial void OnVoteGet(Models.InnovateDb.Vote item);

        public async Task<Models.InnovateDb.Vote> GetVoteByvoteid(int? voteid)
        {
            var items = context.Votes
                              .AsNoTracking()
                              .Where(i => i.voteid == voteid);

            var item = items.FirstOrDefault();

            OnVoteGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.InnovateDb.Vote> CancelVoteChanges(Models.InnovateDb.Vote item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnVoteUpdated(Models.InnovateDb.Vote item);
        partial void OnAfterVoteUpdated(Models.InnovateDb.Vote item);

        public async Task<Models.InnovateDb.Vote> UpdateVote(int? voteid, Models.InnovateDb.Vote vote)
        {
            OnVoteUpdated(vote);

            var item = context.Votes
                              .Where(i => i.voteid == voteid)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(vote);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            OnAfterVoteUpdated(vote);

            return vote;
        }
    }
}
