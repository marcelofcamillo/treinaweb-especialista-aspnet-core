using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace twtodolist.EntityConfigs;

public class TodoEntityConfig : IEntityTypeConfiguration<Models.Todo>
{
    public void Configure(EntityTypeBuilder<Models.Todo> builder)
    {
        builder.ToTable("todo");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");

        builder
            .Property(x => x.Title)
            .HasColumnName("title")
            .HasColumnType("nvarchar(100)")
            .IsRequired();

        builder.Property(x => x.Date).HasColumnName("date").HasColumnType("date").IsRequired();

        builder
            .Property(x => x.IsCompleted)
            .HasColumnName("is_completed")
            .HasColumnType("bit")
            .IsRequired();
    }
}
