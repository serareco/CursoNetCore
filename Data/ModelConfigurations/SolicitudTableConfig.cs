using Entities.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oracle.EntityFrameworkCore;

namespace Data.ModelConfigurations
{
    public class SolicitudTableConfig:IEntityTypeConfiguration<SolicitudItem>
    {
        public void Configure(EntityTypeBuilder<SolicitudItem> e)
        {
            e.ToTable("T_SOLICITUDES");
           // e.Property(e => e.Id).ValueGeneratedNever();
        }
    }
}