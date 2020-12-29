using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Database.EFCore.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private ILogger<NotesController> Logger { get; }
        private INotesDataAccess NotesDataAccess { get; }
        private IMapper Mapper { get;  }
        

        public NotesController(ILogger<NotesController> logger, INotesDataAccess notesDataAccess, IMapper mapper)
        {
            Logger = logger;
            NotesDataAccess = notesDataAccess;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Notes>> Get(CancellationToken ct = default)
        {
            this.Logger.LogDebug($"{nameof(NotesController)}.{nameof(Get)} executed");
            
            return this.Mapper.Map<IEnumerable<Notes>>(await this.NotesDataAccess.GetAllAsync(ct));
        }
    }
}