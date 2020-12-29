using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorWebApplication.Models;
using RazorWebApplication.Services;

namespace RazorWebApplication.Controllers
{
    public class NotesController : Controller
    {
        private INotesService NotesService { get; }
        
        public NotesController(INotesService notesService)
        {
            NotesService = notesService;
        }

        public async Task<IActionResult> Index()
        {
            return this.View(await this.NotesService.GetNotes());
        }

        public IActionResult Details(Notes model)
        {
            return this.View(model);
        }
    }
}