using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models
{
    [Table("Role")]
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(32)]
        public string Name { get; set; } = null!;

        [InverseProperty("Role")]
        public virtual ICollection<User> Users { get; set; }
    }
}
