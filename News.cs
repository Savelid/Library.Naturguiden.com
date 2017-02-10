using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryNaturguiden
{
    public class News
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Creator { get; set; }
        public string Heading { get; set; }
        public string Text { get; set; }
        public int PictureId { get; set; }
        public Picture Picture { get; set; }
        public string LinkUrl { get; set; }
        public string LinkText { get; set; }
        public int Position { get; set; }
    }
}
