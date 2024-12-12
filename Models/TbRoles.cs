using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace msSharedDbLibrarys.Models
{
    public class TbRoles : IdentityRole
    {
        public string? Descripcion { get; set; }
    }
}