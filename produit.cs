namespace Gestion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("produit")]
    public partial class produit
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string nom { get; set; }

        [Required]
        [StringLength(50)]
        public string reference { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        public float prix { get; set; }

        public int quantite { get; set; }

        [Required]
        public string image { get; set; }

        public int id_categorie { get; set; }

        public virtual categorie categorie { get; set; }
    }
}
