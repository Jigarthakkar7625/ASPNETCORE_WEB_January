using System;
using System.Collections.Generic;

namespace ASPNETCORE_WEB.Models;

public partial class TblUserRole
{
    public int UserRoleId { get; set; }

    public int? UserId { get; set; }

    public int RoleId { get; set; }

    public virtual TblRole Role { get; set; } = null!;

    public virtual TblUser? User { get; set; }
}
