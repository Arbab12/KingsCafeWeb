//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KingsCafe.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbKingsCafeEntities : DbContext
    {
        public dbKingsCafeEntities()
            : base("name=dbKingsCafeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdmin> tblAdmins { get; set; }
        public virtual DbSet<tblfeedback> tblfeedbacks { get; set; }
        public virtual DbSet<tblFoodCategory> tblFoodCategories { get; set; }
        public virtual DbSet<tblFoodProduct> tblFoodProducts { get; set; }
        public virtual DbSet<tblIngredient> tblIngredients { get; set; }
        public virtual DbSet<tblIngredientLinking> tblIngredientLinkings { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }
        public virtual DbSet<tblOrderDetail> tblOrderDetails { get; set; }
        public virtual DbSet<tblOrderLinking> tblOrderLinkings { get; set; }
        public virtual DbSet<tblOrderPurchase> tblOrderPurchases { get; set; }
        public virtual DbSet<tblOrderPurchaseDetail> tblOrderPurchaseDetails { get; set; }
        public virtual DbSet<tblRider> tblRiders { get; set; }
        public virtual DbSet<tblRiderAssigningOrder> tblRiderAssigningOrders { get; set; }
        public virtual DbSet<tblWorker> tblWorkers { get; set; }
        public virtual DbSet<tblWorkerDetail> tblWorkerDetails { get; set; }
    }
}
