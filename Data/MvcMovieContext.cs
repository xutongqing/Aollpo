﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aollpo.Models;

namespace Aollpo.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
