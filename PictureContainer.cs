using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryNaturguiden
{
    public class PictureContainer
    {
        public string UrlBase = "http://admin.naturguiden.com";
        public Picture[] Pictures { get; set; }
        public PictureContainer(Picture[] pictures)
        {
            Pictures = pictures;
        }
        public PictureContainer(Picture picture)
        {
            Pictures = new Picture[] { picture };
        }
    }
}
