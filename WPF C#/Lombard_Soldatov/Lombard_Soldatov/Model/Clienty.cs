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
    
    public partial class Clienty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clienty()
        {
            this.Prodaza = new HashSet<Prodaza>();
        }
    
        public string ID_Clienta { get; set; }
        public string Familia { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
        public string Nomer_telefona { get; set; }
        public string Seria_pasporta { get; set; }
        public string Nomer_pasporta { get; set; }
        public string Kem_vydan_pasport { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prodaza> Prodaza { get; set; }
    }
}
