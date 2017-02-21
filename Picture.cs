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
        [Required]
        [Display(Name="File Name")]
        public string FileName { get; set; }
        public string Url { get; set; }
        [Display(Name = "Formated Url")]
        public string FormatedUrl { get; set; }
        [Display(Name = "Thumbnail Url")]
        public string ThumbUrl { get; set; }
        [MaxLength(99)]
        [Display(Name = "Alt. text")]
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
