using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aplicacao01.Models;

namespace aplicacao01.Data
{
    public class aplicacao01Context : DbContext
    {
        public aplicacao01Context (DbContextOptions<aplicacao01Context> options)
            : base(options)
        {
        }

        public DbSet<aplicacao01.Models.Departamento> Departamento { get; set; }
    }
}
