namespace Gestion
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Stock : DbContext
    {
        public Stock()
            : base("name=Stock")
        {
        }

        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<produit> produit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<categorie>()
                .HasMany(e => e.produit)
                .WithRequired(e => e.categorie)
                .HasForeignKey(e => e.id_categorie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
