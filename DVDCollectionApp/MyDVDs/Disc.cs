//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyDVDs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Disc
    {
        public Disc()
        {
            this.Contents = new HashSet<Content>();
        }
    
        public int Id { get; set; }
        public int DiscNumber { get; set; }
        public int TotalContents { get; set; }
        public string Notes { get; set; }
        public bool IsACollection { get; set; }
        public string Title { get; set; }
        public int CaseId { get; set; }
    
        public virtual Case Case { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
    }
}
