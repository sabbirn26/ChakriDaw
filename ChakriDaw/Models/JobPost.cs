//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChakriDaw.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobPost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobPost()
        {
            this.Applies = new HashSet<Apply>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime DeadLine { get; set; }
        public string Skill { get; set; }
        public int Vacancies { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public int EmployeerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apply> Applies { get; set; }
        public virtual Employeer Employeer { get; set; }
    }
}
