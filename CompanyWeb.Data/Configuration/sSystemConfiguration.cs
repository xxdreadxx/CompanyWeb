using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PerfumeStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Data.Configuration
{
    public class sSystemConfiguration : IEntityTypeConfiguration<sSystem>
    {
        public void Configure(EntityTypeBuilder<sSystem> builder)
        {
            builder.ToTable("sSystem");
            builder.HasKey(x => x.ID);
        }
    }
}
