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
    
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.Bank_account_number = new HashSet<Bank_account_number>();
        }
    
        public int ID_account { get; set; }
        public int id_passport_data { get; set; }
        public string phone_number { get; set; }
        public Nullable<int> type_of_clients { get; set; }
        public Nullable<int> id_organization { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Entity_clients Entity_clients { get; set; }
        public virtual Passport_data Passport_data { get; set; }
        public virtual Types_of_clients Types_of_clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bank_account_number> Bank_account_number { get; set; }
    }
}
