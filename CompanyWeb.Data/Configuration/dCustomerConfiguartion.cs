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
    public class dCustomerConfiguartion : IEntityTypeConfiguration<dCustomer>
    {
        public void Configure(EntityTypeBuilder<dCustomer> builder)
        {
            builder.ToTable("dCustomer");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Title).IsUnicode(true);
            builder.Property(x => x.Content).IsUnicode(true);
        }
    }
}
