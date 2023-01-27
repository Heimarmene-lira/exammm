using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammm
{
    public class GoodSaledConfig : IEntityTypeConfiguration<Good_saled>
    {
        public void Configure(EntityTypeBuilder<Good_saled> builder)
        {
            builder.HasKey(u=> new { u.GoodId, u.SaledId });

            builder.HasOne(u => u.Saled).WithMany(u => u.good_Saled).HasForeignKey(u => u.SaledId);
            builder.HasOne(u => u.Good).WithMany(u => u.Good_Saled).HasForeignKey(u => u.GoodId);
        }
    }
}
