using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Database.EFCore.Entities;

namespace Database.EFCore.Contracts
{
    public interface INotesDataAccess
    {
        Task<IEnumerable<NoteEntity>> GetAllAsync(CancellationToken ct = default);
    }
}