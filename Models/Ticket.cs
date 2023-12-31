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
    
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.Tour_Inside = new HashSet<Tour_Inside>();
            this.Tour_Outside = new HashSet<Tour_Outside>();
        }
    
        public int ID_ticket { get; set; }
        public string Name { get; set; }
        public string Ticket_code { get; set; }
        public Nullable<int> Numberof_ticket { get; set; }
        public Nullable<int> Ticket_leave { get; set; }
        public Nullable<int> Remaining_ticket { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Note { get; set; }
        public Nullable<int> ID_tour_outside { get; set; }
        public Nullable<int> ID_tour_inside { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_Inside> Tour_Inside { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_Outside> Tour_Outside { get; set; }
        public virtual Tour_Inside Tour_Inside1 { get; set; }
        public virtual Tour_Outside Tour_Outside1 { get; set; }
    }
}
