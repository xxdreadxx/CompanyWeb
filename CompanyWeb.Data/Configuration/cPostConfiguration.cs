﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using CompanyWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Data.Configuration
{
    public class cPostConfiguration : IEntityTypeConfiguration<cPost>
    {
        public void Configure(EntityTypeBuilder<cPost> builder)
        {
            builder.ToTable("cPost");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Title).IsRequired(true).IsUnicode(true);
        }
    }
}
