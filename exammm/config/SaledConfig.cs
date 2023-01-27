using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public class SaledConfig : IEntityTypeConfiguration<Saled>
    {
        public void Configure(EntityTypeBuilder<Saled> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Date);
            builder.HasIndex(u => u.Sum);

            builder.HasOne(u => u.Users).WithMany(u => u.Saled).HasForeignKey(u => u.UserId);
        }
    }
}
