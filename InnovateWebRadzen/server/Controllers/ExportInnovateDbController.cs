using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnovationWebApp.Data;

namespace InnovationWebApp
{
    public partial class ExportInnovateDbController : ExportController
    {
        private readonly InnovateDbContext context;

        public ExportInnovateDbController(InnovateDbContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/InnovateDb/ideas/csv")]
        [HttpGet("/export/InnovateDb/ideas/csv(fileName='{fileName}')")]
        public FileStreamResult ExportIdeasToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Ideas, Request.Query), fileName);
        }

        [HttpGet("/export/InnovateDb/ideas/excel")]
        [HttpGet("/export/InnovateDb/ideas/excel(fileName='{fileName}')")]
        public FileStreamResult ExportIdeasToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Ideas, Request.Query), fileName);
        }
        [HttpGet("/export/InnovateDb/votes/csv")]
        [HttpGet("/export/InnovateDb/votes/csv(fileName='{fileName}')")]
        public FileStreamResult ExportVotesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Votes, Request.Query), fileName);
        }

        [HttpGet("/export/InnovateDb/votes/excel")]
        [HttpGet("/export/InnovateDb/votes/excel(fileName='{fileName}')")]
        public FileStreamResult ExportVotesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Votes, Request.Query), fileName);
        }
    }
}
