using System;

namespace WebApplication.EFCore
{
    public class Notes
    {
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public string text { get; set; }
        public string user { get; set; }
    }
}