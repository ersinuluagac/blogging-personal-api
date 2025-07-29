using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configs
{
    internal class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.Content)
                .IsRequired();
            builder.Property(p => p.Category)
                .IsRequired();
            builder.Property(p => p.Tags)
                .IsRequired();
            builder.Property(p => p.CreatedAt)
                .IsRequired();
            builder.Property(p => p.UpdatedAt)
                .IsRequired(false);

            builder.HasData(
                new Post { Id = 1,
                    Title = "First Post",
                    Content = "This is the content of the first post...",
                    Category = "General",
                    Tags = ["first", "post"],
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                },
                new Post { Id = 2,
                    Title = "Second Post",
                    Content = "This is the content of the second post...",
                    Category = "General",
                    Tags = ["second", "post"],
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null
                }
            );
        }
    }
}
