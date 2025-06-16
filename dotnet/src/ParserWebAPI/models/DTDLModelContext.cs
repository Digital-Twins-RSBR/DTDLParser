using Microsoft.EntityFrameworkCore;
namespace ParserWebAPI.models
{
    public class DTDLModelContext :DbContext
    {
        public DTDLModelContext(DbContextOptions<DTDLModelContext> options) : base(options) { }
        public DbSet<DTDLModel> DTDLModels { get; set; } = null!;    
        
        public async Task<Task<int>> AddOrUpdateModel(DTDLModel dtdlModel)
        {
            var existingModel = DTDLModels.FirstOrDefault(m => m.Id == dtdlModel.Id);
            if (existingModel != null)
            {
                existingModel.Name = dtdlModel.Name;
                existingModel.modelElements = dtdlModel.modelElements;
                existingModel.modelRelationships = dtdlModel.modelRelationships;
                Update(existingModel);
            }
            else
            {
                Add(dtdlModel);
            }
            return SaveChangesAsync();
        }
    }
}
