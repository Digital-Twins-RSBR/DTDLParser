using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace ParserWebAPI.models
{
    public class DTDLSpecificationContext:DbContext
    {
        public DTDLSpecificationContext(DbContextOptions<DTDLSpecificationContext> options) : base(options) { }
        public DbSet<DTDLSpecification> DTDLSpecifications { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura um Value Converter para a propriedade 'specification'
            var objectToJsonConverter = new ValueConverter<object, string>(
                v => JsonSerializer.Serialize(v, new JsonSerializerOptions { WriteIndented = false }), // Converte objeto para JSON sem quebras de linha
                v => JsonSerializer.Deserialize<object>(v, (JsonSerializerOptions)null) // Converte JSON para objeto
            );

            modelBuilder.Entity<DTDLSpecification>()
                .Property(e => e.specification)
                .HasConversion(objectToJsonConverter);
        }

        public void AddOrUpdateSpecification(string dtmi,string specification)
        {
            var dtdlSpecification = new DTDLSpecification
            {
                id = dtmi,
                specification = specification
            };
            var existingSpecification = DTDLSpecifications.FirstOrDefault(m => m.id == dtdlSpecification.id);
            if (existingSpecification != null)
            {
                existingSpecification.specification = dtdlSpecification.specification;
                Update(existingSpecification);
            }
            else
            {
                Add(dtdlSpecification);
            }

            SaveChanges();
        }
    }
}
