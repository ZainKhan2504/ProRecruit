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
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.CandidateJobs = new HashSet<CandidateJob>();
            this.CandidateSavedJobs = new HashSet<CandidateSavedJob>();
            this.JobQualifications = new HashSet<JobQualification>();
            this.JobSkills = new HashSet<JobSkill>();
            this.MatchedCandidates = new HashSet<MatchedCandidate>();
        }
    
        public Nullable<System.DateTime> DatePublished { get; set; }
        public Nullable<System.DateTime> DateApplyBy { get; set; }
        public string Title { get; set; }
        public string JobDescription { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string FunctionalArea { get; set; }
        public string JobShift { get; set; }
        public string Gender { get; set; }
        public string ReqYearsOfExp { get; set; }
        public string AgeRequirement { get; set; }
        public string UserId { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public Nullable<int> HighestDegree { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CandidateJob> CandidateJobs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CandidateSavedJob> CandidateSavedJobs { get; set; }
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobQualification> JobQualifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobSkill> JobSkills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchedCandidate> MatchedCandidates { get; set; }
    }
}
