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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Bank_account_number> Bank_account_number { get; set; }
        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Entity_clients> Entity_clients { get; set; }
        public virtual DbSet<List_of_position> List_of_position { get; set; }
        public virtual DbSet<List_of_types_of_agreements> List_of_types_of_agreements { get; set; }
        public virtual DbSet<Passport_data> Passport_data { get; set; }
        public virtual DbSet<Reciever> Reciever { get; set; }
        public virtual DbSet<Sender> Sender { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Types_of_clients> Types_of_clients { get; set; }
    }
}
