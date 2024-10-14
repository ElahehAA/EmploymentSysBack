using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Table("AdvertismentCat")]
    public partial class AdvertismentCat
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [StringLength(64)]
        public string Name { get; set; } = null!;
        public long Code { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
