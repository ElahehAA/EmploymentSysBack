using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Table("Advertisment")]
    public partial class Advertisment
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("jobName")]
        [StringLength(64)]
        public string JobName { get; set; } = null!;
        public long AdvertismentCatId { get; set; }
        public int CityId { get; set; }
        /// <summary>
        /// خانم 1//
        /// آقا 2//
        /// خانم/آقا 0
        /// </summary>
        [Column("gender")]
        public int Gender { get; set; }
        [StringLength(64)]
        public string Rights { get; set; } = null!;
        [Column("militaryStatus")]
        [StringLength(64)]
        public string MilitaryStatus { get; set; } = null!;
        public int MinHistory { get; set; }
        [StringLength(64)]
        public string? MinimumEducationDegree { get; set; }
        public string? Desc { get; set; }
        public bool IsConfirm { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        [Column("CUserId")]
        public long? CuserId { get; set; }

        [ForeignKey("AdvertismentCatId")]
        [InverseProperty("Advertisments")]
        public virtual AdvertismentCat AdvertismentCat { get; set; } = null!;
        [ForeignKey("CityId")]
        [InverseProperty("Advertisments")]
        public virtual Location City { get; set; } = null!;
        [ForeignKey("CuserId")]
        [InverseProperty("Advertisments")]
        public virtual User? Cuser { get; set; }
    }
}
