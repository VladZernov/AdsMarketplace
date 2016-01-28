namespace AdsMarketplace.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Advertisement")]
    public partial class Advertisement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Advertisement()
        {
            Categories = new HashSet<Category>();
            Users = new HashSet<User>();
        }

        [Key]
        public int AdId { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Price { get; set; }

        public int? DealTypeId { get; set; }

        public int? ConditionId { get; set; }

        public int? StatusId { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        public string ItemDescription { get; set; }

        public virtual Condition Condition { get; set; }

        public virtual User User { get; set; }

        public virtual DealType DealType { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
