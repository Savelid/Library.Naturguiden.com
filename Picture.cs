using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryNaturguiden
{
    public class Picture
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        [Required]
        public string Url { get; set; }
        public string FormatedUrl { get; set; }
        public string ThumbUrl { get; set; }
        [MaxLength(99)]
        public string Alt { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [MaxLength(99)]
        public string Owner { get; set; }
        [MaxLength(49)]
        public string Format { get; set; }
        public List<int> Categories { get; set; }
    }
}
