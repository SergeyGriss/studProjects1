using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.EFCore.Entities
{
    [Table("Notes")]
    public class NoteEntity
    {
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public string text { get; set; }
        public string user { get; set; }
        public NoteEntity()
        {

        }
        public NoteEntity(int NewId, DateTime NewDateTime, string NewText, string userName)
        {
            id = NewId;
            dateTime = NewDateTime;
            text = NewText;
            user = userName;
            Console.WriteLine($"New note from {userName} created: \"{NewText}\"");
        }
    }
}