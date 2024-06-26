using Microsoft.EntityFrameworkCore;
namespace ParserWebAPI.models
{
    public class DTDLModelContext :DbContext
    {
        public DTDLModelContext(DbContextOptions<DTDLModelContext> options) : base(options) { }
        public DbSet<DTDLModel> DTDLModels { get; set; } = null!;     
    }
}
