using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseOfBurt.Models
{
    public class Version
    {
        public int VersionId { get; set; }
        public string VersionNumber { get; set; }
        public Link DownloadLink { get; set; }
        public string ReleaseNotes { get; set; }
    }
}