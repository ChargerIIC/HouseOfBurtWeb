//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseOfBurt.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Version
    {
        public int VersionId { get; set; }
        public string VersionNumber { get; set; }
        public string DownloadLink { get; set; }
        public string Notes { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
