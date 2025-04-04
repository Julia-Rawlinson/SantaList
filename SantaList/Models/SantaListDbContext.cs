﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SantaList.Models
{
    public class SantaListDbContext : IdentityDbContext<AppUsers>
    {
        public SantaListDbContext(DbContextOptions<SantaListDbContext> options) : base(options) { }
    }
}
