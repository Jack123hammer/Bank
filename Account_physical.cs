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
    
    public partial class Account_physical
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account_physical()
        {
            this.Bank_account_number = new HashSet<Bank_account_number>();
        }
    
        public int ID_account_physical { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int id_passport_data { get; set; }
        public int id_client { get; set; }
        public string Last_name { get; set; }
        public string First_name { get; set; }
        public string Second_name { get; set; }
        public string Phone_number { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Passport_data Passport_data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bank_account_number> Bank_account_number { get; set; }
    }
}
