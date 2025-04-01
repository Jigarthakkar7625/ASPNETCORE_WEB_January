using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETCORE_WEB.Models;


[Table("Role")] // Table
public class TblRole
{
    [Key] // PK
    public int RoleId { get; set; }

    [Column("Role")]
    public string? RoleName { get; set; }

    //[Index("INDEX_REGNUM", IsUnique = true)]
    [Required]
    [MaxLength(10)]
    public string? RoleDescription { get; set; }

    [NotMapped]
    public string? RoleAddress { get; set; }

    //[ForeignKey("UserId")]
    //public int userId { get; set; }
    //public TblUser User { get; set; }
}


