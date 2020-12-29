using System;

namespace RazorWebApplication.Models
{
    public class Notes
    {
        public int id { get; set; }
        public string dateTime { get; set; }
        public string text { get; set; }
        public string user { get; set; }
    }
}