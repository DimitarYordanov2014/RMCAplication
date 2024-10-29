using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data
{
    public class RMCApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public RMCApplicationDbContext(DbContextOptions<RMCApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
