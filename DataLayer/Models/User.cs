using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            Advertisments = new HashSet<Advertisment>();
        }

        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        public string UserName { get; set; } = null!;
        [StringLength(64)]
        public string Password { get; set; } = null!;
        [Column("RoleID")]
        public int RoleId { get; set; }
        [StringLength(11)]
        public string? PhoneNum { get; set; }
        [StringLength(32)]
        public string? Email { get; set; }
        public string? Address { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; } = null!;
        [InverseProperty("Cuser")]
        public virtual ICollection<Advertisment> Advertisments { get; set; }
    }
}
