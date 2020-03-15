using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentity.Models
{
    public class ApplicationUser:IdentityUser
    {
        public Class Class { get; set; } 
    }
    public enum Class
    {
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    };
}
