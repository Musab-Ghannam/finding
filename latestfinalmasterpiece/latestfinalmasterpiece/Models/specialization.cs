//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace latestfinalmasterpiece.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class specialization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public specialization()
        {
            this.doctors = new HashSet<doctor>();
        }
    
        public int specializationId { get; set; }
        public string namespecialization { get; set; }
        public string descriptionspecialization { get; set; }
        public string picturespecialization { get; set; }
        public string videospecializaion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doctor> doctors { get; set; }
    }
}
