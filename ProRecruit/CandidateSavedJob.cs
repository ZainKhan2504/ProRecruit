//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProRecruit
{
    using System;
    using System.Collections.Generic;
    
    public partial class CandidateSavedJob
    {
        public int Id { get; set; }
        public string CandidateId { get; set; }
        public Nullable<int> JobId { get; set; }
    
        public virtual Candidate Candidate { get; set; }
        public virtual Job Job { get; set; }
    }
}