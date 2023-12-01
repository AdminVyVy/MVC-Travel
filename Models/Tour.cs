//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            this.Comboes = new HashSet<Combo>();
            this.Tour_Inside = new HashSet<Tour_Inside>();
            this.Tour_Outside = new HashSet<Tour_Outside>();
        }
    
        public int ID_tour { get; set; }
        public string Name { get; set; }
        public string Tour_trending { get; set; }
        public Nullable<int> ID_service { get; set; }
        public string Descrip { get; set; }
        public string Total { get; set; }
        public string Time { get; set; }
        public string Img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Combo> Comboes { get; set; }
        public virtual Service Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_Inside> Tour_Inside { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_Outside> Tour_Outside { get; set; }
    }
}
