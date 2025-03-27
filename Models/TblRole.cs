using System;
using System.Collections.Generic;

namespace ASPNETCORE_WEB.Models;

public partial class TblRole
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<TblUserRole> TblUserRoles { get; set; } = new List<TblUserRole>();
}
