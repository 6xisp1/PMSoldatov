//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lombard_Soldatov.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prodaza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prodaza()
        {
            this.User = new HashSet<User>();
        }
    
        public string ID_Prodazy { get; set; }
        public string Tovary { get; set; }
        public string Data_prodazy { get; set; }
        public string Stoimost { get; set; }
        public string Sotrudnik { get; set; }
        public string Client { get; set; }
    
        public virtual Clienty Clienty { get; set; }
        public virtual Platez Platez { get; set; }
        public virtual Tovary Tovary1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}
