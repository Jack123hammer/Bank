//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bank_account_number
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bank_account_number()
        {
            this.Indefication_of_transaction = new HashSet<Indefication_of_transaction>();
            this.Indefication_of_transaction1 = new HashSet<Indefication_of_transaction>();
        }
    
        public int ID_Score { get; set; }
        public Nullable<int> Type_of_agreement { get; set; }
        public Nullable<int> id_account { get; set; }
    
        public virtual Account_physical Account_physical { get; set; }
        public virtual List_of_types_of_agreements List_of_types_of_agreements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indefication_of_transaction> Indefication_of_transaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indefication_of_transaction> Indefication_of_transaction1 { get; set; }
    }
}
