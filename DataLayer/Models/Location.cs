using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Table("Location")]
    public partial class Location
    {
        public Location()
        {
            Advertisments = new HashSet<Advertisment>();
            InversePidNavigation = new HashSet<Location>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PId")]
        public int? Pid { get; set; }
        [StringLength(32)]
        public string Name { get; set; } = null!;

        [ForeignKey("Pid")]
        [InverseProperty("InversePidNavigation")]
        public virtual Location? PidNavigation { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<Advertisment> Advertisments { get; set; }
        [InverseProperty("PidNavigation")]
        public virtual ICollection<Location> InversePidNavigation { get; set; }
    }
}
