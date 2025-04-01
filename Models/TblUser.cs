using System;
using System.Collections.Generic;

namespace ASPNETCORE_WEB.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public int? Gender { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<TblUserRole> TblUserRoles { get; set; } = new List<TblUserRole>();
}
