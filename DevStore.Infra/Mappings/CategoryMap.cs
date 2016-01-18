using DevStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace DevStore.Infra.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        // Method Constructor
        public CategoryMap()
        {
            ToTable("Category");
            HasKey(x => x.Id); // Diz que ID é a chave
            Property(x => x.Title)
                .HasMaxLength(60) // tamanho máximo
                .IsRequired(); // indica que o campo é requerido
        }
    }
}
