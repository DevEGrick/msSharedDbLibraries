using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace msSharedDbLibrarys.Models
{
    public class TbUsuarios : IdentityUser
    {
        public string? nombres { get; set; }
        public string? apellidos { get; set; }
        public string? nombre_pila { get; set; }
        public string? puesto { get; set; }
        public string? tokenResetPassword { get; set; }
        public DateTime? tokenResetPasswordExpire { get; set; }
    }
}