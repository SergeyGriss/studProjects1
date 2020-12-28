using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Contracts;
using Database.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.EFCore.Implementations
{
    public class NotesDataAccess : INotesDataAccess
    {
        private NoteContext NoteContext { get; }
        
        public NotesDataAccess(NoteContext noteContext)
        {
            NoteContext = noteContext;
        }

        public async Task<IEnumerable<NoteEntity>> GetAllAsync(CancellationToken ct = default)
        {
            return await this.NoteContext.Notes
                .ToListAsync(ct);
        }
    }
}