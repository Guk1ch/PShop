//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PShop.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pen()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_Company { get; set; }
        public Nullable<int> ID_Type { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Size { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        public virtual Type Type { get; set; }
    }
}
